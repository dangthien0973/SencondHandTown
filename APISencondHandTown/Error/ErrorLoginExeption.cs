using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISencondHandTown.Error
{

    public class ErrorLoginExeption : Exception
    {
        const string erroMessage = "";
        public ErrorLoginExeption() : base(erroMessage)
        {
        }
    }

}
