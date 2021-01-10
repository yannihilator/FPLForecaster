using FPLForecaster.Models;
using System.Collections.Generic;

namespace FPLForecaster
{
    public static class DataService
    {
        public static DataBank Data = new DataBank();
        public static Enumerators Enumerators = new Enumerators();
        public static bool HasData {get => Data.Fixtures != null && Data.Players != null && Data.Teams != null;}
    }
}