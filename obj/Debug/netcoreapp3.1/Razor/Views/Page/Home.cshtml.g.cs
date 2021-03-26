#pragma checksum "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cadf5480af878acbe78b08de6dc587ed8b5a3bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Page_Home), @"mvc.1.0.view", @"/Views/Page/Home.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cadf5480af878acbe78b08de6dc587ed8b5a3bf", @"/Views/Page/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f06dab59e6d8f79a9e5a08f407c770212dd7923c", @"/Views/_ViewImports.cshtml")]
    public class Views_Page_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/Home.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1cadf5480af878acbe78b08de6dc587ed8b5a3bf3153", async() => {
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
            WriteLiteral(@" 
<div class=""container"">
    <section id=""introSection"">
        <div style=""height: 100vh;"">
            <div class=""text-center"" style=""height: 30%;"">
                <h1 class=""display-4"">Welcome</h1>
                <h3 class=""lead""><small class=""text-muted"">to</small></h3>
                <h1 class=""lead"" style=""font-size: x-large;"">Fantasy Premier League Forecaster</h2>
                <hr/>
            </div>
            <div class=""box"" style=""height: 30%;"">
                <blockquote class=""blockquote"" style=""text-align: center;"">
                    <p class=""mb-0"">I never guess. It is a capital mistake to theorize before one has data. Insensibly one begins to twist facts to suit theories, instead of theories to suit facts.</p>
                    <footer class=""blockquote-footer"">Sir Arthur Conan Doyle</footer>
                </blockquote>
            </div>
            <div class=""row justify-content-md-center"" style=""height: 30%;"">
                <svg onclick=""scrollToMain()"" style=""cursor: p");
            WriteLiteral(@"ointer;"" xmlns=""http://www.w3.org/2000/svg"" width=""30"" height=""30"" fill=""currentColor"" class=""bi bi-chevron-down"" viewBox=""0 0 16 16"">
                    <path fill-rule=""evenodd"" d=""M1.646 4.646a.5.5 0 0 1 .708 0L8 10.293l5.646-5.647a.5.5 0 0 1 .708.708l-6 6a.5.5 0 0 1-.708 0l-6-6a.5.5 0 0 1 0-.708z""/>
                </svg>
            </div>
        </div>
    </section>
    <section id=""infoSection"">
        <br>
        <br>
        <h4>Purpose</h4>
        <p>
            The main purpose of this application is to extract, analyze, and present <a href=""https://fantasy.premierleague.com/"" target=""_blank"" rel=""noopener noreferrer"">Fantasy Premier League</a> 
            data in order to assist Fantasy Premier League players in making selections for their teams. Additionally, it serves as an educational introduction to 
            web development and the ASP.NET Core framework for myself. As my skills in web development, knowledge of the framework and data analysis improve, I will return to 
            ");
            WriteLiteral(@"this project and optimize the code and to incorporate best practices. 
        </p>
        <h4>What is Fantasy Premier League?</h4>
        <p>
            Fantasy Premier League (FPL) is an online game that puts each player in the role of a manager for every Premier League season. With a given budget, each player
            has to choose a team of real-life players in the Premier League and receives points every gameweek based on their selected team's performance in real life. The player can join 
            leagues that pits them against other players in terms of total points, or different head-to-head matchups every gameweek, resulting in a conventional league table. 
        </p>
        <h4>Fantasy Premier League Rules for Choosing a Team</h4>
        <p>
            Each manager must choose a team of Premier League players with a £100.0M budget. Every Premier League player is assigned a monetary value (in the £M vicinity), thus 
            making the task of choosing a squad a trade-off between cost");
            WriteLiteral(@" and return in total points. The manager is required to choose 15 players according to the following positions:
            <ul style=""margin: 20px;"">
                <li>2 Goalkeepers</li>
                <li>5 Defenders</li>
                <li>5 Midfielders</li>
                <li>3 Forwards</li>
            </ul>
            Premier League players return fantasy points during games, and specific events yield different rewards depending on the player's position. Below is a cross reference matrix 
            with significant events that can occur during a game and their fantasy point return value based on player position:
            <style>
                td{border: 1px solid black; padding: 0 10px 0 10px; text-align: center;}
                th{border: 1px solid black; padding: 0 10px 0 10px; text-align: center; background-color: #5CDB95;}
            </style>
            <table style=""margin: 20px;"" class=""row justify-content-md-center"">
                <tr>
                    <th scope=""col"" style=""");
            WriteLiteral(@"border-bottom: 3px solid black;"">Event</th>
                    <th scope=""col"">Goalkeeper</th>
                    <th scope=""col"">Defender</th>
                    <th scope=""col"">Midfielder</th>
                    <th scope=""col"">Forward</th>
                </tr>
                <tr>
                    <th scope=""row"">Playing LESS than 60 minutes</th>
                    <td>1 point</td>
                    <td>1 point</td>
                    <td>1 point</td>
                    <td>1 point</td>
                </tr>
                <tr>
                    <th scope=""row"">Playing MORE than 60 minutes</th>
                    <td>2 points</td>
                    <td>2 points</td>
                    <td>2 points</td>
                    <td>2 points</td>
                </tr>
                <tr>
                    <th scope=""row"">Goal</th>
                    <td>6 points</td>
                    <td>6 points</td>
                    <td>5 points</td>
                    <td>4 points</td>
          ");
            WriteLiteral(@"      </tr>
                <tr>
                    <th scope=""row"">Assist</th>
                    <td>3 points</td>
                    <td>3 points</td>
                    <td>3 points</td>
                    <td>3 points</td>
                </tr>
                <tr>
                    <th scope=""row"">Clean Sheet</th>
                    <td>4 points</td>
                    <td>4 points</td>
                    <td>1 point</td>
                    <td>0 points</td>
                </tr>
                <tr>
                    <th scope=""row"">Yellow Card</th>
                    <td>-1 point</td>
                    <td>-1 point</td>
                    <td>-1 point</td>
                    <td>-1 point</td>
                </tr>
                    <tr>
                    <th scope=""row"">Red Card</th>
                    <td>-3 points</td>
                    <td>-3 points</td>
                    <td>-3 points</td>
                    <td>-3 points</td>
                </tr>
            </table>
");
            WriteLiteral(@"
            These are just the rules that are important to the scope of this application. For a more thorough explanation, please visit FPL's official rules page 
            <a href=""https://fantasy.premierleague.com/help/rules"" target=""_blank"" rel=""noopener noreferrer"">here</a>.
        </p>
        <h4>How the Application Works</h4>
        <p>
            The FPL website has a public application programming interface (API) that anyone can access to retrieve data. Through multiple endpoints, detailed data is available
            for the current season, and basic information is made available for past seasons. On startup, the application utilizes custom clients to retrieve data through the API
            and store it in the application's memory, thus making it easily accessible for data visualization and analysis during the instance of the application. With the current 
            season's data, analysis is conducted to choose the best FPL team and present visuals of the data for teams, players, and FPL");
            WriteLiteral(@" managers.
        </p>
        <h4>Frameworks and Libraries Used</h4>
        <ul style=""margin-bottom: 60px;"">
            <li>ASP.NET Core</li>
            <li>Chart.js</li>
            <li>Newtonsoft</li>
            <li>Bootstrap 4.3.1</li>
        </ul>
    </section>
</div>    
<script type=""text/javascript"">
    function scrollToMain()
    {
        document.getElementById('infoSection').scrollIntoView({behavior: ""smooth""});
    }
</script>");
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
