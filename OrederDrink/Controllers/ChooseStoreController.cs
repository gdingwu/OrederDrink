using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
       
    }
}
