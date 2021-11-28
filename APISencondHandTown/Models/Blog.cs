using System;
using System.Collections.Generic;

#nullable disable

namespace APISencondHandTown.Models
{
    public partial class Blog
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Descriptions { get; set; }
        public string Images { get; set; }
    }
}
