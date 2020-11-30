﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Stocks.Model.FinancialStatements;

namespace Stocks.Core.Providers
{
    public interface IIncomeStatementProvider
    {
        Task<List<IncomeStatement>> GetIncomeStatements(string symbol);
    }
}
