#pragma checksum "/home/daniel/ASPProjects/Ballerz.Football/Views/Clubs/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad3b56478816dd407fa2d8845491f9cb2f777c19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clubs_Index), @"mvc.1.0.view", @"/Views/Clubs/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clubs/Index.cshtml", typeof(AspNetCore.Views_Clubs_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad3b56478816dd407fa2d8845491f9cb2f777c19", @"/Views/Clubs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b04a711db23eb1b161ffd02378a2ea84a8897a9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Clubs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ballerz.Football.Models.Clubs.ClubIndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(53, 33, true);
            WriteLiteral("\r\n\r\n\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(86, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad3b56478816dd407fa2d8845491f9cb2f777c193752", async() => {
                BeginContext(92, 87, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
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
            BeginContext(186, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(188, 413, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad3b56478816dd407fa2d8845491f9cb2f777c195006", async() => {
                BeginContext(194, 11, true);
                WriteLiteral("\r\n<p>\r\n    ");
                EndContext();
                BeginContext(205, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad3b56478816dd407fa2d8845491f9cb2f777c195394", async() => {
                    BeginContext(228, 10, true);
                    WriteLiteral("Create New");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(242, 27, true);
                WriteLiteral("\r\n</p>\r\n<div class=\"row\">\r\n");
                EndContext();
#line 17 "/home/daniel/ASPProjects/Ballerz.Football/Views/Clubs/Index.cshtml"
 foreach (var item in Model.ClubList) {

#line default
#line hidden
                BeginContext(310, 88, true);
                WriteLiteral("     <div class=\"col-md-3 text-center\">\r\n                \r\n           \r\n            <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 398, "\"", 422, 1);
#line 21 "/home/daniel/ASPProjects/Ballerz.Football/Views/Clubs/Index.cshtml"
WriteAttributeValue("", 404, item.TeamBadgeUrl, 404, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(423, 56, true);
                WriteLiteral(" style=\"width: 70%;\" />   <br/> \r\n          <h5><strong>");
                EndContext();
                BeginContext(480, 13, false);
#line 22 "/home/daniel/ASPProjects/Ballerz.Football/Views/Clubs/Index.cshtml"
                 Write(item.ClubName);

#line default
#line hidden
                EndContext();
                BeginContext(493, 43, true);
                WriteLiteral("</strong></h5>    \r\n            <p><strong>");
                EndContext();
                BeginContext(537, 15, false);
#line 23 "/home/daniel/ASPProjects/Ballerz.Football/Views/Clubs/Index.cshtml"
                  Write(item.LeagueName);

#line default
#line hidden
                EndContext();
                BeginContext(552, 30, true);
                WriteLiteral("</strong></p>    \r\n   </div>\r\n");
                EndContext();
#line 25 "/home/daniel/ASPProjects/Ballerz.Football/Views/Clubs/Index.cshtml"
}

#line default
#line hidden
                BeginContext(585, 9, true);
                WriteLiteral(" </div>\r\n");
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
            BeginContext(601, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ballerz.Football.Models.Clubs.ClubIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
