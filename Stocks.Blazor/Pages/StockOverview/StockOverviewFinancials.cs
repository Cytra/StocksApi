﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Stocks.Model.CompanyOutlook;

namespace Stocks.Blazor.Pages.StockOverview
{
    public partial class StockOverviewFinancials
    {
        [Parameter]
        public string StockTicker { get; set; }
        [Inject]
        public Model.Shared.IStockService IuiStockService { get; set; }

        public CompanyOutlookModel CompanyOutlook { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var companyOutlookModel = await IuiStockService.GetCompanyOutlook(StockTicker);
            if (companyOutlookModel != null)
            {
                companyOutlookModel.financialsAnnual.income = companyOutlookModel.financialsAnnual.income.OrderBy(x => DateTime.Parse(x.date)).ToArray();
                companyOutlookModel.stockDividend = companyOutlookModel.stockDividend.OrderBy(x => DateTime.Parse(x.date)).ToArray();
                companyOutlookModel.financialsAnnual.cash = companyOutlookModel.financialsAnnual.cash.OrderBy(x => DateTime.Parse(x.date)).ToArray();
                companyOutlookModel.financialsAnnual.balance = companyOutlookModel.financialsAnnual.balance.OrderBy(x => DateTime.Parse(x.date)).ToArray();
                CompanyOutlook = companyOutlookModel;
            }
        }
    }
}
