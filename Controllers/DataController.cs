using System;
using System.Linq;
using FPLForecaster.Clients;
using FPLForecaster.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FPLForecaster.Models.Manager;

namespace FPLForecaster.Controllers
{
    public class DataController
    {
        public FixtureClient FixtureClient {get; private set;}
        public PlayerClient PlayerClient {get; private set;}
        public ManagerClient ManagerClient {get; private set;}
        public TeamClient TeamClient {get; private set;}

        public DataController()
        {
            FixtureClient = new FixtureClient();
            PlayerClient = new PlayerClient();
            ManagerClient = new ManagerClient();
            TeamClient = new TeamClient();
        }
               
        public void GetGeneralData()
        {
            DataService.Data.Fixtures = FixtureClient.GetAllFixtures().Result;
            DataService.Data.Players = PlayerClient.GetAllPlayers().Result;
            DataService.Enumerators.PlayerTypes = PlayerClient.GetPlayerTypes().Result;
            DataService.Data.Teams = TeamClient.GetTeamsGeneralData().Result;
            TeamClient.UpdateTeamData();
        }
    }
}