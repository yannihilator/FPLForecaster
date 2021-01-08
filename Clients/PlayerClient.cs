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
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var json = await FPLClient.HttpClient.GetStringAsync("bootstrap-static/");
            var jsonPlayer = JObject.Parse(json)["elements"].ToString();
            return JsonConvert.DeserializeObject<ICollection<Player>>(jsonPlayer);
        }
    }
}