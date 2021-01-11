using System;
using System.Linq;
using FPLForecaster.Clients;
using FPLForecaster.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FPLForecaster.Controllers
{
    public class DataController : Controller
    {
        private readonly ILogger<PageController> _logger;
        private FixtureClient fixtureClient;
        private PlayerClient playerClient;
        private ManagerClient managerClient;

        public DataController(ILogger<PageController> logger)
        {
            _logger = logger;
            fixtureClient = new FixtureClient();
            playerClient = new PlayerClient();
            managerClient = new ManagerClient();
        }
               
        public void GetData()
        {
            DataService.Data.Fixtures = fixtureClient.GetAllFixtures().Result;
            DataService.Data.Players = playerClient.GetAllPlayers().Result;
            DataService.Enumerators.PlayerTypes = playerClient.GetPlayerTypes().Result;
            DataService.Data.ManagerData = managerClient.GetManagerGameweeksData(5884469).Result;
        }

        public ICollection<ManagerGameweek> GetManagerData(int manager_id)
        {
            return managerClient.GetManagerGameweeksData(manager_id).Result;
        }
    }
}