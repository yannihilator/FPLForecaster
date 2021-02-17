using System;
using System.Collections.Generic;
using FPLForecaster.Models.Manager;

namespace FPLForecaster.Models
{
    public class DataBank
    {
        public ICollection<Fixture> Fixtures {get;set;}
        public ICollection<Player> Players {get;set;}
        public ICollection<Team> Teams {get;set;}
        public ICollection<Player> AITeam {get;set;}
        public ManagerData ManagerData {get;set;}
    }
}