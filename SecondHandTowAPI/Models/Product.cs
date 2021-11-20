using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SecondHandTowAPI.Models
{
    public partial class Product
    {
        public Product()
        {
            CartItem = new HashSet<CartItem>();
            Comment = new HashSet<Comment>();
            OrderDetail = new HashSet<OrderDetail>();
        }

        public string ProductId { get; set; }
        public int Price { get; set; }
        public int PriceSale { get; set; }
        public string ProductDetailsId { get; set; }
        public int Amount { get; set; }

        public virtual ICollection<CartItem> CartItem { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
