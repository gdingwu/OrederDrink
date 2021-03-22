using OrederDrink.DBModel;
using OrederDrink.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static OrederDrink.Models.ChooseStore.ViewModel.ChooseStoreViewModel;

namespace OrederDrink.Models.ChooseStore
{
    public class ChooseStoreSetModel
    {
        public List<StoreDBModel> GetStoreList() {
            StoreDB DB = new StoreDB();
            List<StoreDBModel> list = DB.SP_StoreGet();
            //list.Add(new StoreModel { StoreName ="約翰紅茶", ID =1 ,Status=1});
            //list.Add(new StoreModel { StoreName = "可不可", ID = 2, Status = 1 });
            return list;
        }
    }
}
