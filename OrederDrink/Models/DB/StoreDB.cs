using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;
using Dapper;
using OrederDrink.DBModel;

namespace OrederDrink.Models.DB
{
    public class StoreDB
    {
        public string str_conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        #region 搜尋飲料店名
        public List<StoreDBModel> SP_StoreGet()
        {
            DynamicParameters param = new DynamicParameters();
            return ConnectDB.DB_SPAction<StoreDBModel>(str_conn, "SP_StoreGet", param);
        }
        #endregion
    }
}
