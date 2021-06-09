using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stocks.Data.Entities
{
    public class ShortSqueezeNotifications : EntityBase
    {
        [StringLength(10)]
        public string Symbol { get; set; }
        [Column(TypeName = "decimal(15,2)")]
        public decimal Limit { get; set; }
    }
}
