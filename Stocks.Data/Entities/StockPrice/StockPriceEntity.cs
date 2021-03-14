using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stocks.Data.Entities.StockPrice
{
    public class StockPriceEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Symbol { get; set; }
        [Column(TypeName = "decimal(15,2)")]
        public decimal Price { get; set; }
        public string Volume { get; set; }
    }
}
