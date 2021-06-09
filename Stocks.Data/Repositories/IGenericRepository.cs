using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Stocks.Data.Entities;

namespace Stocks.Data.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : EntityBase
    {
        Task<List<TEntity>> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");

        Task<PagedListDb<TEntity>> GetPaged(int page, int rowsPerPage, Expression<Func<TEntity, bool>> filter = null);
        Task<TEntity> GetById(object id);
        Task Insert(TEntity entity, bool save);
        Task Delete(object id, bool save);
        Task Delete(TEntity entityToDelete, bool save);
        Task Update(TEntity entityToUpdate, bool save);
        Task Insert<T>(IEnumerable<T> entities, bool save);
        Task Update<T>(IEnumerable<T> entities, bool save);
    }
}
