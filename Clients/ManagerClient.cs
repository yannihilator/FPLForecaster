using System;
using FPLForecaster.Models;
using System.Collections.Generic;
using System.Net;   
using Newtonsoft.Json;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using FPLForecaster.Models.Manager;

namespace FPLForecaster.Clients
{
    public class ManagerClient
    {
        public async Task<ICollection<ManagerGameweek>> GetManagerGameweeksData(int manager_id)
        {
            //FPL Fantasy Draft Manager ID: 378015
            //FPL Fantasy Normal Manager ID: 5884469
            //gets all gameweeks data for current season for a manager given their id.
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var json = await FPLClient.HttpClient.GetStringAsync($"entry/{manager_id}/history/");
            var jsonManager = JObject.Parse(json)["current"].ToString();
            return JsonConvert.DeserializeObject<ICollection<ManagerGameweek>>(jsonManager);
        }

        public async Task<ManagerGeneralInfo> GetManagerGeneralInfo(int manager_id)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var json = await FPLClient.HttpClient.GetStringAsync($"entry/{manager_id}/");
            return JsonConvert.DeserializeObject<ManagerGeneralInfo>(json);
        }
    }
}