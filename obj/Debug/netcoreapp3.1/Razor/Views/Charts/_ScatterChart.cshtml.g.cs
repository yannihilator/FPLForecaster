#pragma checksum "/Users/yanni/Documents/Repos/FPLForecaster/Views/Charts/_ScatterChart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5dcb2fba794b6c20ee4eb2cb42206c2437154e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Charts__ScatterChart), @"mvc.1.0.view", @"/Views/Charts/_ScatterChart.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/yanni/Documents/Repos/FPLForecaster/Views/_ViewImports.cshtml"
using FPLForecaster;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/yanni/Documents/Repos/FPLForecaster/Views/_ViewImports.cshtml"
using FPLForecaster.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5dcb2fba794b6c20ee4eb2cb42206c2437154e2", @"/Views/Charts/_ScatterChart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f06dab59e6d8f79a9e5a08f407c770212dd7923c", @"/Views/_ViewImports.cshtml")]
    public class Views_Charts__ScatterChart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FPLForecaster.Models.ScatterChartData>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"box-body\" style=\"margin-bottom:50px\">  \n    <div class=\"chart-container\">  \n        <canvas");
            BeginWriteAttribute("id", " id=\"", 150, "\"", 169, 1);
#nullable restore
#line 5 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Charts/_ScatterChart.cshtml"
WriteAttributeValue("", 155, Model.chartId, 155, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 170, "\"", 220, 4);
            WriteAttributeValue("", 178, "width:100%;", 178, 11, true);
            WriteAttributeValue(" ", 189, "height:", 190, 8, true);
#nullable restore
#line 5 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Charts/_ScatterChart.cshtml"
WriteAttributeValue("", 197, Model.height_pixels, 197, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 217, "px", 218, 3, true);
            EndWriteAttribute();
            WriteLiteral(@"></canvas>  
    </div>  
</div> 

<script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.7.2/Chart.bundle.min.js""></script>  
<script src=""https://code.jquery.com/jquery-3.3.1.min.js""></script>  

<script type=""text/javascript"">  
        Chart.defaults.global.legend.display = false;
        $(function () {        
            var chartName = '");
#nullable restore
#line 15 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Charts/_ScatterChart.cshtml"
                        Write(Model.chartId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';  
            var ctx = document.getElementById(chartName).getContext('2d');  
            var data = {  
                    labels: 'test',  
                    datasets: [{
                        backgroundColor: [ 
                            'rgba(5, 56, 107, 0.4)', 
                            'rgba(92, 219, 149, 0.4)'   
                        ],  
                        borderColor: [ 
                            'rgba(5, 56, 107, 1)', 
                            'rgba(92, 219, 149, 1)'
                        ],  
                        borderWidth: 1, 
                        pointHoverBackgroundColor: 'rgba(92, 219, 149, 1)',
                        pointHoverBorderColor: 'rgba(5, 56, 107, 1)',
                        data: ");
#nullable restore
#line 31 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Charts/_ScatterChart.cshtml"
                         Write(Html.Raw(Model.dataJson));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \n                    }]         \n        };  \n\n        var options = {  \n            maintainAspectRatio: false, \n            title: {\n                display: true,\n                fontSize: 18,\n                text: \'");
#nullable restore
#line 40 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Charts/_ScatterChart.cshtml"
                  Write(Model.chartTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'
            }, 
            tooltips:{
                callbacks:{
                    title: function(tooltipItem, all) {
                        return [
                            all.datasets[tooltipItem[0].datasetIndex].data[tooltipItem[0].index].name,
                        ]
                    },
                    label: function(tooltipItem, all) {
                        return [
                            '");
#nullable restore
#line 51 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Charts/_ScatterChart.cshtml"
                        Write(Model.xLabel);

#line default
#line hidden
#nullable disable
            WriteLiteral(": \' + tooltipItem.xLabel.toLocaleString(),\n                            \'");
#nullable restore
#line 52 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Charts/_ScatterChart.cshtml"
                        Write(Model.yLabel);

#line default
#line hidden
#nullable disable
            WriteLiteral(@": ' + tooltipItem.yLabel.toLocaleString()
                        ]
                    }
                }
            },
            scales: {  
                yAxes: [{  
                    ticks: {  
                        min: 0,  
                        beginAtZero: true  
                    },  
                    gridLines: {  
                        display: true
                    },
                    scaleLabel: {
                        display: true,
                        fontSize: 14,
                        labelString: '");
#nullable restore
#line 69 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Charts/_ScatterChart.cshtml"
                                 Write(Model.yLabel);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'
                    } 
                }],  
                xAxes: [{  
                    ticks: {  
                        min: 0,  
                        beginAtZero: true 
                    },  
                    gridLines: {  
                        display: true  
                    },
                    scaleLabel: {
                        display: true,
                        fontSize: 14,
                        labelString: '");
#nullable restore
#line 83 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Charts/_ScatterChart.cshtml"
                                 Write(Model.xLabel);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'
                    }  
                }]  
            }  
        };  

        var myChart = new  Chart(ctx, {  
                options: options,  
                data: data,  
                type:'scatter'  
            });  
        }); 
</script>  ");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FPLForecaster.Models.ScatterChartData> Html { get; private set; }
    }
}
#pragma warning restore 1591
