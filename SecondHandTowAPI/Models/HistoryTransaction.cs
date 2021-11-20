using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SecondHandTowAPI.Models
{
    public partial class HistoryTransaction
    {
        public int HistoryTransationId { get; set; }
        public int PaymentId { get; set; }
        public DateTime DateCreated { get; set; }
        public int OrderId { get; set; }

        public virtual Orders Order { get; set; }
        public virtual Payment Payment { get; set; }
    }
}
