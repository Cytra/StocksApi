using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stocks.Model.Shared
{
    public interface IShortInterestProvider
    {
        Task<List<ShortInterest.ShortInterest>> GetShortInterestList();
    }
}
