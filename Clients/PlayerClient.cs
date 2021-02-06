using System;
using System.Net;
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
        public async Task<ICollection<Player>> GetAllPlayers()
        {
            //gets general data for players from general information endpoint
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var json = await FPLClient.HttpClient.GetStringAsync("bootstrap-static/");
            var jsonPlayer = JObject.Parse(json)["elements"].ToString();
            ICollection<Player> players = JsonConvert.DeserializeObject<ICollection<Player>>(jsonPlayer);
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