using System.Collections.Generic;

namespace FPLForecaster.Models.Manager
{
    public class ManagerLeagues
    {
        public List<ClassicLeague> classic { get; set; } 
        public List<H2HLeague> h2h { get; set; } 
        public ManagerCup cup { get; set; } 
    }
}