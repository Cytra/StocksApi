using System.Threading.Tasks;
using Stocks.Model.Strategy;

namespace Stocks.Core.Strategies
{
    public interface IDcfStrategy
    {
        Task Get(StrategyRequest request);
    }
}
