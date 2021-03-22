using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OrederDrink.Models.DB
{
    class ConnectDB
    {
        static public SqlCommand ReadSQLDB(SqlConnection _conn, string _text)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandText = _text;
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }
        #region DB_Action SP資料庫連線
        /// <summary>
        /// 資料庫連線
        /// </summary>
        /// <param name="str_conn">連線字串</param>
        /// <param name="sp_name">SP 名稱</param>
        /// <param name="sql_value">輸入的值與類型</param>
        static public List<T> DB_SPAction<T>(string str_conn, string sp_name, object sql_value)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(str_conn))
                {
                    return conn.Query<T>(sp_name, sql_value, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            {
                //logger.Warn(ex.ToString());
                //return null;
                throw ex;
            }
        }
        #endregion
    }
}
