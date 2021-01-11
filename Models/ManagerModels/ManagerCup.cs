using System.Collections.Generic;

namespace FPLForecaster.Models.Manager
{
    public class ManagerCup
    {
        public List<ManagerMatch> matches { get; set; } 
        public ManagerStatus status { get; set; } 
    }
}