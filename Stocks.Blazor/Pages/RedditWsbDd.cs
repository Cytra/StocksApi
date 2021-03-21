using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Stocks.Model.Reddit;
using Stocks.Model.Shared;

namespace Stocks.Blazor.Pages
{
    public partial class RedditWsbDd
    {
        [Inject]
        public IRedditOtherProvider RedditOtherProvider { get; set; }
        public RedditDdDtoList RedditDdDtoList { get; set; }
        public List<RedditDdDto> RedditDdDtoListFiltered { get; set; }
        string currentSortField = "Created";
        string currentSortOrder = "Desc";

        string currentSortFieldAgg = "1W Posts";
        string currentSortOrderAgg = "Desc";
        public List<RedditDdDtoAggregated> RedditDdDtoAggregatedList { get; set; }

        public string Ticker { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var response  = await RedditOtherProvider.GetDdList(new RedditOtherRequest()
            {
                DateFrom = DateTimeOffset.Now.AddDays(-20),
                DateTo = DateTimeOffset.Now,
                Page = 1,
                RowsPerPage = 10,
                Size = 1000
            });
            response.Items = response.Items.OrderByDescending(x => x.created_utc);
            RedditDdDtoList = response;
            RedditDdDtoAggregatedList = response.Aggregated.OrderByDescending(x=> x.OneWeekPosts).ToList();
            GetItems(1);
        }

