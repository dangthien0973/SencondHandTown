using System;
using System.Collections.Generic;

#nullable disable

namespace APISencondHandTown.Models
{
    public partial class HistoryTransaction
    {
        public int HistoryTransationId { get; set; }
        public int PaymentId { get; set; }
        public DateTime DateCreated { get; set; }
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }
        public virtual Payment Payment { get; set; }
    }
}
