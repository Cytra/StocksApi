using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Stocks.Model.FMP.Index;

namespace Stocks.Core.Services.Index
{
    public interface ISPYconstituentService
    {
        Task<List<SPYconstituentModel>> GetSpyAddedHistory();
    }
}
