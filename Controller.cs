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

        public Controller()
        {
            fixtureClient = new FixtureClient();
        }
               
        public void GetData()
        {
            DataService.Data.Fixtures = fixtureClient.GetAllFixtures().Result;
        }
    }
}