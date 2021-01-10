using System;
using System.Linq;
using FPLForecaster.Clients;
using FPLForecaster.Models;
using System.Threading.Tasks;

namespace FPLForecaster.Controllers
{
    public class DataController
    {
        private FixtureClient fixtureClient;
        private PlayerClient playerClient;
        private ManagerClient managerClient;

        public DataController()
        {
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
    }
}