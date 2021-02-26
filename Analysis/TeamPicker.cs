using System;
using System.Collections.Generic;
using FPLForecaster.Models;
using System.Linq;
using System.Threading.Tasks;

namespace FPLForecaster.Analysis
{
    public class TeamPicker
    {
        private int gameweekCount;
        
        /// <summary>
        /// Main method for choosing an FPL team of 15 players.
        /// </summary>
        /// <param name="progress"></param>
        /// <returns></returns>
        public async Task<List<Player>> AITeam(int _gameweekCount)
        {
            List<Player> chosenTeam = new List<Player>();
            gameweekCount = _gameweekCount;

            //rearranges available players by their predictive player rating for easy access
            List<Player> playerList = DataService.Data.Players.Where(x => x?.minutes > 0 && x?.playerDetails?.fixtures?.Count > 0).ToList();
            playerList = playerList.Select(x => 
                {
                    x.predictivePlayerRating = PredictivePlayerRating(x); 
                    return x;
                }).OrderByDescending(x => x.predictivePlayerRating).ToList();
            
            //counters for how many players each position should choose
            int goalkeeperCount = 2;
            int defenderCount = 5;
            int midfielderCount = 5;
            int forwardCount = 3;
            int counter = 0;

            //checks to see if player lists are populated
            if (playerList != null && playerList.Count > 0)
            {
                while (chosenTeam.Count < 15)
                {
                    //alternates between choosing players by total points (more expensive) and players by ROI
                    //var playerList = playersByModel;//counter % 2 == 0 ? playersByPoints : playersByRoi;
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
                player.playerDetails = DataService.Controller.PlayerClient.GetPlayerDetails(player.id).Result;
            }

            return chosenTeam;
        }

        /// <summary>
        /// Picks the next player for the FPL team given the master list of players, the players chosen so far, and a position
        /// </summary>
        /// <param name="playerList"></param>
        /// <param name="chosenTeam"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        private Player GetPlayerAlgorithm(List<Player> playerList, List<Player> chosenTeam, string position)
        {
            var minCost = DataService.Data.Players.Where(x => DataService.Enumerators.PlayerTypes.Where(y => y.id == x.element_type).FirstOrDefault()?.singular_name?.ToLower() == position)
                .Select(x => x.now_cost).Min();
            var player = playerList.Where(x => 
                            DataService.Enumerators.PlayerTypes.Where(y => y.id == x.element_type).FirstOrDefault()?.singular_name?.ToLower() == position
                            //&& chosenTeam.Sum(y => y.now_cost) + x.now_cost <= 1000 - minCost
                            && (x.status == "a" || x.status == "d")
                            && chosenTeam.Select(x => x.id).ToList().Contains(x.id) == false
                            && chosenTeam.Count(z => z.team == x?.team) < 3).FirstOrDefault();
            return player.Clone();
        }

        /// <summary>
        /// Algorithm that returns a player's value based on their last number of games specified.
        /// </summary>
        /// <param name="player"></param>
        /// <returns>double</returns>
        private double PredictivePlayerRating(Player player)
        {
            //additional data about player. Will not be disposed at the end of algorithm, as there is no need to keep it
            //and consume memory if the player will not be selected
            //var playerDetails = DataService.Controller.PlayerClient.GetPlayerDetails(player.id).Result;
            var lastTenGames = player.playerDetails.fixtures?.TakeLast(gameweekCount);

            //initializing metrics to take into consideration about each player. Takes into consideration their last 10 games
            //*************************************************************************************************
            //is their team in a good position/good form?
            int weight_teamPosition = 1;
            double teamPosition = Math.Pow((double)DataService.Data.Teams.Where(x => x.id == player.team).FirstOrDefault()?.position, -1);
            //are they being regularly selected?
            int weight_minuteConfidence = 2;
            double minuteConfidence = (double)lastTenGames.Select(x => x?.minutes).Where(x => x.HasValue).Sum().Value/(90*gameweekCount);
            //have they been returning points recently?
            int weight_pointsPerGame = 6;
            double pointsPerGame = (double)lastTenGames.Select(x => x.total_points).Where(x => x.HasValue).Sum()/gameweekCount;
            //what is their value in their position?
            int weight_contributionFactor = 3;
            double contributionFactor = lastTenGames.Select(x => Convert.ToDouble(x?.ict_index ?? "0.0")).Sum()/gameweekCount;
            //how much will it cost. Are they worth the expense?
            int weight_costFactor = 0;
            double costFactor = Math.Pow(player.now_cost, -1);

            return weight_teamPosition * teamPosition + 
                   weight_minuteConfidence * minuteConfidence +
                   weight_pointsPerGame * pointsPerGame +
                   weight_costFactor * costFactor +
                   weight_contributionFactor * contributionFactor;
        }
    }
}