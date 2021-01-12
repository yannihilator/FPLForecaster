#pragma checksum "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5edb7ac200326b196241e64a2fd0f6c9a1f4ebaa"
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
#nullable restore
#line 6 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml"
using FPLForecaster.Models.Manager;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5edb7ac200326b196241e64a2fd0f6c9a1f4ebaa", @"/Views/Page/ManagerView.cshtml")]
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<script type=\"text/javascript\" src=\"https://www.gstatic.com/charts/loader.js\">\r\n</script> \r\n");
#nullable restore
#line 3 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml"
  
    ViewData["Title"] = "Manager View";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml"
  var manData = DataService.Data.ManagerData;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""gameweekPointsChart""></div>
<script type=""text/javascript"">  

    google.charts.load('current', {  
        packages: ['corechart', 'line']  
    });  
    google.charts.setOnLoadCallback(drawGameweekPointsChart);

    function drawGameweekPointsChart()
    {
        var dataArray = manData.ManagerGameweeks.OrderBy(x => x.number).Select(y => new {y.number, y.points}).ToArray();
        
        var chartData = new google.visualization.DataTable();
        chartData.addColumn('number', 'Gameweek');
        chartData.addColumn('number', 'Points');
        chartData.addRows(dataArray);
        var options = {
            title: ""Gameweek Points for Current Season"",
            pointSize: 5
        }

        var chart = new google.visualization.LineChart(document.getElementById('gameweekPointsChart'));
        chart.draw(chartData, options);
    }
</script>

<div class=""text-center"">
");
#nullable restore
#line 36 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml"
     if (DataService.HasManagerData)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1 class=\"display-4\">Welcome <span style=\"color: #05386B;\"><b>");
#nullable restore
#line 38 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml"
                                                                  Write(manData.ManagerInformation.player_first_name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 38 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml"
                                                                                                                Write(manData.ManagerInformation.player_last_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></span></h1>\r\n        <p>Please insert a different manager ID to view their data.</p>\r\n");
#nullable restore
#line 40 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml"
    }
    else 
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1 class=\"display-4\">Welcome</h1>\r\n        <p>Please insert your manager ID to view your data.</p>\r\n");
#nullable restore
#line 45 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5edb7ac200326b196241e64a2fd0f6c9a1f4ebaa7597", async() => {
                WriteLiteral("\r\n        Manager ID: <input type=\"text\" width=\"10\" name=\"manager_id\" id=\"manager_id\"/>\r\n        &nbsp;&nbsp;\r\n        <input type=\"submit\" value=\"Get Data\" style=\"background-color: #05386B; color: white; border-radius: 5px;\"></>\r\n        <hr/>\r\n");
#nullable restore
#line 52 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml"
     if (DataService.HasManagerData)
    {
        

#line default
#line hidden
#nullable disable
                WriteLiteral("        <p>Team Name: <b>");
#nullable restore
#line 55 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml"
                    Write(manData.ManagerInformation.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></p>\r\n        <small class=\"text-muted\">Joined: ");
#nullable restore
#line 56 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml"
                                     Write(manData.ManagerInformation.joined_time.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</small>\r\n        <hr/>\r\n");
#nullable restore
#line 58 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml"
                               

    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
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
            WriteLiteral(" \r\n</div>\r\n\r\n\r\n");
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
