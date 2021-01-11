using System.Collections.Generic;

namespace FPLForecaster.Models
{
    public class ManagerData
    {
        public ManagerGeneralInfo ManagerInformation {get;set;}
        public ICollection<ManagerGameweek> ManagerGameweeks {get;set;}
    }
}