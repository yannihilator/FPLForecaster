using System;
using System.Linq;
using FPL_Forecaster.Clients;
using FPL_Forecaster.Models;
using System.Threading.Tasks;

namespace FPL_Forecaster
{
    public class Controller
    {
        private FixtureClient fixtureClient;
        private PlayerClient playerClient;
        private ManagerClient managerClient;

        public Controller()
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