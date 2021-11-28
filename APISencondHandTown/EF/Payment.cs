using System;
using System.Collections.Generic;

#nullable disable

namespace APISencondHandTown.Models
{
    public partial class Payment
    {
        public Payment()
        {
            HistoryTransactions = new HashSet<HistoryTransaction>();
        }

        public int PaymentId { get; set; }
        public string TypePayment { get; set; }
        public DateTime DatePayment { get; set; }
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }
        public virtual ICollection<HistoryTransaction> HistoryTransactions { get; set; }
    }
}
