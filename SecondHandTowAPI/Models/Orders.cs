using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SecondHandTowAPI.Models
{
    public partial class Orders
    {
        public Orders()
        {
            HistoryTransaction = new HashSet<HistoryTransaction>();
            Payment = new HashSet<Payment>();
        }

        public int OrderId { get; set; }
        public string Addresss { get; set; }
        public int UserId { get; set; }
        public string ExpextedDelivery { get; set; }
        public string Shipfee { get; set; }
        public int Originalprice { get; set; }
        public int Totalpriceorder { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateDelivery { get; set; }

        public virtual Users User { get; set; }
        public virtual ICollection<HistoryTransaction> HistoryTransaction { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
    }
}
