﻿using Stocks.Data.Entities.DCF;
using System.Collections.Generic;
using System.Threading.Tasks;
using Stocks.Data.Entities.Dividend;

namespace Stocks.Data.Repositories
{
    public interface IStocksRepository
    {
        Task SaveDCFs(List<Historical_discounted_cash_flow_Entity> dcfs);
        Task DeleteDCF(string stock);
        Task SaveDividendCalendarEntities(List<DividendCalendarEntity> input);
        Task DeleteAllDividendCalendarEntities();
        Task SaveDividendCalendarEntity(DividendCalendarEntity input);
    }
}
