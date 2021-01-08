using System;
using System.Collections.Generic;

namespace FPL_Forecaster.Models
{
    public class Stat
    {
        public string identifier { get; set; } 
        public List<Team> a { get; set; } 
        public List<Team> h { get; set; } 
    }
}