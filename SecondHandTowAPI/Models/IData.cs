
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace SecondHandTowAPI.Models
{
    public interface IData
    {
        IDbTransaction ITransaction { get; set; }
        IDbConnection IConnection { get; set; }
        IDbCommand ICommand { get; set; }

        void AddParameter(Hashtable hstParameter);
        void AddParameter(string strParameterName, object objValue, Globals.DATATYPE enDataType);
        void AddParameter(string strParameterName, object objValue);
        void AddParameter(params object[] objArrParam);
        void BeginTransaction();
        void CommitTransaction();
        bool Connect();
        void CreateNewBuckCopy(string strTableName, DataTable table);
        void CreateNewSqlText(string strSQL);
        void CreateNewStoredProcedure(string strStoreProName, int intTimeOut);
        void CreateNewStoredProcedure(string strStoreProName);
        bool Disconnect();
        void Dispose();
        int ExecNonQuery();
        ArrayList ExecQueryToArrayList(string strSQL);
        byte[] ExecQueryToBinary(string strSQL);
        IDataAdapter ExecQueryToDataAdapter(string strSQL);
        IDataReader ExecQueryToDataReader(string strSQL);
        DataSet ExecQueryToDataSet(string strSQL);
        DataTable ExecQueryToDataTable(string strSQL);
        Hashtable ExecQueryToHashtable(string strSQL);
        string ExecQueryToString(string strSQL);
        ArrayList ExecStoreToArrayList(string strOutParameter);
        ArrayList ExecStoreToArrayList();
        byte[] ExecStoreToBinary();
        byte[] ExecStoreToBinary(string strOutParameter);
        IDataAdapter ExecStoreToDataAdapter();
        IDataAdapter ExecStoreToDataAdapter(string strOutParameter);
        IDataReader ExecStoreToDataReader(string strOutParameter);
        IDataReader ExecStoreToDataReader();
        DataSet ExecStoreToDataSet(params string[] strOutParameter);
        DataSet ExecStoreToDataSet();
        DataTable ExecStoreToDataTable();
        DataTable ExecStoreToDataTable(string strOutParameter);
        Hashtable ExecStoreToHashtable(string strOutParameter);
        Hashtable ExecStoreToHashtable();
        List<T> ExecStoreToListObject<T>() where T : new();
        List<T> ExecStoreToListObject<T>(string strOutParameter) where T : new();
        string ExecStoreToString(string strOutParameter);
        string ExecStoreToString();
        void ExecUpdate(string strSQL, params IDataParameter[] objParameters);
        void ExecUpdate(string strSQL, ArrayList arrParameters);
        void ExecUpdate(string strSQL);
        bool IsConnected();
        void RollBackTransaction();
    }
}