#pragma checksum "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bc92336ae52bde906a7dac98dd52b013c7e9501"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Page_TeamPicks), @"mvc.1.0.view", @"/Views/Page/TeamPicks.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bc92336ae52bde906a7dac98dd52b013c7e9501", @"/Views/Page/TeamPicks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f06dab59e6d8f79a9e5a08f407c770212dd7923c", @"/Views/_ViewImports.cshtml")]
    public class Views_Page_TeamPicks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int?>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Page", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TeamPicks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-weeks", "15", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-weeks", "10", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
  
    ViewData["Title"] = "Team Picks";

    string allClass = Model != null && Model.Value != 10 && Model.Value != 15 ? "nav-link active" : "nav-link";
    string fifteenClass = Model != null && Model.Value == 15 ? "nav-link active" : "nav-link";
    string tenClass = Model != null && Model.Value == 10 ? "nav-link active" : "nav-link";

    string allStyle = Model != null && Model.Value != 10 && Model.Value != 15 ? "background-color: #05386B;" : "color: #05386B;";
    string fifteenStyle = Model != null && Model.Value == 15 ? "background-color: #05386B;" : "color: #05386B;";
    string tenStyle = Model != null && Model.Value == 10 ? "background-color: #05386B;" : "color: #05386B;";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bc92336ae52bde906a7dac98dd52b013c7e95015889", async() => {
                WriteLiteral("  \n    <meta name=\"viewport\" content=\"width=device-width\" />  \n    <title></title>  \n");
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
            WriteLiteral(" \n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bc92336ae52bde906a7dac98dd52b013c7e95016928", async() => {
                WriteLiteral("\n    <nav class=\"nav nav-pills nav-justified\">\n        <li class=\"nav-item\">\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bc92336ae52bde906a7dac98dd52b013c7e95017276", async() => {
                    WriteLiteral("All Gameweeks");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 21 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
AddHtmlAttributeValue("", 971, allClass, 971, 9, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "style", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 21 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
AddHtmlAttributeValue("", 987, allStyle, 987, 9, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-weeks", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
                                                                                                 WriteLiteral(DataService.Data.CurrentGameweek);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["weeks"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-weeks", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["weeks"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        </li>\n        <li class=\"nav-item\">\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bc92336ae52bde906a7dac98dd52b013c7e950110743", async() => {
                    WriteLiteral("Last 15 Gameweeks");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 24 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
AddHtmlAttributeValue("", 1177, fifteenClass, 1177, 13, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "style", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 24 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
AddHtmlAttributeValue("", 1197, fifteenStyle, 1197, 13, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-weeks", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["weeks"] = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        </li>\n        <li class=\"nav-item\">\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bc92336ae52bde906a7dac98dd52b013c7e950113666", async() => {
                    WriteLiteral("Last 10 Gameweeks");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 27 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
AddHtmlAttributeValue("", 1364, tenClass, 1364, 9, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "style", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 27 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
AddHtmlAttributeValue("", 1380, tenStyle, 1380, 9, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-weeks", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["weeks"] = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        </li>\n    </nav>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n&nbsp;&nbsp;&nbsp;\n\n");
#nullable restore
#line 33 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
 if (DataService.AITeamChosen)
{
    var gameweekValues = Enumerable.Range(1, DataService.Data?.CurrentGameweek.Value ?? 1).ToList();
    if (Model != null) gameweekValues = gameweekValues.TakeLast(Model.Value).ToList();
    var gameweekValuesJson = Newtonsoft.Json.JsonConvert.SerializeObject(gameweekValues);
    
    //non-bench points values
    var managerGameweekValues = DataService.Controller.ManagerClient.GetManagerGameweeksData(5884469).Result.OrderBy(x => x.number).Select(x => x.points).ToList();
    if (Model != null) managerGameweekValues = managerGameweekValues.TakeLast(Model.Value).ToList();
    while (managerGameweekValues.Count != gameweekValues.Count) managerGameweekValues.Insert(0,0);
    var managerGameweekValuesJson = Newtonsoft.Json.JsonConvert.SerializeObject(managerGameweekValues);

    //total values
    var managerGameweekTotalValues = DataService.Controller.ManagerClient.GetManagerGameweeksData(5884469).Result.OrderBy(x => x.number).Select(x => x.points + x.points_on_bench).ToList();
    if (Model != null) managerGameweekTotalValues = managerGameweekTotalValues.TakeLast(Model.Value).ToList();
    while (managerGameweekTotalValues.Count != gameweekValues.Count) managerGameweekTotalValues.Insert(0,0);
    var managerGameweekTotalValuesJson = Newtonsoft.Json.JsonConvert.SerializeObject(managerGameweekTotalValues);
    
    var gameweekPointsTotalValues = new List<int>();
    foreach (int gameweek in gameweekValues)
    {
        gameweekPointsTotalValues.Add(DataService.Data.AITeam.Sum(x => x.playerDetails.pastFixtures.Where(y => DataService.Data.Fixtures.Where(f => f.id == y.fixture).FirstOrDefault().number == gameweek).FirstOrDefault()?.total_points.Value ?? 0));
    }

    var gameweekPointsValues = gameweekPointsTotalValues.Select(x => (double)x*11/15).ToList();
    var gameweekPointsTotalValuesJson = Newtonsoft.Json.JsonConvert.SerializeObject(gameweekPointsTotalValues); 
    var gameweekPointsValuesJson = Newtonsoft.Json.JsonConvert.SerializeObject(gameweekPointsValues);

    var totalSquadCost = (double)(DataService.Data.AITeam.Sum(x=>x.now_cost))/10;


#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bc92336ae52bde906a7dac98dd52b013c7e950120420", async() => {
                WriteLiteral("\n        <h4 class=\"text-center\">Total Squad Cost: £");
#nullable restore
#line 64 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
                                              Write(totalSquadCost);

#line default
#line hidden
#nullable disable
                WriteLiteral(" M</h4>\n        <hr/>\n\n");
#nullable restore
#line 67 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
         foreach(var positions in DataService.Data.AITeam.GroupBy(x => x.element_type).Reverse().ToList())
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <h5 class=\"text-center\">");
#nullable restore
#line 69 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
                               Write(DataService.Enumerators.PlayerTypes.Where(x => x.id == positions.FirstOrDefault()?.element_type)?.FirstOrDefault()?.plural_name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\n            <div class=\"row justify-content-md-center\">\n");
#nullable restore
#line 71 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
                 foreach(Player player in positions)
                {
                    var playerPhotoUrl = $"https://resources.premierleague.com/premierleague/photos/players/110x140/p{player.code}.png";

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div class=""card text-center border-dark"" style=""width: 10rem;margin:10px"">
                        <div class=""card-header"" style=""background-color: #05386B;"">
                            <p class=""card-text"" ><small class=""text-white"">");
#nullable restore
#line 76 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
                                                                       Write(DataService.Data.Teams.Where(x => x.id == player.team).FirstOrDefault()?.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small></p>\n                        </div>\n                        <img class=\"card-img-top\"");
                BeginWriteAttribute("src", " src=\"", 4727, "\"", 4748, 1);
#nullable restore
#line 78 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
WriteAttributeValue("", 4733, playerPhotoUrl, 4733, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 4749, "\"", 4755, 0);
                EndWriteAttribute();
                WriteLiteral(" style=\"background-color: #EDF5E1;\">\n                        <div class=\"card-body text-white\" style=\"background-color: rgba(5, 56, 107, 0.4);\">\n                            <h6 class=\"card-title\" style=\"margin-bottom: 0;\">");
#nullable restore
#line 80 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
                                                                        Write(player.web_name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>       \n");
                WriteLiteral("                        </div>\n                    </div>\n                    <p></p>\n");
#nullable restore
#line 85 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\n");
#nullable restore
#line 87 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    \n        <hr/>\n        ");
#nullable restore
#line 90 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
   Write(await Html.PartialAsync("/Views/Charts/_LineChart2.cshtml", new FPLForecaster.Models.LineChartData(){
            chartId = "aiTotalPointsChart",
            chartTitle = "Gameweek Total Points for AI Team Picks",
            xValuesJson = gameweekValuesJson,
            yValuesJson = gameweekPointsTotalValuesJson,
            yValuesJson2 = managerGameweekTotalValuesJson,
            xLabel = "Gameweek",
            yLabel = "Points",
            hoverLabel = "Points: ",
            hoverLabelBefore = false,
            hoverTitle = "Gameweek ",
            hoverTitleBefore = true,
            height_pixels = "500"
        }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        &nbsp;\n        <p class=\"text-center\">AI Team Total Points: ");
#nullable restore
#line 105 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
                                                Write(gameweekPointsTotalValues.Sum());

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n        <p class=\"text-center\">Manager Team Total Points: ");
#nullable restore
#line 106 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
                                                     Write(managerGameweekTotalValues.Sum());

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n");
#nullable restore
#line 107 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
          var percentageImprovementTotal = FPLForecaster.Analysis.StatisticCalculator.PercentChange(managerGameweekTotalValues.Sum().Value, gameweekPointsTotalValues.Sum());

#line default
#line hidden
#nullable disable
                WriteLiteral("        <p class=\"text-center\">AI Team Improvement in Comparison to Manager Team: ");
#nullable restore
#line 108 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
                                                                             Write(percentageImprovementTotal);

#line default
#line hidden
#nullable disable
                WriteLiteral(" %</p>   \n        <hr/>\n        ");
#nullable restore
#line 110 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
   Write(await Html.PartialAsync("/Views/Charts/_LineChart2.cshtml", new FPLForecaster.Models.LineChartData(){
            chartId = "aiPointsChart",
            chartTitle = "Gameweek Points (Non-Bench Points) for AI Team Picks",
            xValuesJson = gameweekValuesJson,
            yValuesJson = gameweekPointsValuesJson,
            yValuesJson2 = managerGameweekValuesJson,
            xLabel = "Gameweek",
            yLabel = "Points",
            hoverLabel = "Points: ",
            hoverLabelBefore = false,
            hoverTitle = "Gameweek ",
            hoverTitleBefore = true,
            height_pixels = "500"
        }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        &nbsp;\n        <p class=\"text-center\">AI Team Total Points: ");
#nullable restore
#line 125 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
                                                Write(Math.Round(gameweekPointsValues.Sum(),2,MidpointRounding.AwayFromZero));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n        <p class=\"text-center\">Manager Team Total Points: ");
#nullable restore
#line 126 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
                                                     Write(managerGameweekValues.Sum());

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n");
#nullable restore
#line 127 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
          var percentageImprovement = FPLForecaster.Analysis.StatisticCalculator.PercentChange(managerGameweekValues.Sum().Value, gameweekPointsValues.Sum());

#line default
#line hidden
#nullable disable
                WriteLiteral("        <p class=\"text-center\">AI Team Improvement in Comparison to Manager Team: ");
#nullable restore
#line 128 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
                                                                             Write(percentageImprovement);

#line default
#line hidden
#nullable disable
                WriteLiteral(" %</p>   \n    ");
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
            WriteLiteral("\n");
#nullable restore
#line 130 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int?> Html { get; private set; }
    }
}
#pragma warning restore 1591
