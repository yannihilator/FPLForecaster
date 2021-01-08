using System;

namespace FPL_Forecaster
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World! This is my FPL forecaster script");
            var controller = new Controller();
            controller.GetJson();
        }
    }
}
