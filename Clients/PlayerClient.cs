using System;
using System.Net;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using FPL_Forecaster.Models;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace FPL_Forecaster.Clients
{
    public class PlayerClient
    {
        public async Task<ICollection<Player>> GetAllPlayers()
        {
            //gets general data for players from general information endpoint
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var json = await FPLClient.HttpClient.GetStringAsync("bootstrap-static/");
            var jsonPlayer = JObject.Parse(json)["elements"].ToString();
            ICollection<Player> players = JsonConvert.DeserializeObject<ICollection<Player>>(jsonPlayer);

            //gets detailed data for each player and adds it in to their model
            foreach (Player player in players)
            {
                var jsonPlayerDetails = await FPLClient.HttpClient.GetStringAsync($"element-summary/{player.id}/");

                string jsonFuture = JObject.Parse(jsonPlayerDetails)["fixtures"].ToString();
                string jsonPast = JObject.Parse(jsonPlayerDetails)["history"].ToString();
                string jsonHistorical = JObject.Parse(jsonPlayerDetails)["history_past"].ToString();

                player.futureFixtures = JsonConvert.DeserializeObject<ICollection<PlayerFutureFixture>>(jsonFuture);
                player.pastFixtures = JsonConvert.DeserializeObject<ICollection<PlayerPastFixture>>(jsonPast);
                player.historicalFixtures = JsonConvert.DeserializeObject<ICollection<PlayerHistoricalFixture>>(jsonHistorical);
            }
            return players;
        }
    }
}