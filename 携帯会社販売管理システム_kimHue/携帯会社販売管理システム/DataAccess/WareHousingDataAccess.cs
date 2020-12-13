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
                                            string dtTo)
        {

            var dt = new DataTable();
            var dbConn = new DBConnection();
            var conn = dbConn.GetConnection();

            try
            {
                conn.Open();
                var select = this.CreateSelectQuery();

                var where = this.CreateWhereCondition(whsCdFrom, whsCdTo, goodsName, goodsCdFrom, goodsCdTo, dtFrom, dtTo);

                var query = String.Concat(select,where);
                
                SqlCommand cmd = dbConn.SetCommand(query.ToString(), conn);
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

        private string CreateSelectQuery()
        {
            var sb = new StringBuilder();
            
            sb.AppendLine("SELECT");
            sb.AppendLine("      WH.WaID");
            sb.AppendLine("    , WH.WaDate");
            sb.AppendLine("    , WHD.PrID");
            sb.AppendLine("    , MP.PrName");
            sb.AppendLine("    , WHD.WDquantity");
            sb.AppendLine("    , MP.Price");
            sb.AppendLine("    , MP.Mnumber");
            sb.AppendLine("    , MP.Color");
            sb.AppendLine("    , Cast((CAST(MP.Price as int) * CAST(WHD.WDquantity as int)) as char) AS TotalAmount");
            sb.AppendLine("FROM");
            sb.AppendLine("     T_Warehousing AS WH");
            sb.AppendLine("LEFT JOIN");
            sb.AppendLine("     T_WarehousingDetails AS WHD");
            sb.AppendLine("ON WH.WaID = WHD.WaID");
            sb.AppendLine("INNER JOIN");
            sb.AppendLine("     M_Product AS MP");
            sb.AppendLine("ON WHD.PrID = MP.PrId");


            return sb.ToString();
        }

        private string CreateWhereCondition(string whsCdFrom,
                                         string whsCdTo,
                                         string goodsName,
                                         string goodsCdFrom,
                                         string goodsCdTo,
                                         string dtFrom,
                                         string dtTo)
        {
            var sbWhere = new StringBuilder();
            sbWhere.AppendLine("WHERE");

            if (!string.IsNullOrEmpty(whsCdFrom)&& !string.IsNullOrEmpty(whsCdTo))
                
            {
                sbWhere.AppendLine($"    WH.WaID >= '{whsCdFrom}'");
                sbWhere.AppendLine($"AND    WH.WaID <= '{whsCdTo}'");
                sbWhere.AppendLine($"AND");
            }
            else
            {
                if (!string.IsNullOrEmpty(whsCdFrom))
                {
                    sbWhere.AppendLine($"    WH.WaID >= '{whsCdFrom}'");
                    sbWhere.AppendLine("AND");
                }
                if (!string.IsNullOrEmpty(whsCdTo))
                {
                    sbWhere.AppendLine($"    WH.WaID <= '{whsCdTo}'");
                    sbWhere.AppendLine("AND");
                }
            }

            if (!string.IsNullOrEmpty(goodsName))
            {
                sbWhere.Append($"MP.PrName LIKE '%{goodsName}%'");
                sbWhere.AppendLine("AND");

            }

            if (!string.IsNullOrEmpty(goodsCdFrom) &&!string.IsNullOrEmpty(goodsCdTo))
            {
                sbWhere.AppendLine($"    MP.PrID >= '{goodsCdFrom}'");
                sbWhere.AppendLine($"AND    MP.PrID <= '{goodsCdTo}'");

                sbWhere.AppendLine("AND");
            }
            else
            {
                if (!string.IsNullOrEmpty(goodsCdFrom))
                {
                    sbWhere.AppendLine($"    MP.PrID >= '{goodsCdFrom}'");
                    sbWhere.AppendLine("AND");
                }
                if (!string.IsNullOrEmpty(goodsCdTo))
                {
                    sbWhere.AppendLine($"    MP.PrID <= '{goodsCdTo}'");
                    sbWhere.AppendLine("AND    ");
                }
            }


            if (!string.IsNullOrEmpty(dtFrom) && !string.IsNullOrEmpty(dtTo))
            {
                sbWhere.AppendLine($"    WH.WaDate >= '{dtFrom}'");
                sbWhere.AppendLine($"AND    WH.WaDate <= '{dtTo}'");

                sbWhere.AppendLine("AND");

            }
            else
            {
                if (!string.IsNullOrEmpty(dtFrom))
                {
                    sbWhere.AppendLine($"    WH.WaDate >= '{dtFrom}'");
                    sbWhere.AppendLine("AND");

                }
                if (!string.IsNullOrEmpty(dtTo))
                {
                    sbWhere.AppendLine($"    WH.WaDate <= '{dtTo}'");
                    sbWhere.AppendLine("AND");

                }
            }

            var where = sbWhere.ToString();
            //Khi khong co dieu kien thi xoa WHERE
            if (where.Length <= 7)
            {
                where = string.Empty;
            }
            if (!string.IsNullOrEmpty(where))
            {
                where = where.TrimEnd().Substring(0, where.Length - 5);
            }

            return where;
        }


        public DataTable GetWareHousingModifyData(string whsNo, string whsDate)
        {
            var dt = new DataTable();
            var dbConn = new DBConnection();
            var conn = dbConn.GetConnection();

            try
            {
                conn.Open();

                var sb = new StringBuilder();

                sb.AppendLine("SELECT");
                sb.AppendLine("      WH.WaID");
                sb.AppendLine("    , WH.WaDate");
                sb.AppendLine("    , WHD.PrID");
                sb.AppendLine("    , MP.PrName");
                sb.AppendLine("    , WHD.WDquantity");
                sb.AppendLine("    , MP.Price");
                sb.AppendLine("    , MP.Mnumber");
                sb.AppendLine("    , MP.Color");
                sb.AppendLine("    , Cast((CAST(MP.Price as int) * CAST(WHD.WDquantity as int)) as char) AS TotalAmount");
                sb.AppendLine("FROM");
                sb.AppendLine("     T_Warehousing AS WH");
                sb.AppendLine("LEFT JOIN");
                sb.AppendLine("     T_WarehousingDetails AS WHD");
                sb.AppendLine("ON WH.WaID = WHD.WaID");
                sb.AppendLine("INNER JOIN M_Product AS MP");
                sb.AppendLine("ON WHD.PrID = MP.PrId");
                sb.AppendLine("WHERE");
                sb.AppendLine($"    WH.WaID = '{whsNo}'");
                sb.AppendLine($"AND    WH.WaDate = '{whsDate}'");


                SqlCommand command = dbConn.SetCommand(sb.ToString(), conn);
                SqlDataAdapter dataAdapter = dbConn.Execute(command);

                dataAdapter.Fill(dt);

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
