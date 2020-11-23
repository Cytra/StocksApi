using System.Threading.Tasks;
using Stocks.Model.DCF;

namespace Stocks.Core.Providers
{
    public interface IDcfProvider
    {
        Task UpdateDCFs(DCFRequest request);
    }
}
