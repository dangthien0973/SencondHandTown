using System;
using System.Collections.Generic;

#nullable disable

namespace APISencondHandTown.Models
{
    public partial class WareHouse
    {
        public int WareHouseId { get; set; }
        public DateTime ImportDate { get; set; }
        public DateTime ExportDate { get; set; }
        public string ProductId { get; set; }
        public int Amount { get; set; }
    }
}
