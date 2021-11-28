using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISencondHandTown.Models
{
    public class UserModel
    {
        private string userName = string.Empty;
        private string passwords = string.Empty;
        public UserModel()
        {

        }
        public string UserName { get => userName; set => userName = value; }
        public string Passwords { get => passwords; set => passwords = value; }

        public List<UserModel> GetListUser()
        {
            try
            {
               List<UserModel> lst = new List<UserModel>();

                return lst;
            }
            catch
            {
                throw;
            }

        }
    }
}
