using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SecondHandTowAPI.Models
{
    public partial class WareHouse
    {
        public string WareHouseId { get; set; }
        public DateTime ImportDate { get; set; }
        public DateTime ExportDate { get; set; }
        public string ProductId { get; set; }
        public int Amount { get; set; }
    }
}
