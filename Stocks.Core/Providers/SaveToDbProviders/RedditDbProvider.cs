using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Stocks.Core.Services.Reddit;
using Stocks.Data.Entities.Reddit;
using Stocks.Data.Repositories;
using Stocks.Model.Reddit;

namespace Stocks.Core.Providers.SaveToDbProviders
{
    public interface IRedditDBProvider
    {
        Task GetDdList(RedditDbRequest request);
    }

    public class RedditDbProvider : IRedditDBProvider
    {
        private readonly IRedditService _redditService;
        private readonly IMapper _mapper;
        private readonly IStocksRepository _repo;
        public RedditDbProvider(IRedditService redditService, IMapper mapper, IStocksRepository repo)
        {
            _redditService = redditService;
            _mapper = mapper;
            _repo = repo;
        }

        public async Task GetDdList(RedditDbRequest request)
        {
            var response = await _redditService.GetLatestDd(request);
            var children = response.data.children.Select(x => x.data).ToList();
            var ddEntities = _mapper.Map<List<RedditDdEntity>>(children);
            var minDate = children.Select(x => x.created_utc).Min();
            await _repo.SaveRedditDdEntities(ddEntities, minDate);
        }
    }
}
