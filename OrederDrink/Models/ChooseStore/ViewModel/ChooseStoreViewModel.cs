using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrederDrink.Models.ChooseStore.ViewModel
{
    public class ChooseStoreViewModel
    {
        public List<StoreModel> StoreList { get; set; }
        public class StoreModel 
        {
            public string StoreName { get; set; }
            public int StoreID { get; set; }
            public int Status { get; set; }
        }
    }
}
