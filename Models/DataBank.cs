using System;
using System.Collections.Generic;

namespace FPLForecaster.Models
{
    public class DataBank
    {
        public ICollection<Fixture> Fixtures {get;set;}
        public ICollection<Player> Players {get;set;}
        public ICollection<Team> Teams {get;set;}
        public ICollection<ManagerGameweek> ManagerData {get;set;}
    }
}