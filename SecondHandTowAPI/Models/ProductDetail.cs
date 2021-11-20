using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SecondHandTowAPI.Models
{
    public partial class ProductDetail
    {
        public int ProductDetailId { get; set; }
        public string SourceOrigin { get; set; }
        public string NameProduct { get; set; }
        public string Descriptions { get; set; }
    }
}
