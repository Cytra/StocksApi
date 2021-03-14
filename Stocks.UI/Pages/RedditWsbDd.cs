using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Stocks.Model.Portfolio;
using Stocks.Model.Reddit;
using Stocks.Model.Shared;
using Stocks.UI.Services;

namespace Stocks.UI.Pages
{
    public partial class RedditWsbDd
    {
        [Inject]
        public IRedditOtherProvider RedditOtherProvider { get; set; }
        public RedditDdDtoList RedditDdDtoList { get; set; }
        public List<RedditDdDto> RedditDdDtoListFiltered { get; set; }
        string currentSortField = "Created";
        string currentSortOrder = "Desc";

        protected override async Task OnInitializedAsync()
        {
            var response  = await RedditOtherProvider.GetDdList(new RedditOtherRequest()
            {
                DateFrom = DateTimeOffset.Now.AddDays(-1),
                DateTo = DateTimeOffset.Now,
                Page = 1,
                RowsPerPage = 10,
                Size = 1000
            });
            response.Items = response.Items.OrderByDescending(x => x.created_utc);
            RedditDdDtoList = response;
            GetItems(1);
        }

        private void Sort(string sortField)
        {
            if (sortField.Equals(currentSortField))
            {
                currentSortOrder = currentSortOrder.Equals("Asc") ? "Desc" : "Asc";
            }
            else
            {
                currentSortField = sortField;
                currentSortOrder = "Asc";
            }

            switch (currentSortField)
            {
                case "Created" when currentSortOrder == "Asc":
                    RedditDdDtoList.Items = RedditDdDtoList.Items.OrderBy(x => x.created_utc);break;
                case "Created" when currentSortOrder != "Asc":
                    RedditDdDtoList.Items = RedditDdDtoList.Items.OrderByDescending(x => x.created_utc); break;
                case "Score" when currentSortOrder == "Asc":
                    RedditDdDtoList.Items = RedditDdDtoList.Items.OrderBy(x => x.score);break;
                case "Score" when currentSortOrder != "Asc":
                    RedditDdDtoList.Items = RedditDdDtoList.Items.OrderByDescending(x => x.score); break;
            }
        }

        private void GetItems(int getPage)
        {
            RedditDdDtoListFiltered = RedditDdDtoList.Items
                .Skip(RedditDdDtoList.Paging.PageSize * (getPage - 1))
                .Take(RedditDdDtoList.Paging.PageSize).ToList();
        }
    }
}
