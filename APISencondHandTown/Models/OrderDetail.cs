using System;
using System.Collections.Generic;

#nullable disable

namespace APISencondHandTown.Models
{
    public partial class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int Totalorderdetailprice { get; set; }
        public int Unitprice { get; set; }

        public virtual Product Product { get; set; }
    }
}
