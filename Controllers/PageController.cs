using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FPLForecaster.Models;
using FPLForecaster.Clients;
using FPLForecaster.Models.Manager;

namespace FPLForecaster.Controllers
{
    public class PageController : Controller
    {
        private readonly ILogger<PageController> _logger;

        public PageController(ILogger<PageController> logger)
        {
            _logger = logger;
        }

        public IActionResult ManagerView()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ManagerView(int? manager_id)
        {
            if (manager_id != null && manager_id.ToString().All(x => char.IsNumber(x)))
            {
                if (DataService.Data.ManagerData == null) DataService.Data.ManagerData = new ManagerData();
                DataService.Data.ManagerData.ManagerGameweeks = DataService.Controller.managerClient.GetManagerGameweeksData(manager_id.Value).Result;
                DataService.Data.ManagerData.ManagerInformation = DataService.Controller.managerClient.GetManagerGeneralInfo(manager_id.Value).Result;
            }
            return View();
        }

        public IActionResult PlayerView()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
