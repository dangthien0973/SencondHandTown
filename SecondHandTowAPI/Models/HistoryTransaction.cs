using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SecondHandTowAPI.Models
{
    public partial class HistoryTransaction
    {
        public string HistoryTransationId { get; set; }
        public string PaymentId { get; set; }
        public DateTime DateCreated { get; set; }
        public string OrderId { get; set; }

        public virtual Orders Order { get; set; }
        public virtual Payment Payment { get; set; }
    }
}
