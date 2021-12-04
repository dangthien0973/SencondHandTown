using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISencondHandTown.Models
{
  
    public class RegisterUser
    {
        #region  bien
      
        private string strAddress = String.Empty;
        private string strPhone = String.Empty;
        private string strEmail = String.Empty;
        private string strUserName = String.Empty;
        private string strPasswords = String.Empty;
        private DateTime DateCreated = DateTime.MinValue;
        private int intRoles = 0;
        private string strStatuss = String.Empty;
        #endregion
        public RegisterUser()
        {

        }
        #region thuoc tinh cho ae
      
        public string Address { get => strAddress; set => strAddress = value; }
        public string Phone { get => strPhone; set => strPhone = value; }
        public string Email { get => strEmail; set => strEmail = value; }
        public string UserName { get => strUserName; set => strUserName = value; }
        public string Passwords { get => strPasswords; set => strPasswords = value; }
        public DateTime Created1 { get => DateCreated; set => DateCreated = value; }
        public int Roles { get => intRoles; set => intRoles = value; }
        public string Statuss { get => strStatuss; set => strStatuss = value; }
        #endregion

       

    }
   
}
