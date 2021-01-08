using System;
using System.Net;
using System.IO;

namespace FPL_Forecaster
{
    public class Controller
    {
        public void GetJson()
        {
            HttpWebRequest req = WebRequest.Create("https://fantasy.premierleague.com/api/bootstrap-static/") as HttpWebRequest;

            req.Method = "GET";
            HttpWebResponse response = req.GetResponse() as HttpWebResponse;
        
            string jsonDerulo = null;
            using (Stream stream = response.GetResponseStream())   
            {   
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                jsonDerulo = reader.ReadToEnd();
            }
            Console.WriteLine(jsonDerulo);
        }
    }
}