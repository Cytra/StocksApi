using Stocks.Model.Requests;
using System.Threading.Tasks;

namespace Stocks.Core.Providers
{
    public interface IDcfProvider
    {
        Task UpdateDCFs(DCFRequest request);
    }
}
