

namespace FPLForecaster.Models
{
    public class LineChartData
    {
        public string chartId {get;set;}
        public string chartTitle {get;set;}
        public string xValuesJson {get;set;}
        public string yValuesJson {get;set;}
        public string xLabel {get;set;}
        public string yLabel {get;set;}
        public string hoverLabel {get;set;}
        public bool hoverLabelBefore {get;set;}
        public string hoverTitle {get;set;}
        public bool hoverTitleBefore {get;set;}
        public string height_pixels {get;set;}
    }
}