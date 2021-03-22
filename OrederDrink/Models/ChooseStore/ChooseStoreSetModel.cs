using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OrederDrink.DBModel;
using OrederDrink.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static OrederDrink.DBModel.StoreDBModel;
using static OrederDrink.Models.ChooseStore.ViewModel.ChooseStoreViewModel;

namespace OrederDrink.Models.ChooseStore
{
    public class ChooseStoreSetModel
    {
        StoreDB DB = new StoreDB();
        public List<StoreModel> GetStoreList() 
        {
            List<StoreModel> list = DB.SP_StoreGet();
            return list;
        }
        public JObject BervageList_Get(int StoreID) {
            JObject result = new JObject();
            List<BeverageModel> list = DB.SP_BeverageGet(StoreID);
            if (list.Count > 0)
            {
                result.Add("code", 1);
                result.Add("BeverageList", JsonConvert.SerializeObject(list));

            }
            else {
                result.Add("code", -1);
                result.Add("msg", "此飲料店沒有飲料");

            }
            return result;
        }
    }
}
