using System;
using System.Collections.Generic;
using System.Text;

namespace Stocks.Model
{
    public class ListModelBase<T>
    {
        /// <summary>
        ///     Items
        /// </summary>
        public IEnumerable<T> Items { get; set; }

        /// <summary>
        ///     Paging information
        /// </summary>
        public PagingModel Paging { get; set; }
    }

    public class PagingModel
    {
        //public PagingModel(FilterBase filter, int totalItems)
        //{
        //    Page = filter.Page;
        //    PageSize = filter.RowsPerPage;
        //    TotalItems = totalItems;
        //}

        //public PagingModel(UtcFilterBase filter, int totalItems)
        //{
        //    Page = filter.Page;
        //    PageSize = filter.RowsPerPage;
        //    TotalItems = totalItems;
        //}

        /// <summary>
        ///     Page
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        ///     Page size
        /// </summary>
        public int PageSize { get; set; }


        /// <summary>
        ///     Total items
        /// </summary>
        public int TotalItems { get; set; }

        /// <summary>
        ///     Total Pages
        /// </summary>
        public int TotalPages => (TotalItems + PageSize - 1) / PageSize;
    }
}