        private void SortAgg(string sortField)
        {
            if (sortField.Equals(currentSortFieldAgg))
            {
                currentSortOrderAgg = currentSortOrderAgg.Equals("Asc") ? "Desc" : "Asc";
            }
            else
            {
                currentSortFieldAgg = sortField;
                currentSortOrderAgg = "Asc";
            }

            switch (currentSortFieldAgg)
            {
                case "Ticker" when currentSortOrderAgg == "Asc":
                    RedditDdDtoAggregatedList = RedditDdDtoAggregatedList.OrderBy(x => x.Ticker).ToList();
                    break;
                case "Ticker" when currentSortOrderAgg != "Asc":
                    RedditDdDtoAggregatedList = RedditDdDtoAggregatedList.OrderByDescending(x => x.Ticker).ToList();
                    break;
                case "1W Posts" when currentSortOrderAgg == "Asc":
                    RedditDdDtoAggregatedList = RedditDdDtoAggregatedList.OrderBy(x => x.OneWeekPosts).ToList();
                    break;
                case "1W Posts" when currentSortOrderAgg != "Asc":
                    RedditDdDtoAggregatedList = RedditDdDtoAggregatedList.OrderByDescending(x => x.OneWeekPosts).ToList();
                    break;
                case "2W Posts" when currentSortOrderAgg == "Asc":
                    RedditDdDtoAggregatedList = RedditDdDtoAggregatedList.OrderBy(x => x.TwoWeekPosts).ToList();
                    break;
                case "2W Posts" when currentSortOrderAgg != "Asc":
                    RedditDdDtoAggregatedList = RedditDdDtoAggregatedList.OrderByDescending(x => x.TwoWeekPosts).ToList();
                    break;
                case "3W Posts" when currentSortOrderAgg == "Asc":
                    RedditDdDtoAggregatedList = RedditDdDtoAggregatedList.OrderBy(x => x.ThreeWeekPosts).ToList();
                    break;
                case "3W Posts" when currentSortOrderAgg != "Asc":
                    RedditDdDtoAggregatedList = RedditDdDtoAggregatedList.OrderByDescending(x => x.ThreeWeekPosts).ToList();
                    break;
                case "4W Posts" when currentSortOrderAgg == "Asc":
                    RedditDdDtoAggregatedList = RedditDdDtoAggregatedList.OrderBy(x => x.FourWeekPosts).ToList();
                    break;
                case "4W Posts" when currentSortOrderAgg != "Asc":
                    RedditDdDtoAggregatedList = RedditDdDtoAggregatedList.OrderByDescending(x => x.FourWeekPosts).ToList();
                    break;
                case "Day Perf" when currentSortOrderAgg == "Asc":
                    RedditDdDtoAggregatedList = RedditDdDtoAggregatedList.OrderBy(x => x.Prices.Day.Performance).ToList();
                    break;
                case "Day Perf" when currentSortOrderAgg != "Asc":
                    RedditDdDtoAggregatedList = RedditDdDtoAggregatedList.OrderByDescending(x => x.Prices.Day.Performance).ToList();
                    break;
                case "Week Perf" when currentSortOrderAgg == "Asc":
                    RedditDdDtoAggregatedList = RedditDdDtoAggregatedList.OrderBy(x => x.Prices.Week.Performance).ToList();
                    break;
                case "Week Perf" when currentSortOrderAgg != "Asc":
                    RedditDdDtoAggregatedList = RedditDdDtoAggregatedList.OrderByDescending(x => x.Prices.Week.Performance).ToList();
                    break;
                case "Month Perf" when currentSortOrderAgg == "Asc":
                    RedditDdDtoAggregatedList = RedditDdDtoAggregatedList.OrderBy(x => x.Prices.Month.Performance).ToList();
                    break;
                case "Month Perf" when currentSortOrderAgg != "Asc":
                    RedditDdDtoAggregatedList = RedditDdDtoAggregatedList.OrderByDescending(x => x.Prices.Month.Performance).ToList();
                    break;
                case "3Months Perf" when currentSortOrderAgg == "Asc":
                    RedditDdDtoAggregatedList = RedditDdDtoAggregatedList.OrderBy(x => x.Prices.ThreeMonths.Performance).ToList();
                    break;
                case "3Months Perf" when currentSortOrderAgg != "Asc":
                    RedditDdDtoAggregatedList = RedditDdDtoAggregatedList.OrderByDescending(x => x.Prices.ThreeMonths.Performance).ToList();
                    break;
            }
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
                case "Title" when currentSortOrder == "Asc":
                    RedditDdDtoList.Items = RedditDdDtoList.Items.OrderBy(x => x.title); break;
                case "Title" when currentSortOrder != "Asc":
                    RedditDdDtoList.Items = RedditDdDtoList.Items.OrderByDescending(x => x.title); break;
                case "Created" when currentSortOrder == "Asc":
                    RedditDdDtoList.Items = RedditDdDtoList.Items.OrderBy(x => x.created_utc);break;
                case "Created" when currentSortOrder != "Asc":
                    RedditDdDtoList.Items = RedditDdDtoList.Items.OrderByDescending(x => x.created_utc); break;
                case "Score" when currentSortOrder == "Asc":
                    RedditDdDtoList.Items = RedditDdDtoList.Items.OrderBy(x => x.score);break;
                case "Score" when currentSortOrder != "Asc":
                    RedditDdDtoList.Items = RedditDdDtoList.Items.OrderByDescending(x => x.score); break;
                case "Ticker" when currentSortOrder == "Asc":
                    RedditDdDtoList.Items = RedditDdDtoList.Items.OrderBy(x => x.Ticker); break;
                case "Ticker" when currentSortOrder != "Asc":
                    RedditDdDtoList.Items = RedditDdDtoList.Items.OrderByDescending(x => x.Ticker); break;
                case "Day" when currentSortOrder == "Asc":
                    RedditDdDtoList.Items = RedditDdDtoList.Items.OrderBy(x => x.Prices.Day.Performance); break;
                case "Day" when currentSortOrder != "Asc":
                    RedditDdDtoList.Items = RedditDdDtoList.Items.OrderByDescending(x => x.Prices.Day.Performance); break;
                case "Week" when currentSortOrder == "Asc":
                    RedditDdDtoList.Items = RedditDdDtoList.Items.OrderBy(x => x.Prices.Week.Performance); break;
                case "Week" when currentSortOrder != "Asc":
                    RedditDdDtoList.Items = RedditDdDtoList.Items.OrderByDescending(x => x.Prices.Week.Performance); break;
                case "Month" when currentSortOrder == "Asc":
                    RedditDdDtoList.Items = RedditDdDtoList.Items.OrderBy(x => x.Prices.Month.Performance); break;
                case "Month" when currentSortOrder != "Asc":
                    RedditDdDtoList.Items = RedditDdDtoList.Items.OrderByDescending(x => x.Prices.Month.Performance); break;
                case "3Months" when currentSortOrder == "Asc":
                    RedditDdDtoList.Items = RedditDdDtoList.Items.OrderBy(x => x.Prices.ThreeMonths.Performance); break;
                case "3Months" when currentSortOrder != "Asc":
                    RedditDdDtoList.Items = RedditDdDtoList.Items.OrderByDescending(x => x.Prices.ThreeMonths.Performance); break;
            }

            GetItems(RedditDdDtoList.Paging.Page);
            StateHasChanged();
        }

        private void GetItems(int getPage)
        {
            RedditDdDtoList.Paging.Page = getPage;
            var query = RedditDdDtoList.Items;
            if (!string.IsNullOrWhiteSpace(Ticker))
            {
                query = query.Where(x => x.Ticker == Ticker);
            }
            RedditDdDtoListFiltered = query
                .Skip(RedditDdDtoList.Paging.PageSize * (getPage - 1))
                .Take(RedditDdDtoList.Paging.PageSize).ToList();
            StateHasChanged();
        }

        private void FilterStocks()
        {
            GetItems(1);
        }
    }
}
