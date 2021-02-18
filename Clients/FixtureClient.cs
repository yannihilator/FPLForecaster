using System;
using System.Net;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using FPLForecaster.Models;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace FPLForecaster.Clients
{
    public class FixtureClient
    {
        public async Task<List<Fixture>> GetAllFixtures()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var json = await FPLClient.HttpClient.GetStringAsync("fixtures/");
            return JsonConvert.DeserializeObject<List<Fixture>>(json);
        }
    }
}