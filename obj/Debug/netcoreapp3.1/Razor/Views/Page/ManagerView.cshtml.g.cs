#pragma checksum "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04542ba8008072f3bd6ae38c670bcb0945d4b9a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Page_ManagerView), @"mvc.1.0.view", @"/Views/Page/ManagerView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04542ba8008072f3bd6ae38c670bcb0945d4b9a2", @"/Views/Page/ManagerView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f06dab59e6d8f79a9e5a08f407c770212dd7923c", @"/Views/_ViewImports.cshtml")]
    public class Views_Page_ManagerView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Page", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ManagerView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml"
  
    ViewData["Title"] = "Manager View";
    var manData = DataService.Data.ManagerData;
    var XLabels = manData?.ManagerGameweeks != null && manData?.ManagerGameweeks.Count > 0 ? 
                    Newtonsoft.Json.JsonConvert.SerializeObject(manData.ManagerGameweeks.OrderBy(x => x.number).Select(y => y.number).ToList()) : null;
    var YValues = manData?.ManagerGameweeks != null && manData?.ManagerGameweeks.Count > 0 ? 
                    Newtonsoft.Json.JsonConvert.SerializeObject(manData.ManagerGameweeks.OrderBy(x => x.number).Select(y => y.points).ToList()) : null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>  \r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04542ba8008072f3bd6ae38c670bcb0945d4b9a25444", async() => {
                WriteLiteral("  \r\n    <meta name=\"viewport\" content=\"width=device-width\" />  \r\n    <title></title>  \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("  \r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04542ba8008072f3bd6ae38c670bcb0945d4b9a26492", async() => {
                WriteLiteral("  \r\n    <div class=\"text-center\">\r\n");
#nullable restore
#line 17 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml"
         if (DataService.HasManagerData)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <h1 class=\"display-4\">Welcome <span style=\"color: #05386B;\"><b>");
#nullable restore
#line 19 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml"
                                                                      Write(manData.ManagerInformation.player_first_name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 19 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml"
                                                                                                                    Write(manData.ManagerInformation.player_last_name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></span></h1>\r\n            <p>Please insert a different manager ID to view their data.</p>\r\n");
#nullable restore
#line 21 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml"
        }
        else 
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <h1 class=\"display-4\">Welcome</h1>\r\n            <p>Please insert your manager ID to view your data.</p>\r\n");
#nullable restore
#line 26 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04542ba8008072f3bd6ae38c670bcb0945d4b9a28401", async() => {
                    WriteLiteral(@"
            Manager ID: <input type=""text"" width=""10"" name=""manager_id"" id=""manager_id""/>
            &nbsp;&nbsp;
            <input type=""submit"" value=""Get Data"" style=""background-color: #05386B; color: white; border-radius: 5px;""></>
            <hr/>
");
#nullable restore
#line 33 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml"
             if (DataService.HasManagerData)
            {
                

#line default
#line hidden
#nullable disable
                    WriteLiteral("                <p>Team Name: <b>");
#nullable restore
#line 36 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml"
                            Write(manData.ManagerInformation.name);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</b></p>\r\n                <small class=\"text-muted\">Joined: ");
#nullable restore
#line 37 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml"
                                             Write(manData.ManagerInformation.joined_time.ToShortDateString());

#line default
#line hidden
#nullable disable
                    WriteLiteral("</small>\r\n                <hr/>\r\n");
#nullable restore
#line 39 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml"
            }

#line default
#line hidden
#nullable disable
                    WriteLiteral("        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" \r\n    </div>\r\n\r\n    <div class=\"box-body\">  \r\n  \r\n        <div class=\"chart-container\">  \r\n            <canvas id=\"chart\" style=\"width:100%; height:500px\"></canvas>  \r\n        </div>  \r\n    </div>  \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"  
</html> 

<script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.7.2/Chart.bundle.min.js""></script>  
<script src=""https://code.jquery.com/jquery-3.3.1.min.js""></script>  
  
<script type=""text/javascript"">  
        $(function () {  
          
                var chartName = ""chart"";  
                var ctx = document.getElementById(chartName).getContext('2d');  
                var data = {  
                        labels: ");
#nullable restore
#line 61 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml"
                           Write(Html.Raw(XLabels));

#line default
#line hidden
#nullable disable
            WriteLiteral(@",  
                        datasets: [{  
                            //label: ""Departments Chart"",  
                            backgroundColor: [  
                                'rgba(255, 99, 132, 0.2)',  
                                'rgba(54, 162, 235, 0.2)',  
                                'rgba(255, 206, 86, 0.2)',  
                                'rgba(75, 192, 192, 0.2)',  
                                'rgba(153, 102, 255, 0.2)',  
                                'rgba(255, 159, 64, 0.2)',  
                                'rgba(255, 0, 0)',  
                                'rgba(0, 255, 0)',  
                                'rgba(0, 0, 255)',  
                                'rgba(192, 192, 192)',  
                                'rgba(255, 255, 0)',  
                                'rgba(255, 0, 255)'  
                            ],  
                            borderColor: [  
                                'rgba(255,99,132,1)',  
                           ");
            WriteLiteral(@"     'rgba(54, 162, 235, 1)',  
                                'rgba(255, 206, 86, 1)',  
                                'rgba(75, 192, 192, 1)',  
                                'rgba(153, 102, 255, 1)',  
                                'rgba(255, 159, 64, 1)',  
                                'rgba(255, 0, 0)',  
                                'rgba(0, 255, 0)',  
                                'rgba(0, 0, 255)',  
                                'rgba(192, 192, 192)',  
                                'rgba(255, 255, 0)',  
                                'rgba(255, 0, 255)'  
                            ],  
                            borderWidth: 1,  
                            data: ");
#nullable restore
#line 93 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml"
                             Write(Html.Raw(YValues));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  
                        }]  
            
        };  
  
        var options = {  
            maintainAspectRatio: false,  
            scales: {  
                yAxes: [{  
                    ticks: {  
                        min: 0,  
                        beginAtZero: true  
                    },  
                    gridLines: {  
                        display: true,  
                        color: ""rgba(255,99,164,0.2)""  
                    }  
            }],  
                xAxes: [{  
                    ticks: {  
                        min: 0,  
                        beginAtZero: false 
                    },  
                    gridLines: {  
                        display: true  
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
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
