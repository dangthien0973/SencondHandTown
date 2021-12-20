using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISencondHandTown.Dto
{
    public class UserModelDto
    {
        private string userName = string.Empty;
        private string passwords = string.Empty;
        public UserModelDto()
        {

        }
        public string UserName { get => userName; set => userName = value; }
        public string Passwords { get => passwords; set => passwords = value; }

        public List<UserModelDto> GetListUser()
        {
            try
            {
               List<UserModelDto> lst = new List<UserModelDto>();

                return lst;
            }
            catch
            {
                throw;
            }

        }
    }
}
