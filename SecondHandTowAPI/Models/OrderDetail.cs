using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SecondHandTowAPI.Models
{
    public partial class OrderDetail
    {
        public string OrderDetailId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public int Totalorderdetailprice { get; set; }
        public int Unitprice { get; set; }

        public virtual Product Product { get; set; }
    }
}
