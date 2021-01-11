using FPLForecaster.Models;
using System.Collections.Generic;
using FPLForecaster.Controllers;

namespace FPLForecaster
{
    public static class DataService
    {
        public static DataController Controller = new DataController();
        public static DataBank Data = new DataBank();
        public static Enumerators Enumerators = new Enumerators();
        public static bool HasGeneralData {get => Data.Fixtures != null && Data.Players != null && Data.Teams != null;}
        public static bool HasManagerData {get => Data.ManagerData != null && Data.ManagerData.ManagerInformation != null &&
            Data.ManagerData.ManagerGameweeks != null &&  Data.ManagerData.ManagerGameweeks.Count > 0;}
    }
}