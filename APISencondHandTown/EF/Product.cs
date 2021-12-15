using System;
using System.Collections.Generic;

#nullable disable

namespace APISencondHandTown.Models
{
    public partial class Product
    {
        public Product()
        {
            CartItems = new HashSet<CartItem>();
            Comments = new HashSet<Comment>();
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int PriceSale { get; set; }
        public int ProductDetailsId { get; set; }
        public int Amount { get; set; }

        public virtual ICollection<CartItem> CartItems { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
