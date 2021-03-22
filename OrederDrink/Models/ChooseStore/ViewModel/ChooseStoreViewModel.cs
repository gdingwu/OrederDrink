using OrederDrink.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static OrederDrink.DBModel.StoreDBModel;

namespace OrederDrink.Models.ChooseStore.ViewModel
{
    public class ChooseStoreViewModel
    {
        public List<StoreModel> StoreList { get; set; }
        public List<BeverageModel> BeverageList { get; set; }

    }
}
