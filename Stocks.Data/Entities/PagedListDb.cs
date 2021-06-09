using System;
using System.Collections.Generic;
using System.Text;

namespace Stocks.Data.Entities
{
    public class PagedListDb<T>
    {
        public IEnumerable<T> Items { get; set; }
        public PagingModelDb Paging { get; set; }
    }

    public class PagingModelDb
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages => (TotalItems + PageSize - 1) / PageSize;
    }
}
