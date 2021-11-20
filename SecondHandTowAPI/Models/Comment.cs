using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SecondHandTowAPI.Models
{
    public partial class Comment
    {
        public string CommentId { get; set; }
        public string UserId { get; set; }
        public string BodyComment { get; set; }
        public string ProductId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Users User { get; set; }
    }
}
