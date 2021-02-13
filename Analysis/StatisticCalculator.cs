using System;
using System.Linq;

namespace FPLForecaster.Analysis
{
    public static class StatisticCalculator
    {
        public static double PercentChange(double original, double _new)
        {
            return Math.Round((double)(_new-original)*100/original, 2, MidpointRounding.AwayFromZero);
        }

        public static int Percentage(double numerator, double denominator)
        {
            return Convert.ToInt32(numerator/denominator*100);
        }
    }
}