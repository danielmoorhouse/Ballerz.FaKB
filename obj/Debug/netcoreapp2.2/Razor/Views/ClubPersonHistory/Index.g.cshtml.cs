#pragma checksum "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPersonHistory/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f012a6216ced60fb35d7b10fce723340bbf75cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ClubPersonHistory_Index), @"mvc.1.0.view", @"/Views/ClubPersonHistory/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ClubPersonHistory/Index.cshtml", typeof(AspNetCore.Views_ClubPersonHistory_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f012a6216ced60fb35d7b10fce723340bbf75cb", @"/Views/ClubPersonHistory/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b04a711db23eb1b161ffd02378a2ea84a8897a9b", @"/Views/_ViewImports.cshtml")]
    public class Views_ClubPersonHistory_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ballerz.Football.Models.ClubPersonHistory.ClubPersonHistoryIndexModel>
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
            BeginContext(78, 31, true);
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(109, 182, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f012a6216ced60fb35d7b10fce723340bbf75cb3858", async() => {
                BeginContext(115, 169, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n    <style>\r\n        p {\r\n            padding-top: 10%;\r\n        }\r\n    </style>\r\n");
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
            BeginContext(291, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(293, 2070, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f012a6216ced60fb35d7b10fce723340bbf75cb5207", async() => {
                BeginContext(299, 11, true);
                WriteLiteral("\r\n<p>\r\n    ");
                EndContext();
                BeginContext(310, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f012a6216ced60fb35d7b10fce723340bbf75cb5595", async() => {
                    BeginContext(333, 10, true);
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
                BeginContext(347, 1025, true);
                WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr class=""text-center"" style=""background-color: grey;"">
          
            <th>
              <p>Playing For</p>  
            </th>
            <th>
               <p>Season</p> 
            </th>
            <th>
            <p>League Name</p>
            </th>
             <th>
            <p>Appearances</p>
            </th>
            <th>
                 <span style=""width: 50px; font-size: 25px; background-color: red; color: red;"">R</span>
            </th>
            <th>
                <span style=""width: 50px; font-size: 25px; background-color: yellow; color: yellow;"">Y</span>
            </th>
            <th>
               <img src=""/images/backgrounds/football.png"" class="""" style=""width: 40px;"" />
            </th>
            <th>
               <p>Position</p> 
            </th>
            <th>
               <p>Points</p>
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>");
                WriteLiteral("\n");
                EndContext();
#line 55 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPersonHistory/Index.cshtml"
 foreach (var item in Model.ClubPersonHistoryList) {

#line default
#line hidden
                BeginContext(1426, 111, true);
                WriteLiteral("        <tr class=\"text-center\" style=\"background-color: lightgrey;\">\r\n           <td>\r\n               <strong>");
                EndContext();
                BeginContext(1538, 13, false);
#line 58 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPersonHistory/Index.cshtml"
                  Write(item.ClubName);

#line default
#line hidden
                EndContext();
                BeginContext(1551, 73, true);
                WriteLiteral("</strong> \r\n            </td>\r\n            <td>\r\n               <strong> ");
                EndContext();
                BeginContext(1625, 11, false);
#line 61 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPersonHistory/Index.cshtml"
                   Write(item.Season);

#line default
#line hidden
                EndContext();
                BeginContext(1636, 72, true);
                WriteLiteral("</strong>\r\n            </td>\r\n            <td>\r\n               <strong> ");
                EndContext();
                BeginContext(1709, 13, false);
#line 64 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPersonHistory/Index.cshtml"
                   Write(item.CompName);

#line default
#line hidden
                EndContext();
                BeginContext(1722, 74, true);
                WriteLiteral(" </strong>\r\n            </td>\r\n             <td>\r\n               <strong> ");
                EndContext();
                BeginContext(1797, 10, false);
#line 67 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPersonHistory/Index.cshtml"
                   Write(item.Games);

#line default
#line hidden
                EndContext();
                BeginContext(1807, 72, true);
                WriteLiteral(" </strong>\r\n            </td>\r\n            <td>\r\n               <strong>");
                EndContext();
                BeginContext(1880, 13, false);
#line 70 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPersonHistory/Index.cshtml"
                  Write(item.RedCards);

#line default
#line hidden
                EndContext();
                BeginContext(1893, 73, true);
                WriteLiteral("</strong> \r\n            </td>\r\n            <td>\r\n               <strong> ");
                EndContext();
                BeginContext(1967, 16, false);
#line 73 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPersonHistory/Index.cshtml"
                   Write(item.YellowCards);

#line default
#line hidden
                EndContext();
                BeginContext(1983, 71, true);
                WriteLiteral("</strong>\r\n            </td>\r\n            <td>\r\n               <strong>");
                EndContext();
                BeginContext(2055, 10, false);
#line 76 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPersonHistory/Index.cshtml"
                  Write(item.Goals);

#line default
#line hidden
                EndContext();
                BeginContext(2065, 73, true);
                WriteLiteral("</strong> \r\n            </td>\r\n            <td>\r\n               <strong> ");
                EndContext();
                BeginContext(2139, 13, false);
#line 79 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPersonHistory/Index.cshtml"
                   Write(item.Position);

#line default
#line hidden
                EndContext();
                BeginContext(2152, 71, true);
                WriteLiteral("</strong>\r\n            </td>\r\n            <td>\r\n               <strong>");
                EndContext();
                BeginContext(2224, 11, false);
#line 82 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPersonHistory/Index.cshtml"
                  Write(item.Points);

#line default
#line hidden
                EndContext();
                BeginContext(2235, 94, true);
                WriteLiteral("</strong> \r\n            </td>\r\n            <td>\r\n         \r\n            </td>\r\n        </tr>\r\n");
                EndContext();
#line 88 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPersonHistory/Index.cshtml"
}

#line default
#line hidden
                BeginContext(2332, 24, true);
                WriteLiteral("    </tbody>\r\n</table>\r\n");
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
            BeginContext(2363, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ballerz.Football.Models.ClubPersonHistory.ClubPersonHistoryIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
