using System;
using System.Net.Http;

namespace FPL_Forecaster.Clients
{
    internal static class FPLClient
    {
        internal static readonly HttpClient HttpClient = new HttpClient()
        {
            BaseAddress = new Uri("https://fantasy.premierleague.com/api/"),
            Timeout = TimeSpan.FromMinutes(1)
        };
    }  
}