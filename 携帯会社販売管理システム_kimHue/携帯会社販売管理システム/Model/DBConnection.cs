using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 携帯会社販売管理システム
{
    public class DBConnection
    {
        //FIXME: Can 
        private const string connectionStr = @"Data Source = (localdb)\ProjectsV13;" +
                                             "Initial Catalog = Inventory_Control; " +
                                             "Integrated Security = True";

        //public SqlConnection con = new SqlConnection();

        public SqlConnection GetConnection()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionStr);

                return conn;
            }
            catch (Exception ex)
            {
                //TODO: write log
                throw ex;
            }
            
        }

        public SqlCommand SetCommand(string cmdStr, SqlConnection conn)
        {
            SqlCommand command = new SqlCommand(cmdStr,conn);
            

            return command;
        }

        public SqlDataAdapter Execute(SqlCommand command)
        {
            SqlDataAdapter execute = new SqlDataAdapter(command);


            return execute;
        }

        //public void OpenConnection()
        //{
        //    con.Open();
        //}
        //public void CloseConnection()
        //{
        //    con.Close();
        //}

    }
}
