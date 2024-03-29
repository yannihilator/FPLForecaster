#pragma checksum "/Users/yanni/Documents/Repos/FPLForecaster/Views/Charts/_LineChart2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae20606dd6a5dced6672a95fe7ade474f4ff8ee6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Charts__LineChart2), @"mvc.1.0.view", @"/Views/Charts/_LineChart2.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae20606dd6a5dced6672a95fe7ade474f4ff8ee6", @"/Views/Charts/_LineChart2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f06dab59e6d8f79a9e5a08f407c770212dd7923c", @"/Views/_ViewImports.cshtml")]
    public class Views_Charts__LineChart2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FPLForecaster.Models.LineChartData>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"box-body\" style=\"margin-bottom:50px\">  \n    <div class=\"chart-container\">  \n        <canvas");
            BeginWriteAttribute("id", " id=\"", 147, "\"", 166, 1);
#nullable restore
#line 5 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Charts/_LineChart2.cshtml"
WriteAttributeValue("", 152, Model.chartId, 152, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 167, "\"", 217, 4);
            WriteAttributeValue("", 175, "width:100%;", 175, 11, true);
            WriteAttributeValue(" ", 186, "height:", 187, 8, true);
#nullable restore
#line 5 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Charts/_LineChart2.cshtml"
WriteAttributeValue("", 194, Model.height_pixels, 194, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 214, "px", 215, 3, true);
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
#line 15 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Charts/_LineChart2.cshtml"
                        Write(Model.chartId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';  \n            var ctx = document.getElementById(chartName).getContext(\'2d\');  \n            var data = {  \n                    labels: ");
#nullable restore
#line 18 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Charts/_LineChart2.cshtml"
                       Write(Html.Raw(Model.xValuesJson));

#line default
#line hidden
#nullable disable
            WriteLiteral(@",  
                    datasets: [{  
                        backgroundColor: [ 
                            'rgba(5, 56, 107, 0.4)', 
                            'rgba(92, 219, 149, 0.4)'   
                        ],  
                        borderColor: [ 
                            'rgba(5, 56, 107, 1)', 
                            'rgba(92, 219, 149, 1)'
                        ],  
                        borderWidth: 2,  
                        pointHoverBackgroundColor: 'rgba(92, 219, 149, 1)',
                        pointHoverBorderColor: 'rgba(5, 56, 107, 1)',
                        data: ");
#nullable restore
#line 31 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Charts/_LineChart2.cshtml"
                         Write(Html.Raw(Model.yValuesJson));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  
                    },
                    {
                        backgroundColor: [ 
                            'rgba(92, 219, 149, 0.4)'   
                        ],  
                        borderColor: [ 
                            'rgba(92, 219, 149, 1)'
                        ],  
                        borderWidth: 2,  
                        pointHoverBackgroundColor: 'rgba(5, 56, 107, 1)',
                        pointHoverBorderColor: 'rgba(92, 219, 149, 1)',
                        data: ");
#nullable restore
#line 43 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Charts/_LineChart2.cshtml"
                         Write(Html.Raw(Model.yValuesJson2));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n                    }]  \n            \n        };  \n\n        var options = {  \n            maintainAspectRatio: false, \n            title: {\n                display: true,\n                fontSize: 18,\n                text: \'");
#nullable restore
#line 53 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Charts/_LineChart2.cshtml"
                  Write(Model.chartTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'
            }, 
            tooltips:{
                callbacks:{
                    label: function(tooltipItem, data){
                        var value = data['datasets'][tooltipItem.datasetIndex]['data'][tooltipItem['index']];
                        return '");
#nullable restore
#line 59 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Charts/_LineChart2.cshtml"
                           Write(Model.hoverLabel);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' + value;\n                    },\n                    title: function(tooltipItem, data){\n                        var value = data[\'labels\'][tooltipItem[0][\'index\']];\n                        return \'");
#nullable restore
#line 63 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Charts/_LineChart2.cshtml"
                           Write(Model.hoverTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + value;
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
#line 79 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Charts/_LineChart2.cshtml"
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
#line 93 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Charts/_LineChart2.cshtml"
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
                type:'line'  
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FPLForecaster.Models.LineChartData> Html { get; private set; }
    }
}
#pragma warning restore 1591
