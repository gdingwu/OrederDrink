using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static OrederDrink.Models.ChooseStore.ViewModel.ChooseStoreViewModel;

namespace OrederDrink.Models.ChooseStore
{
    public class ChooseStoreSetModel
    {
        public List<StoreModel> GetStoreList() {
            List<StoreModel> list = new List<StoreModel>();
            list.Add(new StoreModel { StoreName ="約翰紅茶", StoreID =1 ,Status=1});
            list.Add(new StoreModel { StoreName = "可不可", StoreID = 2, Status = 1 });
            return list;
        }
    }
}
