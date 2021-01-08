using System;
using FPL_Forecaster.Clients;

namespace FPL_Forecaster
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World! This is my FPL forecaster script");
            var controller = new Controller();
            controller.GetData();
            foreach (FPL_Forecaster.Models.Fixture fix in DataService.Data.Fixtures)
            {
                Console.WriteLine(fix.kickoff_time.ToString());
            }
            foreach (FPL_Forecaster.Models.Player pl in DataService.Data.Players)
            {
                Console.WriteLine(pl.web_name);
            }
        }
    }
}
