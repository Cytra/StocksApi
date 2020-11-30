using System.Collections.Generic;
using System.Threading.Tasks;
using Stocks.Model.Index;

namespace Stocks.Core.Providers
{
    public interface ISPYconstituentProvider
    {
        Task<List<SPYconstituentModel>> GetSpyHistory();
    }
}
