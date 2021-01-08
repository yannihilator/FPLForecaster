using System;
using System.Net;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using FPL_Forecaster.Models;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace FPL_Forecaster.Clients
{
    public class FixtureClient
    {
        public void GetJson()
        {
            HttpWebRequest req = WebRequest.Create("https://fantasy.premierleague.com/api/fixtures/"/*"https://fantasy.premierleague.com/api/bootstrap-static/"*/) as HttpWebRequest;
            System.Net.Http.HttpClient cln = new System.Net.Http.HttpClient();

            req.Method = "GET";
            HttpWebResponse response = req.GetResponse() as HttpWebResponse;
            
            string jsonDerulo = null;
            using (Stream stream = response.GetResponseStream())   
            {   
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                jsonDerulo = reader.ReadToEnd();
            }
            
            //Element test = System.Text.Json.JsonSerializer.Deserialize<Element>(jsonDerulo);
            Console.WriteLine(jsonDerulo);
            var test = JsonConvert.DeserializeObject<ICollection<Fixture>>(jsonDerulo);
        }

        public async Task<ICollection<Fixture>> GetAllFixtures()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var json = await FPLClient.HttpClient.GetStringAsync("fixtures/");
            return JsonConvert.DeserializeObject<ICollection<Fixture>>(json);
        }
    }
}