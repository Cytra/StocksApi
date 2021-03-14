using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;
using Stocks.Model.Converters;

namespace Stocks.Model
{
    public class UtcFilterBase
    {
        public DateTimeOffset DateFrom { get; set; }
        public DateTimeOffset DateTo { get; set; }

        /// <summary>
        ///     Page
        /// </summary>
        [Range(1, int.MaxValue)]
        public int Page { get; set; }

        /// <summary>
        ///     Rows per page
        /// </summary>
        [Range(1, 100)]
        public int RowsPerPage { get; set; }
    }

    public class FilterBase
    {
        [JsonConverter(typeof(ShortDateConverter))]
        public DateTime? DateFrom { get; set; }

        [JsonConverter(typeof(ShortDateConverter))]
        public DateTime? DateTo { get; set; }

        /// <summary>
        ///     Page
        /// </summary>
        [Range(1, int.MaxValue)]
        public int Page { get; set; }

        /// <summary>
        ///     Rows per page
        /// </summary>
        [Range(1, 100)]
        public int RowsPerPage { get; set; }
    }
}
