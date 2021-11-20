using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SecondHandTowAPI.Models
{
    public partial class Payment
    {
        public Payment()
        {
            HistoryTransaction = new HashSet<HistoryTransaction>();
        }

        public string PaymentId { get; set; }
        public string TypePayment { get; set; }
        public DateTime DatePayment { get; set; }
        public string OrderId { get; set; }

        public virtual Orders Order { get; set; }
        public virtual ICollection<HistoryTransaction> HistoryTransaction { get; set; }
    }
}
