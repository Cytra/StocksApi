﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Stocks.Model.Portfolio;
using Stocks.Model.Shared;

namespace Stocks.Blazor.Pages
{
    public partial class Portfolio
    {
        [Inject]
        public IPortfolioProvider PortfolioProvider { get; set; }

        public List<PortfolioItem> PortfolioItems { get; set; }

        protected override async Task OnInitializedAsync()
        {
            PortfolioItems = await PortfolioProvider.AllPortfolio(false);
        }
    }
}
