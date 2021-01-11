#pragma checksum "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b5e71cfc0cc932b548315466326a068b7be8ea4"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b5e71cfc0cc932b548315466326a068b7be8ea4", @"/Views/Page/ManagerView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f06dab59e6d8f79a9e5a08f407c770212dd7923c", @"/Views/_ViewImports.cshtml")]
    public class Views_Page_ManagerView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<FPLForecaster.Models.Manager.ManagerGameweek>>
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
#nullable restore
#line 1 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Please insert your manager ID to view your data.</p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b5e71cfc0cc932b548315466326a068b7be8ea44798", async() => {
                WriteLiteral("\r\n        Manager ID: <input type=\"text\" width=\"10\" name=\"manager_id\" id=\"manager_id\"/>\r\n        &nbsp;&nbsp;\r\n        <input type=\"submit\" value=\"Get Data\" style=\"background-color: aliceblue; \"></>\r\n        <hr/>\r\n");
#nullable restore
#line 14 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml"
     if (DataService.HasManagerData)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <h5>Name: ");
#nullable restore
#line 16 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml"
             Write(DataService.Data.ManagerData.ManagerInformation.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n        <small class=\"text-muted\">Joined: ");
#nullable restore
#line 17 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml"
                                     Write(DataService.Data.ManagerData.ManagerInformation.joined_time);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small>\r\n        <hr/>\r\n");
#nullable restore
#line 19 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml"
         foreach (FPLForecaster.Models.Manager.ManagerGameweek gameweek in DataService.Data.ManagerData.ManagerGameweeks.OrderByDescending(x => x.number).ToList())
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"card\" style=\"width: 18rem;margin-top:20px\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">Gameweek ");
#nullable restore
#line 23 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml"
                                               Write(gameweek.number);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                    <p class=\"card-text\">Points: ");
#nullable restore
#line 24 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml"
                                            Write(gameweek.points);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
                WriteLiteral("                    <p class=\"card-text\"><small class=\"text-muted\">Rank: ");
#nullable restore
#line 26 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml"
                                                                    Write(gameweek.rank);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small></p>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 29 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "/Users/yanni/Documents/Repos/FPLForecaster/Views/Page/ManagerView.cshtml"
         
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
            WriteLiteral("\r\n    \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<FPLForecaster.Models.Manager.ManagerGameweek>> Html { get; private set; }
    }
}
#pragma warning restore 1591
