using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SecondHandTowAPI.Models
{
    public class User
    {
        #region  bien
        private int intUserId = 0;
        private string strAddress = String.Empty;
        private string strPhone = String.Empty;
        private string strEmail = String.Empty;
        private string strUserName= String.Empty;
        private string strPasswords = String.Empty;
        private DateTime DateCreated = DateTime.MinValue;
        private int intRoles = 0;
        private string strStatuss = String.Empty;


        #endregion
        public User()
        {

        }
        #region thuoc tinh cho ae
        public int UserId { get => intUserId; set => intUserId = value; }
        public string Address { get => strAddress; set => strAddress = value; }
        public string Phone { get => strPhone; set => strPhone = value; }
        public string Email { get => strEmail; set => strEmail = value; }
        public string UserName { get => strUserName; set => strUserName = value; }
        public string Passwords { get => strPasswords; set => strPasswords = value; }
        public DateTime Created1 { get => DateCreated; set => DateCreated = value; }
        public int Roles { get => intRoles; set => intRoles = value; }
        public string Statuss { get => strStatuss; set => strStatuss = value; }
        #endregion
        #region them xoa sua
    
        public List<User> GetAllUser()
        {
            List<User> result = new List<User>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.
                                               ConnectionStrings["myConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("GetAll_User", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // func nay dung cho ae tao store de them bien vao la dc nha
                    //cmd.Parameters.Add("@CategoryID", SqlDbType.BigInt, 10).Value = CategoryID;
                    conn.Open();

                    using (SqlDataReader dreader = cmd.ExecuteReader())
                    {
                        while (dreader.Read())
                        {
                            User workItem = new User()
                            {
                                UserId = dreader.GetInt32(0),
                                Address = dreader.GetString(1),
                                Phone = dreader.GetString(2),
                                Email = dreader.GetString(3),
                                UserName = dreader.GetString(4),
                                Passwords = dreader.GetString(5),
                                DateCreated = dreader.GetDateTime(6),
                                Roles = dreader.GetInt32(7),
                                Statuss = dreader.GetString(8),

                            };
                            result.Add(workItem);
                        }
                        dreader.Close();
                    }

                    conn.Close();
                }
            }
            return result;
        }
        public string InsertUser()
        {
            String message = "";

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.
                                               ConnectionStrings["myConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Insert_User", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // func nay dung cho ae tao store de them bien vao la dc nha
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = this.UserName;
                    cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = this.Address;
                    cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = this.Address;
                    cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = this.Email;
                    cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = this.Statuss;
                    
                    conn.Open();

                    Int64 k = cmd.ExecuteNonQuery();
                    if (k != 0)
                    {
                        message = "them thanh cong";
                    }
                    else
                    {
                        message = "them sai roi ne";
                    }

                        conn.Close();
                }
            }
            return message;


        }
        #endregion
    }
}