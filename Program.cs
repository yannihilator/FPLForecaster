using System;
using FPL_Forecaster.Clients;
using System.Linq;

namespace FPL_Forecaster
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World! This is my FPL forecaster script");
            var controller = new Controller();
            controller.GetData();
            DataService.Data.Players.GroupBy(x => x?.element_type);
            DataService.Data.Players = DataService.Data.Players.OrderBy(x => x?.total_points).ToList();
            foreach (Models.Player player in DataService.Data.Players)
            {
                Console.WriteLine($"{player.first_name} {player.second_name}: {player.total_points}");
            }
            foreach (Models.ManagerGameweek gameweekData in DataService.Data.ManagerData)
            {
                Console.WriteLine($"Gameweek {gameweekData.@event} Total Points: {gameweekData.points}");
            }
        }
    }
}
