#pragma checksum "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d02f34b4bece82ab1d06f7183589439162e7720e"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d02f34b4bece82ab1d06f7183589439162e7720e", @"/Views/Page/TeamPicks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f06dab59e6d8f79a9e5a08f407c770212dd7923c", @"/Views/_ViewImports.cshtml")]
    public class Views_Page_TeamPicks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
  
    ViewData["Title"] = "Team Picks";

    var chosenTeam = FPLForecaster.Analysis.TeamPicker.AITeam();

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 7 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
 foreach(var positions in chosenTeam.GroupBy(x => x.element_type).Reverse().ToList())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5 class=\"text-center\">");
#nullable restore
#line 9 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
                       Write(DataService.Enumerators.PlayerTypes.Where(x => x.id == positions.FirstOrDefault()?.element_type)?.FirstOrDefault()?.plural_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n    <div class=\"row justify-content-md-center\">\n");
#nullable restore
#line 11 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
         foreach(Player player in positions)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\" style=\"width: 10rem;margin:10px\">\n");
            WriteLiteral("                <div class=\"card-body\">\n                    <h6 class=\"card-title\">");
#nullable restore
#line 16 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
                                      Write(player.first_name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 16 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
                                                         Write(player.second_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                    <p>");
#nullable restore
#line 17 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
                  Write(chosenTeam.Count(z => z.team == player.team));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <p class=\"card-text\"><small class=\"text-muted\">");
#nullable restore
#line 18 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
                                                              Write(DataService.Data.Teams.Where(x => x.id == player.team).FirstOrDefault()?.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\n");
            WriteLiteral("                </div>\n            </div>\n            <p></p>\n");
#nullable restore
#line 23 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n");
#nullable restore
#line 25 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/TeamPicks.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<hr/>\n");
            WriteLiteral("\n\n");
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
