using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Stocks.Data.Entities.Index
{
    public class SPYconstituentEntity : EntityBase
    {
        public SPYconstituentEntity()
        {
            Created = DateTimeOffset.Now;
        }
        [StringLength(50)]
        public string DateAdded { get; set; }
        [StringLength(50)]
        public string AddedSecurity { get; set; }
        [StringLength(50)]
        public string RemovedTicker { get; set; }
        [StringLength(50)]
        public string RemovedSecurity { get; set; }
        public DateTime Date { get; set; }
        [StringLength(200)]
        public string Reason { get; set; }
        [StringLength(10)]
        public string Symbol { get; set; }
    }
}
