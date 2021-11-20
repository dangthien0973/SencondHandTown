using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SecondHandTowAPI.Models
{
    public partial class Users
    {
        public Users()
        {
            Cart = new HashSet<Cart>();
            Comment = new HashSet<Comment>();
            Orders = new HashSet<Orders>();
        }

        public string UserId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Passwords { get; set; }
        public DateTime DateCreated { get; set; }
        public int Roles { get; set; }
        public string Statuss { get; set; }

        public virtual ICollection<Cart> Cart { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
