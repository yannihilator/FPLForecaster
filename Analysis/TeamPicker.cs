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

            //rearranges available players by their ROI and by total points for easy access
            List<Player> playersByRoi = DataService.Data.Players != null && DataService.Data.Players.Count > 0 ? 
                DataService.Data.Players.OrderByDescending(x => Convert.ToDouble(x.total_points/x.now_cost))
                .ToList() : null;
            List<Player> playersByPoints = DataService.Data.Players != null && DataService.Data.Players.Count > 0 ?
                DataService.Data.Players.OrderByDescending(x => x.total_points).ToList() : null;
            List<Player> playersByModel = DataService.Data.Players.Where(x => x.minutes > 0)
                .Select(x => {x.predictivePlayerRating = PredictivePlayerRating(x); return x;}).OrderByDescending(x => x.predictivePlayerRating).ToList();
            
            //counters for how many players each position should choose
            int goalkeeperCount = 2;
            int defenderCount = 5;
            int midfielderCount = 5;
            int forwardCount = 3;
            int counter = 0;

            //checks to see if player lists are populated
            if (playersByRoi != null && playersByPoints != null && playersByRoi.Count > 0)
            {
                while (chosenTeam.Count < 15)
                {
                    //alternates between choosing players by total points (more expensive) and players by ROI
                    var playerList = playersByModel;//counter % 2 == 0 ? playersByPoints : playersByRoi;
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

            /* var playersByExpense = chosenTeam.OrderBy(x => x.total_points).ThenByDescending(x => x.now_cost).ToList();
            while (chosenTeam.Sum(x => x?.now_cost).Value > 1000)
            {
                
            } */


            //gets player details for only chosen players, for memory conservation purposes
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
                            //&& chosenTeam.Sum(y => y.now_cost) + x.now_cost <= 1000 - minCost
                            && x.status == "a"
                            && chosenTeam.Contains(x) == false
                            && chosenTeam.Count(z => z.team == x?.team) < 3).FirstOrDefault();
        }

        /// <summary>
        /// Algorithm that returns a player's value based on their last 10 games.
        /// </summary>
        /// <param name="player"></param>
        /// <returns>double</returns>
        public static double PredictivePlayerRating(Player player)
        {
            //additional data about player. Will not be disposed at the end of algorithm, as there is no need to keep it
            //and consume memory if the player will not be selected
            var playerDetails = DataService.Controller.playerClient.GetPlayerDetails(player.id).Result;
            var lastTenGames = playerDetails.pastFixtures.TakeLast(5);

            //initializing metrics to take into consideration about each player. Takes into consideration their last 10 games
            //*************************************************************************************************
            //is their team in a good position/good form?
            int weight_teamPosition = 1;
            double teamPosition = Math.Pow((double)DataService.Data.Teams.Where(x => x.id == player.team).FirstOrDefault()?.position, -1)*20;
            //are they being regularly selected?
            int weight_minuteConfidence = 4;
            double minuteConfidence = (double)lastTenGames.Select(x => x?.minutes).Where(x => x.HasValue).Sum().Value/lastTenGames.Count();
            //have they been returning recently?
            int weight_pointsPerGame = 5;
            double pointsPerGame = (double)lastTenGames.Select(x => x.total_points).Where(x => x.HasValue).Sum()/lastTenGames.Count();
            //how much will it cost. Are they worth the expense?
            int weight_costFactor = 5;
            double costFactor = Math.Pow(player.now_cost, -1);

            return weight_teamPosition * teamPosition + 
                   weight_minuteConfidence * minuteConfidence +
                   weight_pointsPerGame * pointsPerGame +
                   weight_costFactor * costFactor;
        }
    }
}