using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISencondHandTown.Data
{
    public class MydbContext :DbContext
    {
        public MydbContext(DbContextOptions options) : base(options) { }
       


    }
}
