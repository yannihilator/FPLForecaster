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
    public class DataController //: Controller
    {
        //private readonly ILogger<PageController> _logger;
        public FixtureClient fixtureClient {get; private set;}
        public PlayerClient playerClient {get; private set;}
        public ManagerClient managerClient {get; private set;}

        public DataController()//ILogger<PageController> logger)
        {
            //_logger = logger;
            fixtureClient = new FixtureClient();
            playerClient = new PlayerClient();
            managerClient = new ManagerClient();
        }
               
        public void GetData()
        {
            DataService.Data.Fixtures = fixtureClient.GetAllFixtures().Result;
            DataService.Data.Players = playerClient.GetAllPlayers().Result;
            DataService.Enumerators.PlayerTypes = playerClient.GetPlayerTypes().Result;
            if (DataService.Data.ManagerData == null) DataService.Data.ManagerData = new ManagerData();
            DataService.Data.ManagerData.ManagerGameweeks = managerClient.GetManagerGameweeksData(5884469).Result;
        }

        //public ICollection<ManagerGameweek> GetManagerData(int manager_id)
        //{
        //    return managerClient.GetManagerGameweeksData(manager_id).Result;
        //}
    }
}