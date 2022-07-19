﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Stocks.Model.FMP.FinancialStatements;

namespace Stocks.Core.Services.FinancialStatements
{
    public interface IIncomeStatementService
    {
        Task<List<IncomeStatement>> GetIncomeStatements(string symbol);
    }
}
