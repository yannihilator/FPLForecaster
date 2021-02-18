using System;
using System.Net;
using System.Linq;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using FPLForecaster.Models;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace FPLForecaster.Clients
{
    public class PlayerClient
    {
        public async Task<List<Player>> GetAllPlayers()
        {
            //gets general data for players from general information endpoint
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var json = await FPLClient.HttpClient.GetStringAsync("bootstrap-static/");
            var jsonPlayer = JObject.Parse(json)["elements"].ToString();
            List<Player> players = JsonConvert.DeserializeObject<List<Player>>(jsonPlayer);
            
            //gets player fixture stats
            for (int i = 1; i <= DataService.Data.CurrentGameweek; i++)
            {
                var fixtureObjects = JObject.Parse(await FPLClient.HttpClient.GetStringAsync($"event/{i}/live/"))["elements"];
                foreach (Player player in players)
                {
                    if (player.playerDetails == null) player.playerDetails = new PlayerDetails();
                    if (player.playerDetails.fixtures == null) player.playerDetails.fixtures = new List<PlayerFixture>();

                    var playerFixture = fixtureObjects.Where(x => (int)x["id"] == player.id).FirstOrDefault();
                    if (playerFixture != null)
                    {
                        var playerStats = JsonConvert.DeserializeObject<PlayerFixture>(playerFixture["stats"].ToString());
                        var explain = playerFixture["explain"].FirstOrDefault();         
                        if (explain != null) playerStats.fixtureId = (int)explain["fixture"];
                        player.playerDetails.fixtures.Add(playerStats);
                    }

                }
            }

            return players;
        }

        public async Task<PlayerDetails> GetPlayerDetails(int player_id, bool getHistoricData = false)
        {
            var jsonPlayerDetails = await FPLClient.HttpClient.GetStringAsync($"element-summary/{player_id}/");

            string jsonFuture = JObject.Parse(jsonPlayerDetails)["fixtures"].ToString();
            string jsonPast = JObject.Parse(jsonPlayerDetails)["history"].ToString();
            
            PlayerDetails playerDetails = new PlayerDetails()
            {
                futureFixtures = JsonConvert.DeserializeObject<ICollection<PlayerFutureFixture>>(jsonFuture),
                pastFixtures = JsonConvert.DeserializeObject<ICollection<PlayerPastFixture>>(jsonPast)           
            };

            //populates historic data if bool is set to true. It is set to false by default because this is not ideal, as it decreases performance
            if (getHistoricData)
            {
                string jsonHistorical = JObject.Parse(jsonPlayerDetails)["history_past"].ToString();
                playerDetails.historicalFixtures = JsonConvert.DeserializeObject<ICollection<PlayerHistoricalFixture>>(jsonHistorical);
            }
            return playerDetails;
        }

        public async Task<ICollection<PlayerType>> GetPlayerTypes()
        {
            var json = await FPLClient.HttpClient.GetStringAsync("bootstrap-static/");
            var jsonPlayerType = JObject.Parse(json)["element_types"].ToString();
            return JsonConvert.DeserializeObject<ICollection<PlayerType>>(jsonPlayerType);
        }
    }
}