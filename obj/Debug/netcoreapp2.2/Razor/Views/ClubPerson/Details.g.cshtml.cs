#pragma checksum "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPerson/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bee9219c7c8533c6931df451110c01d8a0a9e25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ClubPerson_Details), @"mvc.1.0.view", @"/Views/ClubPerson/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ClubPerson/Details.cshtml", typeof(AspNetCore.Views_ClubPerson_Details))]
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
#line 2 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPerson/Details.cshtml"
using Humanizer;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bee9219c7c8533c6931df451110c01d8a0a9e25", @"/Views/ClubPerson/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b04a711db23eb1b161ffd02378a2ea84a8897a9b", @"/Views/_ViewImports.cshtml")]
    public class Views_ClubPerson_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ballerz.Football.Models.ClubPerson.ClubPersonDetailModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ClubPersonHistory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(83, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(110, 169, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bee9219c7c8533c6931df451110c01d8a0a9e254545", async() => {
                BeginContext(116, 156, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Details</title>\r\n    <style>\r\n    th {\r\n        color: white;\r\n    }\r\n    </style>\r\n");
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
            BeginContext(279, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(281, 3882, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bee9219c7c8533c6931df451110c01d8a0a9e255881", async() => {
                BeginContext(336, 321, true);
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-md-3 text-center"">
      
        </div>
        <div class=""col-md-6""></div>
    </div>
     
<div class=""row"" style=""background-color: white;"">
    <div class=""col-md-3 text-center"" style=""padding: 2%; border-right: 1px solid lightgrey;"">
                    <h2");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 657, "\"", 771, 9);
                WriteAttributeValue("", 665, "background-color:", 665, 17, true);
#line 25 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPerson/Details.cshtml"
WriteAttributeValue(" ", 682, Model.Club.PageTheme, 683, 21, false);

#line default
#line hidden
                WriteAttributeValue("", 704, ";", 704, 1, true);
                WriteAttributeValue(" ", 705, "color:", 706, 7, true);
#line 25 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPerson/Details.cshtml"
WriteAttributeValue(" ", 712, Model.Club.PageTheme2, 713, 22, false);

#line default
#line hidden
                WriteAttributeValue("", 735, ";", 735, 1, true);
                WriteAttributeValue(" ", 736, "padding:", 737, 9, true);
                WriteAttributeValue(" ", 745, "2.5%;border-radius:", 746, 20, true);
                WriteAttributeValue(" ", 765, "25px;", 766, 6, true);
                EndWriteAttribute();
                BeginContext(772, 63, true);
                WriteLiteral(">\r\n    <strong>Player Profile</strong> </h2><hr/>\r\n        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 835, "\"", 873, 1);
#line 27 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPerson/Details.cshtml"
WriteAttributeValue("", 841, Model.ClubPerson.PlayerImageUrl, 841, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(874, 41, true);
                WriteLiteral(" style=\"width: 80%\"> \r\n      <h5><strong>");
                EndContext();
                BeginContext(916, 26, false);
#line 28 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPerson/Details.cshtml"
             Write(Model.ClubPerson.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(942, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(944, 25, false);
#line 28 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPerson/Details.cshtml"
                                         Write(Model.ClubPerson.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(969, 35, true);
                WriteLiteral("</strong></h5>  \r\n      <p><strong>");
                EndContext();
                BeginContext(1005, 23, false);
#line 29 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPerson/Details.cshtml"
            Write(Model.ClubRole.RoleName);

#line default
#line hidden
                EndContext();
                BeginContext(1028, 32, true);
                WriteLiteral("</strong></p>\r\n      <p><strong>");
                EndContext();
                BeginContext(1061, 40, false);
#line 30 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPerson/Details.cshtml"
            Write(Model.ClubPerson.DoB.ToShortDateString());

#line default
#line hidden
                EndContext();
                BeginContext(1101, 37, true);
                WriteLiteral("</strong></p>\r\n      <p><strong>Born ");
                EndContext();
                BeginContext(1139, 31, false);
#line 31 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPerson/Details.cshtml"
                 Write(Model.ClubPerson.DoB.Humanize());

#line default
#line hidden
                EndContext();
                BeginContext(1170, 34, true);
                WriteLiteral("</strong></p>\r\n       <p> <strong>");
                EndContext();
                BeginContext(1205, 21, false);
#line 32 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPerson/Details.cshtml"
              Write(Model.ClubPerson.From);

#line default
#line hidden
                EndContext();
                BeginContext(1226, 28, true);
                WriteLiteral(" </strong> <br/>\r\n      <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1254, "\"", 1282, 1);
#line 33 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPerson/Details.cshtml"
WriteAttributeValue("", 1260, Model.Country.FlagUrl, 1260, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1283, 37, true);
                WriteLiteral(" style=\"width: 40px;\" /><br/><strong>");
                EndContext();
                BeginContext(1321, 25, false);
#line 33 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPerson/Details.cshtml"
                                                                       Write(Model.Country.CountryName);

#line default
#line hidden
                EndContext();
                BeginContext(1346, 62, true);
                WriteLiteral("</strong></p>\r\n      <hr/>\r\n      \r\n      <p><strong>Value: £ ");
                EndContext();
                BeginContext(1409, 33, false);
#line 36 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPerson/Details.cshtml"
                     Write(Model.ClubPerson.Value.Humanize());

#line default
#line hidden
                EndContext();
                BeginContext(1442, 37, true);
                WriteLiteral("</strong></p>\r\n      <hr/>\r\n     <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1479, "\"", 1509, 1);
#line 38 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPerson/Details.cshtml"
WriteAttributeValue("", 1485, Model.Club.TeamBadgeUrl, 1485, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1510, 44, true);
                WriteLiteral(" style=\"width: 40%\"> \r\n     <hr/>\r\n     <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1554, "\"", 1589, 1);
#line 40 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPerson/Details.cshtml"
WriteAttributeValue("", 1560, Model.Competition.CompImgUrl, 1560, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1590, 40, true);
                WriteLiteral(" style=\"width: 50%\"> \r\n     <hr/>\r\n     ");
                EndContext();
                BeginContext(1630, 107, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bee9219c7c8533c6931df451110c01d8a0a9e2512760", async() => {
                    BeginContext(1724, 9, true);
                    WriteLiteral("Add Stats");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 42 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPerson/Details.cshtml"
                                                                 WriteLiteral(Model.ClubPerson.Id);

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
                BeginContext(1737, 171, true);
                WriteLiteral("\r\n      <p><strong></strong></p>\r\n      <p><strong></strong></p>\r\n      <p><strong></strong></p>\r\n    </div>\r\n    <div class=\"col-md-9 text-center\">\r\n       \r\n         <h2");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 1908, "\"", 2039, 12);
                WriteAttributeValue("", 1916, "color:", 1916, 6, true);
#line 49 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPerson/Details.cshtml"
WriteAttributeValue(" ", 1922, Model.Club.PageTheme, 1923, 21, false);

#line default
#line hidden
                WriteAttributeValue("", 1944, ";", 1944, 1, true);
                WriteAttributeValue(" ", 1945, "background-color:", 1946, 18, true);
#line 49 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPerson/Details.cshtml"
WriteAttributeValue(" ", 1963, Model.Club.PageTheme2, 1964, 22, false);

#line default
#line hidden
                WriteAttributeValue("", 1986, ";", 1986, 1, true);
                WriteAttributeValue(" ", 1987, "padding:", 1988, 9, true);
                WriteAttributeValue(" ", 1996, "1%;", 1997, 4, true);
                WriteAttributeValue(" ", 2000, "margin-top:", 2001, 12, true);
                WriteAttributeValue(" ", 2012, "2.5%;", 2013, 6, true);
                WriteAttributeValue(" ", 2018, "border-radius:", 2019, 15, true);
                WriteAttributeValue(" ", 2033, "25px;", 2034, 6, true);
                EndWriteAttribute();
                BeginContext(2040, 1044, true);
                WriteLiteral(@">
    <strong>Seasonal Stats</strong> </h2>
    <table class=""table"">
    <thead>
        <tr class=""text-center"" style=""background-color: black;"">
          
            <th>
              <p>Club</p>  
            </th>
            <th>
               <p>Season</p> 
            </th>
            <th>
            <p>League</p>
            </th>
             <th>
            <p>Games</p>
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
               <p>Psn</p> 
            </th>
            <th>
               <p>Pts</p>
            </th>
            <th></th>
        </tr>
    </the");
                WriteLiteral("ad>\r\n      <tbody>\r\n");
                EndContext();
#line 86 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPerson/Details.cshtml"
 foreach (var item in Model.ClubPersonHistory) {

#line default
#line hidden
                BeginContext(3134, 111, true);
                WriteLiteral("        <tr class=\"text-center\" style=\"background-color: lightgrey;\">\r\n           <td>\r\n               <strong>");
                EndContext();
                BeginContext(3246, 13, false);
#line 89 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPerson/Details.cshtml"
                  Write(item.TeamName);

#line default
#line hidden
                EndContext();
                BeginContext(3259, 73, true);
                WriteLiteral("</strong> \r\n            </td>\r\n            <td>\r\n               <strong> ");
                EndContext();
                BeginContext(3333, 11, false);
#line 92 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPerson/Details.cshtml"
                   Write(item.Season);

#line default
#line hidden
                EndContext();
                BeginContext(3344, 72, true);
                WriteLiteral("</strong>\r\n            </td>\r\n            <td>\r\n               <strong> ");
                EndContext();
                BeginContext(3417, 15, false);
#line 95 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPerson/Details.cshtml"
                   Write(item.LeagueName);

#line default
#line hidden
                EndContext();
                BeginContext(3432, 74, true);
                WriteLiteral(" </strong>\r\n            </td>\r\n             <td>\r\n               <strong> ");
                EndContext();
                BeginContext(3507, 10, false);
#line 98 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPerson/Details.cshtml"
                   Write(item.Games);

#line default
#line hidden
                EndContext();
                BeginContext(3517, 72, true);
                WriteLiteral(" </strong>\r\n            </td>\r\n            <td>\r\n               <strong>");
                EndContext();
                BeginContext(3590, 13, false);
#line 101 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPerson/Details.cshtml"
                  Write(item.RedCards);

#line default
#line hidden
                EndContext();
                BeginContext(3603, 73, true);
                WriteLiteral("</strong> \r\n            </td>\r\n            <td>\r\n               <strong> ");
                EndContext();
                BeginContext(3677, 16, false);
#line 104 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPerson/Details.cshtml"
                   Write(item.YellowCards);

#line default
#line hidden
                EndContext();
                BeginContext(3693, 71, true);
                WriteLiteral("</strong>\r\n            </td>\r\n            <td>\r\n               <strong>");
                EndContext();
                BeginContext(3765, 10, false);
#line 107 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPerson/Details.cshtml"
                  Write(item.Goals);

#line default
#line hidden
                EndContext();
                BeginContext(3775, 73, true);
                WriteLiteral("</strong> \r\n            </td>\r\n            <td>\r\n               <strong> ");
                EndContext();
                BeginContext(3849, 13, false);
#line 110 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPerson/Details.cshtml"
                   Write(item.Position);

#line default
#line hidden
                EndContext();
                BeginContext(3862, 71, true);
                WriteLiteral("</strong>\r\n            </td>\r\n            <td>\r\n               <strong>");
                EndContext();
                BeginContext(3934, 11, false);
#line 113 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPerson/Details.cshtml"
                  Write(item.Points);

#line default
#line hidden
                EndContext();
                BeginContext(3945, 94, true);
                WriteLiteral("</strong> \r\n            </td>\r\n            <td>\r\n         \r\n            </td>\r\n        </tr>\r\n");
                EndContext();
#line 119 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPerson/Details.cshtml"
}

#line default
#line hidden
                BeginContext(4042, 66, true);
                WriteLiteral("    </tbody>\r\n</table>\r\n   \r\n    </div>\r\n</div>\r\n<div>\r\n    \r\n    ");
                EndContext();
                BeginContext(4108, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bee9219c7c8533c6931df451110c01d8a0a9e2522543", async() => {
                    BeginContext(4130, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4146, 10, true);
                WriteLiteral("\r\n</div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "style", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 294, "background-color:", 294, 17, true);
#line 15 "/home/daniel/ASPProjects/Ballerz.Football/Views/ClubPerson/Details.cshtml"
AddHtmlAttributeValue(" ", 311, Model.Club.PageTheme, 312, 21, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 333, ";", 333, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4163, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ballerz.Football.Models.ClubPerson.ClubPersonDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
