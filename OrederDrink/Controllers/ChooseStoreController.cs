using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using OrederDrink.Models.ChooseStore;
using OrederDrink.Models.ChooseStore.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static OrederDrink.DBModel.StoreDBModel;

namespace OrederDrink.Controllers
{
    public class ChooseStoreController : Controller
    {
        private readonly ILogger<ChooseStoreController> _logger;

        public ChooseStoreController(ILogger<ChooseStoreController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ChooseStore()
        {
            ChooseStoreViewModel ViewModel = new ChooseStoreViewModel();
            ChooseStoreSetModel model = new ChooseStoreSetModel();
            ViewModel.StoreList = model.GetStoreList();
            return View(ViewModel);
        }
        public JObject GetBervage( string StoreID) 
        {
            ChooseStoreSetModel model = new ChooseStoreSetModel();
            return model.BervageList_Get(Convert.ToInt32(StoreID));
        }
    }
}
