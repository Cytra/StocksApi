﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stocks.Data.Entities.Profile
{
    public class StockProfileEntity : EntityBase
    {
        public StockProfileEntity()
        {
            Created = DateTimeOffset.Now;
        }

        public string Symbol { get; set; }
        [Column(TypeName = "decimal(15,2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(15,2)")]
        public decimal? Beta { get; set; }
        public Int64? VolAvg { get; set; }
        public Int64? MktCap { get; set; }
        [Column(TypeName = "decimal(15,2)")]
        public decimal? LastDiv { get; set; }
        public string Range { get; set; }
        [Column(TypeName = "decimal(15,2)")]
        public decimal? Changes { get; set; }
        public string CompanyName { get; set; }
        public string Currency { get; set; }
        public string Cik { get; set; }
        public string Isin { get; set; }
        public string Cusip { get; set; }
        public string Exchange { get; set; }
        public string ExchangeShortName { get; set; }
        public string Industry { get; set; }
        public string Website { get; set; }
        public string Description { get; set; }
        public string Ceo { get; set; }
        public string Sector { get; set; }
        public string Country { get; set; }
        public Int64? FullTimeEmployees { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        [Column(TypeName = "decimal(15,2)")]
        public decimal? DcfDiff { get; set; }
        [Column(TypeName = "decimal(15,2)")]
        public decimal? Dcf { get; set; }
        public string Image { get; set; }
        public DateTime? IpoDate { get; set; }
        public bool? DefaultImage { get; set; }
    }
}
