using FPL_Forecaster.Models;
using System.Collections.Generic;

namespace FPL_Forecaster
{
    public static class DataService
    {
        public static DataBank Data = new DataBank();
        public static bool HasData {get => Data.Fixtures != null && Data.Players != null && Data.Teams != null;}
    }
}