using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;
using Dapper;
using OrederDrink.DBModel;
using static OrederDrink.DBModel.StoreDBModel;

namespace OrederDrink.Models.DB
{
    public class StoreDB
    {
        public string str_conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        #region 搜尋飲料店名
        public List<StoreModel> SP_StoreGet()
        {
            DynamicParameters param = new DynamicParameters();
            return ConnectDB.DB_SPAction<StoreModel>(str_conn, "SP_StoreGet", param);
        }
        #endregion
        #region 搜尋飲料品項
        public List<BeverageModel> SP_BeverageGet(int StoreID)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@StoreID", StoreID, dbType: DbType.Int32);
            return ConnectDB.DB_SPAction<BeverageModel>(str_conn, "SP_BeverageGet", param);
        }
        #endregion
    }
}
