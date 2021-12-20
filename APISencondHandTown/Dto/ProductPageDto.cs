using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISencondHandTown.Dto
{
  
    public class ProductPageDto
    {

        public int Page { get; set; }
        public int PageSize { get; set; }
        public String filedName { get; set; }
        public String sortType { get; set; }




    }
   
}
