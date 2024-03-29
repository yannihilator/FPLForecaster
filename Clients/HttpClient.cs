using System;
using System.Net.Http;

namespace FPLForecaster.Clients
{
    internal static class FPLClient
    {
        internal static readonly HttpClient HttpClient = new HttpClient()
        {
            BaseAddress = new Uri("https://fantasy.premierleague.com/api/")
        };

        internal static bool ConnectionSuccessful(string endpoint)
        {
            return HttpClient.GetAsync(HttpClient.BaseAddress + endpoint).Result.IsSuccessStatusCode;
        }
    }  
}