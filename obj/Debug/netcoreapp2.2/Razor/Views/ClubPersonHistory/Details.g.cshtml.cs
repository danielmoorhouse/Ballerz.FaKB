#pragma checksum "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPersonHistory/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07b6c143519c9f9db5d89f6cee5a64759f89c76d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ClubPersonHistory_Details), @"mvc.1.0.view", @"/Views/ClubPersonHistory/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ClubPersonHistory/Details.cshtml", typeof(AspNetCore.Views_ClubPersonHistory_Details))]
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
#line 1 "/home/daniel/ASPProjects/Ballerz.Football/Views/_ViewImports.cshtml"
using Ballerz.Football;

#line default
#line hidden
#line 2 "/home/daniel/ASPProjects/Ballerz.Football/Views/_ViewImports.cshtml"
using Ballerz.Football.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07b6c143519c9f9db5d89f6cee5a64759f89c76d", @"/Views/ClubPersonHistory/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b04a711db23eb1b161ffd02378a2ea84a8897a9b", @"/Views/_ViewImports.cshtml")]
    public class Views_ClubPersonHistory_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ballerz.Football.Knowledgebase.ClubPersonHistory>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPersonHistory/Details.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(86, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(115, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07b6c143519c9f9db5d89f6cee5a64759f89c76d4386", async() => {
                BeginContext(121, 89, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Details</title>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(217, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(219, 2133, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07b6c143519c9f9db5d89f6cee5a64759f89c76d5644", async() => {
                BeginContext(225, 122, true);
                WriteLiteral("\r\n\r\n<div>\r\n    <h4>ClubPersonHistory</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
                EndContext();
                BeginContext(348, 48, false);
#line 21 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPersonHistory/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ClubPersonId));

#line default
#line hidden
                EndContext();
                BeginContext(396, 63, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
                EndContext();
                BeginContext(460, 44, false);
#line 24 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPersonHistory/Details.cshtml"
       Write(Html.DisplayFor(model => model.ClubPersonId));

#line default
#line hidden
                EndContext();
                BeginContext(504, 62, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
                EndContext();
                BeginContext(567, 44, false);
#line 27 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPersonHistory/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TeamName));

#line default
#line hidden
                EndContext();
                BeginContext(611, 63, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
                EndContext();
                BeginContext(675, 40, false);
#line 30 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPersonHistory/Details.cshtml"
       Write(Html.DisplayFor(model => model.TeamName));

#line default
#line hidden
                EndContext();
                BeginContext(715, 62, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
                EndContext();
                BeginContext(778, 42, false);
#line 33 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPersonHistory/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Season));

#line default
#line hidden
                EndContext();
                BeginContext(820, 63, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
                EndContext();
                BeginContext(884, 38, false);
#line 36 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPersonHistory/Details.cshtml"
       Write(Html.DisplayFor(model => model.Season));

#line default
#line hidden
                EndContext();
                BeginContext(922, 62, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
                EndContext();
                BeginContext(985, 46, false);
#line 39 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPersonHistory/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LeagueName));

#line default
#line hidden
                EndContext();
                BeginContext(1031, 63, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
                EndContext();
                BeginContext(1095, 42, false);
#line 42 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPersonHistory/Details.cshtml"
       Write(Html.DisplayFor(model => model.LeagueName));

#line default
#line hidden
                EndContext();
                BeginContext(1137, 62, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
                EndContext();
                BeginContext(1200, 44, false);
#line 45 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPersonHistory/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RedCards));

#line default
#line hidden
                EndContext();
                BeginContext(1244, 63, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
                EndContext();
                BeginContext(1308, 40, false);
#line 48 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPersonHistory/Details.cshtml"
       Write(Html.DisplayFor(model => model.RedCards));

#line default
#line hidden
                EndContext();
                BeginContext(1348, 62, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
                EndContext();
                BeginContext(1411, 47, false);
#line 51 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPersonHistory/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.YellowCards));

#line default
#line hidden
                EndContext();
                BeginContext(1458, 63, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
                EndContext();
                BeginContext(1522, 43, false);
#line 54 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPersonHistory/Details.cshtml"
       Write(Html.DisplayFor(model => model.YellowCards));

#line default
#line hidden
                EndContext();
                BeginContext(1565, 62, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
                EndContext();
                BeginContext(1628, 41, false);
#line 57 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPersonHistory/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Goals));

#line default
#line hidden
                EndContext();
                BeginContext(1669, 63, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
                EndContext();
                BeginContext(1733, 37, false);
#line 60 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPersonHistory/Details.cshtml"
       Write(Html.DisplayFor(model => model.Goals));

#line default
#line hidden
                EndContext();
                BeginContext(1770, 62, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
                EndContext();
                BeginContext(1833, 44, false);
#line 63 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPersonHistory/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Position));

#line default
#line hidden
                EndContext();
                BeginContext(1877, 63, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
                EndContext();
                BeginContext(1941, 40, false);
#line 66 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPersonHistory/Details.cshtml"
       Write(Html.DisplayFor(model => model.Position));

#line default
#line hidden
                EndContext();
                BeginContext(1981, 62, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
                EndContext();
                BeginContext(2044, 42, false);
#line 69 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPersonHistory/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Points));

#line default
#line hidden
                EndContext();
                BeginContext(2086, 63, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
                EndContext();
                BeginContext(2150, 38, false);
#line 72 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPersonHistory/Details.cshtml"
       Write(Html.DisplayFor(model => model.Points));

#line default
#line hidden
                EndContext();
                BeginContext(2188, 47, true);
                WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
                EndContext();
                BeginContext(2235, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07b6c143519c9f9db5d89f6cee5a64759f89c76d13976", async() => {
                    BeginContext(2281, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 77 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPersonHistory/Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2289, 8, true);
                WriteLiteral(" |\r\n    ");
                EndContext();
                BeginContext(2297, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07b6c143519c9f9db5d89f6cee5a64759f89c76d16384", async() => {
                    BeginContext(2319, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2335, 10, true);
                WriteLiteral("\r\n</div>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(2352, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ballerz.Football.Knowledgebase.ClubPersonHistory> Html { get; private set; }
    }
}
#pragma warning restore 1591