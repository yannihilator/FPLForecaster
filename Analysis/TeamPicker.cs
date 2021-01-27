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
                DataService.Data.Players.OrderByDescending(x => Convert.ToDouble(x.total_points/x.now_cost))
                .ToList() : null;
            List<Player> playersByPoints = DataService.Data.Players != null && DataService.Data.Players.Count > 0 ?
                DataService.Data.Players.OrderByDescending(x => x.total_points).ToList() : null;
            
            //counters
            int goalkeeperCount = 2;
            int defenderCount = 5;
            int midfielderCount = 5;
            int forwardCount = 3;
            int counter = 0;

            if (playersByRoi != null && playersByPoints != null && playersByRoi.Count > 0)
            {
                while (chosenTeam.Count < 15)
                {
                    var playerList = counter % 2 == 0 ? playersByPoints : playersByRoi;
                    var playerTypes = DataService.Enumerators.PlayerTypes;
                    if (forwardCount > 0)
                    {      
                        chosenTeam.Add(GetPlayerAlgorithm(playerList,chosenTeam,"forward"));
                        forwardCount--;
                    }
                    if (midfielderCount > 0)
                    {
                        chosenTeam.Add(GetPlayerAlgorithm(playerList,chosenTeam,"midfielder"));
                        midfielderCount--;
                    }
                    if (defenderCount > 0)
                    {
                        chosenTeam.Add(GetPlayerAlgorithm(playerList,chosenTeam,"defender"));
                        defenderCount--;
                    }
                    if (goalkeeperCount > 0)
                    {
                        chosenTeam.Add(GetPlayerAlgorithm(playerList,chosenTeam,"goalkeeper"));
                        goalkeeperCount--;
                    }
                    counter++;
                }
            }

            var sum = chosenTeam.Sum(x => x?.now_cost);

            foreach (Player player in chosenTeam)
            {
                player.playerDetails = DataService.Controller.playerClient.GetPlayerDetails(player.id).Result;
            }

            return chosenTeam;
        }

        public static Player GetPlayerAlgorithm(List<Player> playerList, List<Player> chosenTeam, string position)
        {
            var minCost = DataService.Data.Players.Where(x => DataService.Enumerators.PlayerTypes.Where(y => y.id == x.element_type).FirstOrDefault()?.singular_name?.ToLower() == position)
                .Select(x => x.now_cost).Min();
            return playerList.Where(x => 
                            DataService.Enumerators.PlayerTypes.Where(y => y.id == x.element_type).FirstOrDefault()?.singular_name?.ToLower() == position
                            && chosenTeam.Sum(y => y.now_cost) + x.now_cost <= 1000 - minCost
                            && x.status == "a"
                            && chosenTeam.Contains(x) == false
                            && chosenTeam.Count(z => z.team == x?.team) < 3).FirstOrDefault();
        }
    }
}