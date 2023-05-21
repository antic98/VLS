using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBroker
{
    public class Broker
    {
        #region BROKER
        private SqlConnection connection;
        private SqlTransaction transaction;
        
        public Broker()
        {
            connection = new SqlConnection(
                @"Data Source=LAPTOP-H6KF26FM;
                Initial Catalog=VLS;
                Integrated Security=True;
                Connect Timeout=30;
                Encrypt=False;
                TrustServerCertificate=False;
                ApplicationIntent=ReadWrite;
                MultiSubnetFailover=False");
        }
        public void OpenConnection()
        {
            connection?.Open();
        }
        public void CloseConnection()
        {
            if(connection != null
                && connection.State != ConnectionState.Closed)
                connection.Close();
        }               
        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();
        }              
        public void Commit()
        {
            transaction.Commit();
        }
        public void Rollback()

        {
            transaction.Rollback();
        }
        public SqlCommand CreateCommand()
        {
            return new SqlCommand("", connection, transaction);
        }

        #endregion
    }
}
