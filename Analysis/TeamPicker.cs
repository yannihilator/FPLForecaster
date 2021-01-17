using System;
using System.Collections.Generic;
using FPLForecaster.Models;
using System.Linq;

namespace FPLForecaster.Analysis
{
    public static class TeamPicker
    {
        public static List<Player> AITeam()
        {
            List<Player> chosenTeam = new List<Player>();

            //gets players that 
            List<Player> playersByRoi = DataService.Data.Players != null && DataService.Data.Players.Count > 0 ? 
                DataService.Data.Players.OrderBy(x => Convert.ToDouble(x.total_points/x.now_cost)).ToList() : null;
            List<Player> playersByPoints = DataService.Data.Players != null && DataService.Data.Players.Count > 0 ?
                DataService.Data.Players.OrderBy(x => x.total_points).ToList() : null;

            //cost variable
            double teamCost = 100.0;

            if (playersByRoi != null && playersByPoints != null && playersByRoi.Count > 0)
            {
                
            }

            return chosenTeam;
        }
    }
}