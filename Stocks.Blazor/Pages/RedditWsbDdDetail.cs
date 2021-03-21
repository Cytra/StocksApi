using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Stocks.Model.Reddit;
using Stocks.Model.Shared;

namespace Stocks.Blazor.Pages
{
    public partial class RedditWsbDdDetail
    {
        [Parameter]
        public string Id { get; set; }

        public RedditDdDto RedditDdDto { get; set; }
        [Inject]
        public IRedditOtherProvider RedditOtherProvider { get; set; }

        protected override async Task OnInitializedAsync()
        {
            RedditDdDto = await RedditOtherProvider.GetDbItem(int.Parse(Id));
        }
    }
}
