#pragma checksum "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4292b8cbc3838e4453d490b7fdf989e83a53d221"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Index), @"mvc.1.0.view", @"/Views/Post/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/Index.cshtml", typeof(AspNetCore.Views_Post_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4292b8cbc3838e4453d490b7fdf989e83a53d221", @"/Views/Post/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b04a711db23eb1b161ffd02378a2ea84a8897a9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ballerz.Football.Models.Post.PostIndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Forum", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Topic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-back"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reply", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("right: 0; margin-top: 5%; \n                margin-right: 5%; position: fixed; z-index:15;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-newReply"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 143, true);
            WriteLiteral("\n<div class=\"container body-content\" style=\"\">\n    <div class=\"row postHeader\">\n        <div class=\"postHeading text-center\" >\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 194, "\"", 220, 1);
#line 6 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
WriteAttributeValue("", 200, Model.ForumImageUrl, 200, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(221, 75, true);
            WriteLiteral(" style=\"width: 15%;\" />\n              <h3 style=\"padding-left:5%;\"><strong>");
            EndContext();
            BeginContext(297, 15, false);
#line 7 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
                                              Write(Model.ForumName);

#line default
#line hidden
            EndContext();
            BeginContext(312, 7, true);
            WriteLiteral(" <br/> ");
            EndContext();
            BeginContext(320, 11, false);
#line 7 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
                                                                     Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(331, 59, true);
            WriteLiteral("</strong> </h3>  \n           \n            <br>\n            ");
            EndContext();
            BeginContext(390, 165, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4292b8cbc3838e4453d490b7fdf989e83a53d2217793", async() => {
                BeginContext(486, 49, true);
                WriteLiteral("<i class=\"fas fa-caret-square-left\"></i> Back to ");
                EndContext();
                BeginContext(536, 15, false);
#line 10 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
                                                                                                                                                        Write(Model.ForumName);

#line default
#line hidden
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
#line 10 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
                                                           WriteLiteral(Model.ForumId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(555, 31, true);
            WriteLiteral("\n        </div>\n    </div>\n    ");
            EndContext();
            BeginContext(586, 210, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4292b8cbc3838e4453d490b7fdf989e83a53d22110816", async() => {
                BeginContext(779, 13, true);
                WriteLiteral("Reply to Post");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 13 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
                                                    WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(796, 199, true);
            WriteLiteral("\n    <div class=\"row\" id=\"postIndexContent\" style=\"margin-top: 60px;  padding: 2%; \">\n        <div class=\"col-md-3 col-md-offset-1 postAuthorContainer\" style=\"padding: 2%;\">\n            \n            ");
            EndContext();
            BeginContext(995, 213, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4292b8cbc3838e4453d490b7fdf989e83a53d22113695", async() => {
                BeginContext(1074, 40, true);
                WriteLiteral("\n            <img class=\"img img-circle\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1114, "\"", 1141, 1);
#line 19 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
WriteAttributeValue("", 1120, Model.AuthorImageUrl, 1120, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1142, 26, true);
                WriteLiteral(" style=\"width: 50px;\" />  ");
                EndContext();
                BeginContext(1169, 16, false);
#line 19 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
                                                                                        Write(Model.AuthorName);

#line default
#line hidden
                EndContext();
                BeginContext(1185, 19, true);
                WriteLiteral(" <br/>\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 18 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
                                                              WriteLiteral(Model.AuthorId);

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
            BeginContext(1208, 58, true);
            WriteLiteral("\n            <span class=\"postDate\" style=\"color: white;\">");
            EndContext();
            BeginContext(1267, 13, false);
#line 21 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
                                                    Write(Model.Created);

#line default
#line hidden
            EndContext();
            BeginContext(1280, 147, true);
            WriteLiteral("</span><br/>\n            <p style=\"color: orange; background-color: #011333; width: 80%; padding: 1.5%; border: 1px solid orange;\">Post Author</p>\n");
            EndContext();
#line 23 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
             if (Model.IsAuthorAdmin)
            {

#line default
#line hidden
            BeginContext(1479, 146, true);
            WriteLiteral("                <span class=\"isAdmin smaller\" style=\"background-color: #14f702; color: #011333; font-size: 18px; font-weight: bold;\">Admin</span>\n");
            EndContext();
#line 26 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1639, 232, true);
            WriteLiteral("        </div>\n        <div class=\"col-md-7 postContentContainer\" style=\"background-color: lightgrey; padding: 0%; min-height: 13.5em; position: relative;\">\n            <div class=\"postContent\" style=\"padding: 2%;\">\n                ");
            EndContext();
            BeginContext(1872, 27, false);
#line 30 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
           Write(Html.Raw(Model.PostContent));

#line default
#line hidden
            EndContext();
            BeginContext(1899, 20, true);
            WriteLiteral("\n            </div>\n");
            EndContext();
#line 32 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
                if (User.Identity.IsAuthenticated)
    {
        

#line default
#line hidden
            BeginContext(1985, 131, true);
            WriteLiteral("             <div style=\"background-color: black; position: absolute; bottom: 0; width: 100%;\">\n            <span>\n                ");
            EndContext();
            BeginContext(2116, 148, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4292b8cbc3838e4453d490b7fdf989e83a53d22119271", async() => {
                BeginContext(2212, 48, true);
                WriteLiteral("\n                    Post Reply\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 37 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
                                                                WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2264, 66, true);
            WriteLiteral("\n                \n            \n            </span>\n        </div>\n");
            EndContext();
#line 44 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
    
    }

#line default
#line hidden
            BeginContext(2341, 31, true);
            WriteLiteral("        </div>\n    </div>\n    \n");
            EndContext();
#line 49 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
      if (Model.Replies.Any())
    {
        foreach (var reply in Model.Replies)
        {
            

#line default
#line hidden
#line 53 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
             if(Model.AuthorId == reply.AuthorId)
            {

#line default
#line hidden
            BeginContext(2528, 240, true);
            WriteLiteral("            <div class=\"row replyContent\" style=\"margin-top: 60px;\">\n                <div class=\"col-md-3 replyAuthorContainer col-md-offset-2\" style=\"background-color: #011333; padding: 1%;\" >\n                   <img class=\"img img-circle\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2768, "\"", 2795, 1);
#line 57 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
WriteAttributeValue("", 2774, reply.AuthorImageUrl, 2774, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2796, 44, true);
            WriteLiteral(" style=\"width: 60px;\"/>\n                    ");
            EndContext();
            BeginContext(2840, 146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4292b8cbc3838e4453d490b7fdf989e83a53d22123380", async() => {
                BeginContext(2919, 25, true);
                WriteLiteral("\n                        ");
                EndContext();
                BeginContext(2945, 16, false);
#line 59 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
                   Write(reply.AuthorName);

#line default
#line hidden
                EndContext();
                BeginContext(2961, 21, true);
                WriteLiteral("\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
                                                                      WriteLiteral(reply.AuthorId);

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
            BeginContext(2986, 143, true);
            WriteLiteral("\n                    <p style=\"color: orange; background-color: #011333; width: 34%; padding: 1.5%; border: 1px solid orange;\">Post Author</p>\n");
            EndContext();
#line 62 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
                     if (reply.IsAuthorAdmin)
                    {

#line default
#line hidden
            BeginContext(3197, 155, true);
            WriteLiteral("                        <span class=\"isAdmin smaller\"  style=\"background-color: #14f702; color: #011333; font-size: 18px; font-weight: bold;\">Admin</span>\n");
            EndContext();
#line 65 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
                        
                    }

#line default
#line hidden
            BeginContext(3399, 90, true);
            WriteLiteral("                    <br>\n                    <span class=\"postDate\" style=\"color: white;\">");
            EndContext();
            BeginContext(3490, 13, false);
#line 68 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
                                                            Write(reply.Created);

#line default
#line hidden
            EndContext();
            BeginContext(3503, 218, true);
            WriteLiteral("</span>\n                </div>\n                <div class=\"col-md-7 replyContentContainer\"  style=\"background-color: lightgrey; min-height: 12em;\">\n                    <div class=\"postContent\">\n                        ");
            EndContext();
            BeginContext(3722, 28, false);
#line 72 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
                   Write(Html.Raw(reply.ReplyContent));

#line default
#line hidden
            EndContext();
            BeginContext(3750, 70, true);
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n");
            EndContext();
#line 76 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
        }

#line default
#line hidden
#line 77 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
          if(Model.AuthorId != reply.AuthorId)
            {

#line default
#line hidden
            BeginContext(3891, 338, true);
            WriteLiteral(@"            <div class=""row replyContent"" style=""margin-top: 60px;"">
                <div class=""col-md-2  replyAuthorContainer col-md-offset-2"" style=""background-color: orange;"" >
                    <div class=""img img-circle"" style=""width: 60px; background-color: grey;""></div>
                   <!-- <img class=""img img-circle"" src=""");
            EndContext();
            BeginContext(4230, 20, false);
#line 82 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
                                                    Write(reply.AuthorImageUrl);

#line default
#line hidden
            EndContext();
            BeginContext(4250, 56, true);
            WriteLiteral("\" style=\"width: 60px;\"/> -->  <br> \n                    ");
            EndContext();
            BeginContext(4306, 146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4292b8cbc3838e4453d490b7fdf989e83a53d22129336", async() => {
                BeginContext(4385, 25, true);
                WriteLiteral("\n                        ");
                EndContext();
                BeginContext(4411, 16, false);
#line 84 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
                   Write(reply.AuthorName);

#line default
#line hidden
                EndContext();
                BeginContext(4427, 21, true);
                WriteLiteral("\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 83 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
                                                                      WriteLiteral(reply.AuthorId);

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
            BeginContext(4452, 25, true);
            WriteLiteral("\n                   <br>\n");
            EndContext();
#line 87 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
                     if (reply.IsAuthorAdmin)
                    {

#line default
#line hidden
            BeginContext(4545, 65, true);
            WriteLiteral("                        <div class=\"isAdmin smaller\">Admin</div>\n");
            EndContext();
#line 90 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
                        
                    }

#line default
#line hidden
            BeginContext(4657, 43, true);
            WriteLiteral("                    <span class=\"postDate\">");
            EndContext();
            BeginContext(4701, 13, false);
#line 92 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
                                      Write(reply.Created);

#line default
#line hidden
            EndContext();
            BeginContext(4714, 217, true);
            WriteLiteral("</span>\n                </div>\n                <div class=\"col-md-7 replyContentContainer\" style=\"background-color: lightgrey; min-height: 12em;\">\n                    <div class=\"postContent\">\n                        ");
            EndContext();
            BeginContext(4932, 28, false);
#line 96 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
                   Write(Html.Raw(reply.ReplyContent));

#line default
#line hidden
            EndContext();
            BeginContext(4960, 70, true);
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n");
            EndContext();
#line 100 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
        }

#line default
#line hidden
#line 100 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"
         
    }
    }
    else
    {

#line default
#line hidden
            BeginContext(5067, 137, true);
            WriteLiteral("        <div class=\"noPosts\">\n            <h3>\n                There are no replies to this post.<br />\n            </h3>\n        </div>\n");
            EndContext();
#line 110 "/home/daniel/ASPProjects/Ballerz.Football/Views/Post/Index.cshtml"

    }

#line default
#line hidden
            BeginContext(5211, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ballerz.Football.Models.Post.PostIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591