using Microsoft.AspNetCore.Components;

namespace Stocks.UI.Shared
{
    public partial class NavMenu
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public string Ticker { get; set; }

        protected void NavigateToStockOverview()
        {
            NavigationManager.NavigateTo($"/stockOverview/{Ticker}");
        }

    }
}
