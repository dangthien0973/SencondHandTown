
#region Using
using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

using System.Configuration;
#endregion
namespace SecondHandTowAPI.Models

{
    [Serializable]
    public class Test
    {
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                // Dispose of resources held by this instance.
                // (This process is not shown here.)

                // Set the sentinel.
                disposed = true;

                // Suppress finalization of this disposed instance.
                if (disposing)
                {
                    GC.SuppressFinalize(this);
                }
            }
        }
        public void Dispose()
        {
            Dispose(true);
        }
        ~Test()
        {
            Dispose(false);
        }
        #region Generation Code

        #region Member Variables
        public IData objDataAccess = null;
        public int UserId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Passwords { get; set; }
        public DateTime DateCreated { get; set; }
        public int Roles { get; set; }
        public string Statuss { get; set; }


        #endregion

        #region Constructor
        /// <summary>
        /// Constructor with no parameter
        /// </summary>
        public Test()
        {
        }

        #endregion

        #region Methods
        ///<summary>
        /// Load Data for object by primary keys of CRM_REVIEWSTORE table
        ///</summary>
        /// <returns>true : Có ; False : Không</returns>

        ///<summary>
        /// Insert : CRM_REVIEWSTORE
        /// Add new Data in table
        ///</summary>
        public long Insert()
        {
            IData objData;
            if (objDataAccess == null)
                objData = Data.CreateData(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString, false);
            else
                objData = objDataAccess;
            long objTemp = 0;
            try
            {
                if (objData.IsConnected() == false)
                    objData.Connect();
                objData.CreateNewStoredProcedure("CRM_SO_FEE_INSERT");
                objData.AddParameter("i_SALEORDERONLINEID", this.SALEORDERONLINEID);
                objData.AddParameter("i_FEETYPEID", this.FEETYPEID);
                objData.AddParameter("i_ISADDEDTOTOTAL", this.ISADDEDTOTOTAL);
                objData.AddParameter("i_ISTOTALADVANCE", this.ISTOTALADVANCE);
                objData.AddParameter("i_FEEMONEY", this.FEEMONEY);
                objData.AddParameter("i_NOTE", this.NOTE);
                objData.AddParameter("i_ORIGINALSALEORDERONLINEID", this.ORIGINALSALEORDERONLINEID);
                objData.AddParameter("i_CREATEDDATE", this.CREATEDDATE);
                objData.AddParameter("i_CREATEDUSER", this.CREATEDUSER);
                objData.AddParameter("i_ISDELETED", this.ISDELETED);
                objData.AddParameter("i_UPDATECOMPUTERIP", this.UPDATECOMPUTERIP);
                objData.AddParameter("i_UPDATECOMPUTERNAME", this.UPDATECOMPUTERNAME);
                objData.AddParameter("i_UPDATECOMPUTERUSER", this.UPDATECOMPUTERUSER);
                objData.AddParameter("i_OUTGROUPID", this.OUTGROUPID);

                objTemp = long.Parse(objData.ExecStoreToString("o_Result"));
            }
            catch (Exception objEx)
            {
                throw objEx;
            }
            finally
            {
                if (objDataAccess == null)
                    objData.Disconnect();
            }
            return objTemp;
        }

        public long Update()
        {
            IData objData;
            if (objDataAccess == null)
                objData = Data.CreateData(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString, false);
            else
                objData = objDataAccess;
            long objTemp = 0;
            try
            {
                if (objData.IsConnected() == false)
                    objData.Connect();
                objData.CreateNewStoredProcedure("CRM_SO_FEE_UPDATE");
                objData.AddParameter("I_FEEID", this.FEEID);
                objData.AddParameter("i_SALEORDERONLINEID", this.SALEORDERONLINEID);
                objData.AddParameter("i_FEETYPEID", this.FEETYPEID);
                objData.AddParameter("i_ISADDEDTOTOTAL", this.ISADDEDTOTOTAL);
                objData.AddParameter("i_ISTOTALADVANCE", this.ISTOTALADVANCE);
                objData.AddParameter("i_FEEMONEY", this.FEEMONEY);
                objData.AddParameter("i_NOTE", this.NOTE);
                objData.AddParameter("i_ORIGINALSALEORDERONLINEID", this.ORIGINALSALEORDERONLINEID);
                objData.AddParameter("i_UPDATEDDATE", this.UPDATEDDATE);
                objData.AddParameter("i_UPDATEDUSER", this.UPDATEDUSER);
                objData.AddParameter("i_UPDATECOMPUTERIP", this.UPDATECOMPUTERIP);
                objData.AddParameter("i_UPDATECOMPUTERNAME", this.UPDATECOMPUTERNAME);
                objData.AddParameter("i_UPDATECOMPUTERUSER", this.UPDATECOMPUTERUSER);
                objData.AddParameter("i_OUTGROUPID", this.OUTGROUPID);

                objTemp = long.Parse(objData.ExecStoreToString("o_Result"));
            }
            catch (Exception objEx)
            {
                throw objEx;
            }
            finally
            {
                if (objDataAccess == null)
                    objData.Disconnect();
            }
            return objTemp;
        }

        public int Delete()
        {

            IData objData;
            if (objDataAccess == null)
                objData = Data.CreateData(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString, false);
            else
                objData = objDataAccess;
            int intTemp = 0;
            try
            {
                if (objData.IsConnected() == false)
                    objData.Connect();
                objData.CreateNewStoredProcedure("CRM_SO_FEE_DEL");
                objData.AddParameter("i_SALEORDERONLINEID", this.SALEORDERONLINEID);
                objData.AddParameter("I_DELETEDUSER", this.DELETEDUSER);
                intTemp = int.Parse(objData.ExecStoreToString("o_Result"));
            }
            catch (Exception objEx)
            {
                throw new Exception("Delete() Error   " + objEx.Message.ToString());
            }
            finally
            {
                if (objDataAccess == null)
                    objData.Disconnect();
            }
            return intTemp;
        }

        public int DeleteCRM_SO_FEE_ByID(int FeeID)
        {

            IData objData;
            if (objDataAccess == null)
                objData = Data.CreateData(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString, false);
            else
                objData = objDataAccess;
            int intTemp = 0;
            try
            {
                if (objData.IsConnected() == false)
                    objData.Connect();
                objData.CreateNewStoredProcedure("CRM_SO_FEE_DELBYID");
                objData.AddParameter("i_FEEID", FeeID);
                objData.AddParameter("I_DELETEDUSER", this.DELETEDUSER);
                intTemp = int.Parse(objData.ExecStoreToString("o_Result"));
            }
            catch (Exception objEx)
            {
                throw new Exception("Delete() Error   " + objEx.Message.ToString());
            }
            finally
            {
                if (objDataAccess == null)
                    objData.Disconnect();
            }
            return intTemp;
        }


        public DataTable GetCrmSOFee_SaleorderOnline(long saleorderonline)
        {
            DataTable kq = new DataTable();
            IData objData;
            if (objDataAccess == null)
                objData = Data.CreateData(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString, false);
            else
                objData = objDataAccess;
            try
            {
                if (objData.IsConnected() == false)
                    objData.Connect();
                objData.CreateNewStoredProcedure("CRM_SO_FEE_GETBYORDER");
                objData.AddParameter("i_SALEORDERONLINEID", saleorderonline);
                kq = objData.ExecStoreToDataTable("o_RESULT");
            }
            catch (Exception objEx)
            {
                throw objEx;
            }
            finally
            {
                if (objDataAccess == null)
                    objData.Disconnect();
            }
            return kq;
        }

        #endregion

        /// <summary>
        /// Check Data IsDBNull 
        /// </summary>
        /// <param name="objObject"> Object Value</param>
        /// <returns>Null : true ? false </returns>
        private bool IsDBNull(object objObject)
        {
            return Convert.IsDBNull(objObject);
        }

        #endregion Generation Code
        //pm_saleorder_deposit_getlst
        public DataTable GetTimeToPayDeposit_BylstSO(string lstSO)
        {
            DataTable kq = new DataTable();
            IData objData;
            if (objDataAccess == null)
                objData = Data.CreateData(ConfigurationManager.ConnectionStrings["ConnectionToERP"].ConnectionString, false);
            else
                objData = objDataAccess;
            try
            {
                if (objData.IsConnected() == false)
                    objData.Connect();
                objData.CreateNewStoredProcedure("pm_saleorder_deposit_getlst");
                objData.AddParameter("I_LSTSALEORDERID", lstSO);
                kq = objData.ExecStoreToDataTable("O_RESULT");
            }
            catch (Exception objEx)
            {
                throw objEx;
            }
            finally
            {
                if (objDataAccess == null)
                    objData.Disconnect();
            }
            return kq;
        }
    }
}