using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 携帯会社販売管理システム
{
    /// <summary>
    /// Class chuyen xu ly cac nhiem vu ket noi Database cua WareHousing
    /// </summary>
    public partial class WareHousingDataAccess
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="whsCdFrom"></param>
        /// <param name="whsCdTo"></param>
        /// <param name="goodsName"></param>
        /// <param name="goodsCdFrom"></param>
        /// <param name="goodsCdTo"></param>
        /// <param name="dtFrom"></param>
        /// <param name="dtTo"></param>
        /// <param name="userCode"></param>
        /// <returns></returns>
        public DataTable GetWareHousingInfo(string whsCdFrom,   // 
                                            string whsCdTo,     // 
                                            string goodsName,   // 
                                            string goodsCdFrom, // 
                                            string goodsCdTo,   // 
                                            string dtFrom,      // 
                                            string dtTo,        // 
                                            string userCode)    // 
        {

            var dt = new DataTable();
            var dbConn = new DBConnection();
            var conn = dbConn.GetConnection();

            try
            {
                conn.Open();
                //TODO: viet SQL
                var query = this.CreateSelectQuery( whsCdFrom,
                                                    whsCdTo,
                                                    goodsName,
                                                    goodsCdFrom,
                                                    goodsCdTo, 
                                                    dtFrom,
                                                    dtTo,
                                                    userCode);

                SqlCommand cmd = dbConn.SetCommand(query, conn);
                SqlDataAdapter sqldDa = dbConn.Execute(cmd);
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

        private String CreateSelectQuery(string whsCdFrom,      // 
                                            string whsCdTo,     // 
                                            string goodsName,   // 
                                            string goodsCdFrom, // 
                                            string goodsCdTo,   // 
                                            string dtFrom,      // 
                                            string dtTo,        // 
                                            string userCode)    // 
        {
            var sb = new StringBuilder();
            //TODO: Viet SQL
            sb.AppendLine("SELECT");
            sb.AppendLine("FROM");
            sb.AppendLine("WHERE");


            return sb.ToString();
        }

    }
    ytftyufythgvhjhjv

}
