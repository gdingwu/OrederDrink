using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrederDrink.DBModel
{
    public class StoreDBModel
    {
        public class StoreModel
        {
            public int Id { get; set; }
            public int Status { get; set; }
            public string StoreName { get; set; }
        }
        public class BeverageModel
        {
            public int Id { get; set; }
            public int StoreID { get; set; }
            public string Beverage { get; set; }
            public string Price { get; set; }
            public string Size { get; set; }
        }

    }
}
