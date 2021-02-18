using FPLForecaster.Models;
using System.Collections.Generic;
using FPLForecaster.Controllers;
using FPLForecaster.Analysis;

namespace FPLForecaster
{
    public static class DataService
    {
        public static DataController Controller = new DataController();
        public static TeamPicker TeamPicker = new TeamPicker();
        public static DataBank Data = new DataBank();
        public static Enumerators Enumerators = new Enumerators();
        public static bool HasGeneralData {get => Data.Fixtures != null && Data.Players != null && Data.Teams != null;}
        public static bool AITeamChosen {get => Data.AITeam != null && Data.AITeam.Count == 15;}
        public static bool HasManagerData {get => Data.ManagerData != null && Data.ManagerData.ManagerInformation != null &&
            Data.ManagerData.ManagerGameweeks != null &&  Data.ManagerData.ManagerGameweeks.Count > 0;}
    }
}