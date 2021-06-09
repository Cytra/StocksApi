using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Stocks.Data.Contexts;
using Stocks.Data.Entities;
using Stocks.Model;

namespace Stocks.Data.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : EntityBase

        {
            internal StocksContext context;
            internal DbSet<TEntity> dbSet;

            public GenericRepository(StocksContext context)
            {
                this.context = context;
                dbSet = context.Set<TEntity>();
            }

            public virtual async Task<List<TEntity>> Get(
                Expression<Func<TEntity, bool>> filter = null,
                Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
                string includeProperties = "")
            {
                IQueryable<TEntity> query = dbSet;

                if (filter != null)
                {
                    query = query.Where(filter);
                }

                foreach (var includeProperty in includeProperties.Split
                    (new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }

                if (orderBy != null)
                {
                    return await orderBy(query).ToListAsync();
                }
                else
                {
                    return await query.ToListAsync();
                }
            }

        public virtual async Task<PagedListDb<TEntity>> GetPaged(int page, int rowsPerPage, Expression<Func<TEntity, bool>> filter = null)
        {
            IQueryable<TEntity> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }
            var total = await query.CountAsync();
            query = query.OrderByDescending(x => x.Id).Skip((page - 1) * rowsPerPage)
                .Take(rowsPerPage);
            return new PagedListDb<TEntity>()
            {
                Items = query.ToList(),
                Paging = new Stocks.Data.Entities.PagingModelDb() { Page = page, PageSize = rowsPerPage, TotalItems = total }
            };
        }

        public virtual async Task<TEntity> GetById(object id)
            {
                return await dbSet.FindAsync(id);
            }

            public virtual async Task Insert(TEntity entity, bool save)
            {
                dbSet.Add(entity);
                if (save) { await Save(); }
            }

            public virtual async Task Delete(object id, bool save)
            {
                TEntity entityToDelete = dbSet.Find(id);
                await Delete(entityToDelete, save);
            }

            public virtual async Task Delete(TEntity entityToDelete, bool save)
            {
                if (context.Entry(entityToDelete).State == EntityState.Detached)
                {
                    dbSet.Attach(entityToDelete);
                }
                dbSet.Remove(entityToDelete);
                if (save) { await Save(); }
            }

            public virtual async Task Update(TEntity entityToUpdate, bool save)
            {
                dbSet.Attach(entityToUpdate);
                context.Entry(entityToUpdate).State = EntityState.Modified;
                if (save) { await Save(); }
            }

            public async Task Insert<T>(IEnumerable<T> entities, bool save)
            {
                foreach (var entity in entities)
                {
                    context.Add(entity);
                }
                if (save) { await Save(); }
            }

            public async Task Update<T>(IEnumerable<T> entities, bool save)
            {
                foreach (var entity in entities)
                {
                    context.Update(entity);
                }
                if (save) { await Save(); }
            }

            public async Task Save()
            {
                await context.SaveChangesAsync();
            }
        }
    }
