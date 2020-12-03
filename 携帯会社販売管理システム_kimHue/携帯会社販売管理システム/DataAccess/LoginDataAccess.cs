using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace 携帯会社販売管理システム
{
    public partial class LoginDataAccess
    {
        public DataTable Login(string userId, string password)
        {
			var dt = new DataTable();
			var dbConn = new DBConnection();
			var conn = dbConn.GetConnection();

			try
			{
				conn.Open();

				var sb = new StringBuilder();

				sb.AppendLine("SELECT *");
				sb.AppendLine("FROM  M_Employee");
				sb.AppendLine($"WHERE EmID ='{userId}'");
				sb.AppendLine($"AND   Passwork ='{password}'");


				SqlCommand command = dbConn.SetCommand(sb.ToString(), conn);
				SqlDataAdapter sqldDa = dbConn.Execute(command);
				sqldDa.Fill(dt);

				return dt;
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				conn.Close();
			}

        }
    }
}
