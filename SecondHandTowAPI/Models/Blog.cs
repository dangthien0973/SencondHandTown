using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SecondHandTowAPI.Models
{
    public partial class Blog
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Descriptions { get; set; }
        public string Images { get; set; }
    }
}
