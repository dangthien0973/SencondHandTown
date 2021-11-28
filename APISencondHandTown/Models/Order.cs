using System;
using System.Collections.Generic;

#nullable disable

namespace APISencondHandTown.Models
{
    public partial class Order
    {
        public Order()
        {
            HistoryTransactions = new HashSet<HistoryTransaction>();
            Payments = new HashSet<Payment>();
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

        public virtual User User { get; set; }
        public virtual ICollection<HistoryTransaction> HistoryTransactions { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
