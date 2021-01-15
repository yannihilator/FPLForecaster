#pragma checksum "/Users/yanni/Documents/Repos/FPLForecaster/Views/Charts/_BarChart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a6cd68cf0cbc8c03db9b3cee39653d981278a7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Charts__BarChart), @"mvc.1.0.view", @"/Views/Charts/_BarChart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a6cd68cf0cbc8c03db9b3cee39653d981278a7e", @"/Views/Charts/_BarChart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f06dab59e6d8f79a9e5a08f407c770212dd7923c", @"/Views/_ViewImports.cshtml")]
    public class Views_Charts__BarChart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FPLForecaster.Models.BarChartData>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"box-body\" style=\"margin-bottom:50px\">  \n    <div class=\"chart-container\">  \n        <canvas");
            BeginWriteAttribute("id", " id=\"", 146, "\"", 165, 1);
#nullable restore
#line 5 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Charts/_BarChart.cshtml"
WriteAttributeValue("", 151, Model.chartId, 151, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""width:100%; height:500px""></canvas>  
    </div>  
</div> 

<script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.7.2/Chart.bundle.min.js""></script>  
<script src=""https://code.jquery.com/jquery-3.3.1.min.js""></script>  

<script type=""text/javascript"">  
        Chart.defaults.global.legend.display = true;
        $(function () {        
            var chartName = '");
#nullable restore
#line 15 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Charts/_BarChart.cshtml"
                        Write(Model.chartId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';  \n            var ctx = document.getElementById(chartName).getContext(\'2d\');  \n            var dataset_1 = {\n                    label: \'");
#nullable restore
#line 18 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Charts/_BarChart.cshtml"
                       Write(Model.yLabel_1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\n                    data: ");
#nullable restore
#line 19 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Charts/_BarChart.cshtml"
                     Write(Html.Raw(Model.yValuesJson_1));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\n                        backgroundColor: \'rgba(5, 56, 107, 0.6)\',  \n                        borderColor: \'rgba(5, 56, 107, 1)\', \n                    borderWidth: 2\n            }\n            var dataset_2 = {\n                    label: \'");
#nullable restore
#line 25 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Charts/_BarChart.cshtml"
                       Write(Model.yLabel_2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\n                    data: ");
#nullable restore
#line 26 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Charts/_BarChart.cshtml"
                     Write(Html.Raw(Model.yValuesJson_2));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\n                        backgroundColor: \'rgba(92, 219, 149, 0.6)\',  \n                        borderColor: \'rgba(92, 219, 149, 1)\', \n                    borderWidth: 2\n            }\n            \n            var data = {  \n                    labels: ");
#nullable restore
#line 33 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Charts/_BarChart.cshtml"
                       Write(Html.Raw(Model.xLabelsJson));

#line default
#line hidden
#nullable disable
            WriteLiteral(@",  
                    datasets: [dataset_1, dataset_2]         
             };  

        var options = {  
            maintainAspectRatio: false, 
            title: {
                display: true,
                fontSize: 18,
                text: '");
#nullable restore
#line 42 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Charts/_BarChart.cshtml"
                  Write(Model.chartTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'
            },
            scales: {    
                xAxes: [{  
                    barPercentage: 0.9,
                    categoryPercentage: 0.8
                }]  
            }  
        };  

        var myChart = new  Chart(ctx, {  
                options: options,  
                data: data,  
                type:'bar'  
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FPLForecaster.Models.BarChartData> Html { get; private set; }
    }
}
#pragma warning restore 1591
