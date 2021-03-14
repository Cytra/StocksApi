using System.Threading.Tasks;
using Stocks.Model.Reddit;

namespace Stocks.Model.Shared
{
    public interface IRedditOtherProvider
    {
        Task<RedditDdDtoList> GetDdList(RedditOtherRequest request);
    }
}
