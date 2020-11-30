using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Stocks.Model.Profile;

namespace Stocks.Core.Services.Profile
{
    public interface IProfileService
    {
        Task<List<StockProfile>> GetStockProfile(string symbol);
    }
}
