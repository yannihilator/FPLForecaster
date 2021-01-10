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
            var test = DataService.Data.Players.GroupBy(x => x?.element_type);
            foreach (IGrouping<int?, Models.Player> group in test)
            {
                Console.WriteLine("\n\n\n");
                Console.WriteLine(DataService.Enumerators.PlayerTypes.Where(x => x?.id == group.Key).FirstOrDefault()?.plural_name);
                Console.WriteLine("****************************************************************");
                foreach (Models.Player player in group.Where(y => y.total_points > 0).OrderByDescending(x => x?.total_points/x?.now_cost).ToList())
                {
                    Console.WriteLine($"{player.first_name} {player.second_name}: {player.total_points}");
                }
/*             DataService.Data.Players = DataService.Data.Players.OrderBy(x => x?.total_points).ToList();
            foreach (Models.Player player in DataService.Data.Players)
            {
                Console.WriteLine($"{player.first_name} {player.second_name}: {player.total_points}");
            }
            foreach (Models.ManagerGameweek gameweekData in DataService.Data.ManagerData)
            {
                Console.WriteLine($"Gameweek {gameweekData.@event} Total Points: {gameweekData.points}");
            } */
            }
        }
    }
}
