#pragma checksum "/home/daniel/ASPProjects/Ballerz.Football/Views/Forum/Topic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73f6ed26f4308938e8821d0dbe5e404f0b142c35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Forum_Topic), @"mvc.1.0.view", @"/Views/Forum/Topic.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Forum/Topic.cshtml", typeof(AspNetCore.Views_Forum_Topic))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73f6ed26f4308938e8821d0dbe5e404f0b142c35", @"/Views/Forum/Topic.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b04a711db23eb1b161ffd02378a2ea84a8897a9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Forum_Topic : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ballerz.Football.Models.Forum.ForumTopicModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Search..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("searchBar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onfocus", new global::Microsoft.AspNetCore.Html.HtmlString("clearThis(this)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "id", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Forum", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 213, true);
            WriteLiteral("\n<div class=\"container body-content\">\n    <div class=\"row sectionHeader\">\n        <div class=\"sectionHeading text-center\" style=\" padding: 3%; margin-bottom: 3%; border-bottom: 4px solid orange;\">\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 266, "\"", 293, 1);
#line 6 "/home/daniel/ASPProjects/Ballerz.Football/Views/Forum/Topic.cshtml"
WriteAttributeValue("", 272, Model.Forum.ImageUrl, 272, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(294, 50, true);
            WriteLiteral(" style=\"width: 170px;\" />\n            <h3><strong>");
            EndContext();
            BeginContext(345, 16, false);
#line 7 "/home/daniel/ASPProjects/Ballerz.Football/Views/Forum/Topic.cshtml"
                   Write(Model.Forum.Name);

#line default
#line hidden
            EndContext();
            BeginContext(361, 60, true);
            WriteLiteral(" Forum</strong></h3>\n                    <h3>Welcome to the ");
            EndContext();
            BeginContext(422, 16, false);
#line 8 "/home/daniel/ASPProjects/Ballerz.Football/Views/Forum/Topic.cshtml"
                                  Write(Model.Forum.Name);

#line default
#line hidden
            EndContext();
            BeginContext(438, 106, true);
            WriteLiteral(" forum. <br/><br/> Swearing is tolerated, personal insults & bullying is NOT!!</h3>\n        \n            \n");
            EndContext();
#line 11 "/home/daniel/ASPProjects/Ballerz.Football/Views/Forum/Topic.cshtml"
             if (Context.User.Identity.IsAuthenticated)
            {
               

#line default
#line hidden
            BeginContext(630, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(650, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73f6ed26f4308938e8821d0dbe5e404f0b142c3510013", async() => {
                BeginContext(796, 57, true);
                WriteLiteral("\n                        Create Post\n                    ");
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
#line 16 "/home/daniel/ASPProjects/Ballerz.Football/Views/Forum/Topic.cshtml"
                         WriteLiteral(Model.Forum.Id);

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
            BeginContext(857, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 19 "/home/daniel/ASPProjects/Ballerz.Football/Views/Forum/Topic.cshtml"
                
            }

#line default
#line hidden
            BeginContext(889, 97, true);
            WriteLiteral("    \n        </div>\n        <div class=\"row text-center\" style=\"margin-bottom: 3%;\">\n            ");
            EndContext();
            BeginContext(986, 510, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73f6ed26f4308938e8821d0dbe5e404f0b142c3512961", async() => {
                BeginContext(1049, 62, true);
                WriteLiteral("\n                <div class=\"searchForm\">\n                    ");
                EndContext();
                BeginContext(1111, 109, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "73f6ed26f4308938e8821d0dbe5e404f0b142c3513404", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 26 "/home/daniel/ASPProjects/Ballerz.Football/Views/Forum/Topic.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchQuery);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
                BeginContext(1220, 204, true);
                WriteLiteral("\n                    <button type=\"submit\" class=\"btn btn-primary\">\n                        <i class=\"material-icons\">search forum</i>\n                    </button>\n                </div>\n                ");
                EndContext();
                BeginContext(1424, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "73f6ed26f4308938e8821d0dbe5e404f0b142c3515663", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 31 "/home/daniel/ASPProjects/Ballerz.Football/Views/Forum/Topic.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Forum.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1476, 13, true);
                WriteLiteral("\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1496, 95, true);
            WriteLiteral("\n            </div>\n        <div class=\"sectionDescription\">\n            <div class=\"forumLogo\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1591, "\"", 1643, 4);
            WriteAttributeValue("", 1599, "background-image:", 1599, 17, true);
            WriteAttributeValue(" ", 1616, "url(", 1617, 5, true);
#line 35 "/home/daniel/ASPProjects/Ballerz.Football/Views/Forum/Topic.cshtml"
WriteAttributeValue("", 1621, Model.Forum.ImageUrl, 1621, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 1642, ")", 1642, 1, true);
            EndWriteAttribute();
            BeginContext(1644, 21, true);
            WriteLiteral("></div>\n            \n");
            EndContext();
#line 37 "/home/daniel/ASPProjects/Ballerz.Football/Views/Forum/Topic.cshtml"
             if (!User.Identity.IsAuthenticated)
            {

#line default
#line hidden
            BeginContext(1728, 85, true);
            WriteLiteral("                <p>\n                    <span>You must be a \n                        ");
            EndContext();
            BeginContext(1813, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73f6ed26f4308938e8821d0dbe5e404f0b142c3520383", async() => {
                BeginContext(1863, 71, true);
                WriteLiteral("\n                            registered member\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1938, 71, true);
            WriteLiteral("\n                    to create a new post.</span>\n                </p>\n");
            EndContext();
#line 46 "/home/daniel/ASPProjects/Ballerz.Football/Views/Forum/Topic.cshtml"
            }

#line default
#line hidden
            BeginContext(2023, 798, true);
            WriteLiteral(@"        </div>
    </div>
    <div class=""container-fluid"" style="""">
   <div class=""row"" style=""border-bottom: 3px solid orange;"">
                            <div class=""col-md-1"">
                            <h5></h5>
                            </div>
                            <div class=""col-md-2 text-center"">
                             <h5><strong>Author</strong></h5>
                            </div>
                            <div class=""col-md-6 text-center"">
                             <h5><strong>Post Topic</strong></h5>
                            </div>
                            <div class=""col-md-3 text-center"">
                            <h5><strong>Replies</strong></h5>
                            </div>
                           
                        </div>
");
            EndContext();
#line 65 "/home/daniel/ASPProjects/Ballerz.Football/Views/Forum/Topic.cshtml"
         if (Model.Posts.Any())
        {
            
                    

#line default
#line hidden
#line 68 "/home/daniel/ASPProjects/Ballerz.Football/Views/Forum/Topic.cshtml"
                     foreach(var post in Model.Posts)
                    {

#line default
#line hidden
            BeginContext(2952, 228, true);
            WriteLiteral("                        <div class=\"row\" style=\"margin-top: 15px; border-bottom: 1px solid orange;\">\n                            <div class=\"col-md-1\" style=\"padding: 1%;\">\n                            <img class=\"img img-circle\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3180, "\"", 3206, 1);
#line 72 "/home/daniel/ASPProjects/Ballerz.Football/Views/Forum/Topic.cshtml"
WriteAttributeValue("", 3186, post.AuthorImageUrl, 3186, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3207, 204, true);
            WriteLiteral(" style=\"width: 50px; float: right;\" />\n                            </div>\n                            <div class=\"col-md-2 text-center\">\n                            <p class=\"\" style=\"padding-top: 15px;\">");
            EndContext();
            BeginContext(3412, 15, false);
#line 75 "/home/daniel/ASPProjects/Ballerz.Football/Views/Forum/Topic.cshtml"
                                                              Write(post.AuthorName);

#line default
#line hidden
            EndContext();
            BeginContext(3427, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(3430, 17, false);
#line 75 "/home/daniel/ASPProjects/Ballerz.Football/Views/Forum/Topic.cshtml"
                                                                                Write(post.AuthorRating);

#line default
#line hidden
            EndContext();
            BeginContext(3447, 137, true);
            WriteLiteral(")</p> \n                            </div>\n                            <div class=\"col-md-6 text-center\">\n                                ");
            EndContext();
            BeginContext(3584, 239, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73f6ed26f4308938e8821d0dbe5e404f0b142c3525295", async() => {
                BeginContext(3652, 116, true);
                WriteLiteral("\n                                \n                                  <h5 id=\"Title\" style=\"padding-top: 10px;\">&nbsp;");
                EndContext();
                BeginContext(3769, 10, false);
#line 80 "/home/daniel/ASPProjects/Ballerz.Football/Views/Forum/Topic.cshtml"
                                                                             Write(post.Title);

#line default
#line hidden
                EndContext();
                BeginContext(3779, 40, true);
                WriteLiteral(" </h5> \n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_14.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 78 "/home/daniel/ASPProjects/Ballerz.Football/Views/Forum/Topic.cshtml"
                                                                              WriteLiteral(post.Id);

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
            BeginContext(3823, 169, true);
            WriteLiteral("\n                            </div>\n                            <div class=\"col-md-3 text-center\">\n                               <p class=\"\" style=\"padding-top: 15px;\">");
            EndContext();
            BeginContext(3993, 17, false);
#line 84 "/home/daniel/ASPProjects/Ballerz.Football/Views/Forum/Topic.cshtml"
                                                                 Write(post.RepliesCount);

#line default
#line hidden
            EndContext();
            BeginContext(4010, 98, true);
            WriteLiteral("</p> \n                            </div>\n                         \n                        </div>\n");
            EndContext();
#line 88 "/home/daniel/ASPProjects/Ballerz.Football/Views/Forum/Topic.cshtml"
                       
                            
                         
                    }

#line default
#line hidden
#line 91 "/home/daniel/ASPProjects/Ballerz.Football/Views/Forum/Topic.cshtml"
                     
             
        }
        else
        {

#line default
#line hidden
            BeginContext(4256, 186, true);
            WriteLiteral("            <div class=\"noPosts\">\n               \n                <h3>\n                    It looks like there are no posts to be found.\n                    Why not \n                    ");
            EndContext();
            BeginContext(4442, 160, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73f6ed26f4308938e8821d0dbe5e404f0b142c3529686", async() => {
                BeginContext(4518, 80, true);
                WriteLiteral("\n                        <span><strong>Post</strong></span>\n                    ");
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
#line 101 "/home/daniel/ASPProjects/Ballerz.Football/Views/Forum/Topic.cshtml"
                                                                   WriteLiteral(Model.Forum.Id);

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
            BeginContext(4602, 73, true);
            WriteLiteral("\n                    Something?\n                </h3>\n            </div>\n");
            EndContext();
#line 107 "/home/daniel/ASPProjects/Ballerz.Football/Views/Forum/Topic.cshtml"
        }

#line default
#line hidden
            BeginContext(4685, 25, true);
            WriteLiteral("    </div>\n</div>\n</div>\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4727, 108, true);
                WriteLiteral(" \n    <script>\n        function clearThis(target) {\n            target.value = \"\";\n\n        }\n    </script>\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ballerz.Football.Models.Forum.ForumTopicModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
