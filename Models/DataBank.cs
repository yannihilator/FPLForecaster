using System;
using System.Collections.Generic;
using FPLForecaster.Models.Manager;
using System.Linq;

namespace FPLForecaster.Models
{
    public class DataBank
    {
        public List<Fixture> Fixtures {get;set;}
        public List<Player> Players {get;set;}
        public List<Team> Teams {get;set;}
        public List<Player> AITeam {get;set;}
        public ManagerData ManagerData {get;set;}
        public int? CurrentGameweek {get => Fixtures?.Where(x => x.finished == true).Select(x => x.number).Max();}
    }
}