using System;
using System.Collections.Generic;

#nullable disable

namespace APISencondHandTown.Models
{
    public partial class ProductDetail
    {
        public int ProductDetailId { get; set; }
        public string SourceOrigin { get; set; }
        public string NameProduct { get; set; }
        public string Descriptions { get; set; }
    }
}
