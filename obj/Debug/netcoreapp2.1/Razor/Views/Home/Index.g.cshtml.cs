#pragma checksum "C:\Users\Ranveer\Documents\Dojo\cSharp\ASP\ChefsNDishes\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77fb7a8b937550080489728cba7ea4bd2f90e4dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Ranveer\Documents\Dojo\cSharp\ASP\ChefsNDishes\Views\_ViewImports.cshtml"
using ChefsNDishes;

#line default
#line hidden
#line 2 "C:\Users\Ranveer\Documents\Dojo\cSharp\ASP\ChefsNDishes\Views\_ViewImports.cshtml"
using ChefsNDishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77fb7a8b937550080489728cba7ea4bd2f90e4dd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3683dbd783bea45b88d0b0d3ee52e8ec1e5d61", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Chef>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteChef", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(13, 699, true);
            WriteLiteral(@"<div class=""container"">
    <h1 class=""text-center"">Chefs | <a href=""/dishes"">Dishes</a></h1>
        <div class=""center-outer"">
        <div class=""center-inner"">

            <div class=""bubbles"">
            <h2>Check out our roster of Chefs!</h2>
        </div>
        </div>
    </div> 
    <h2><a href=""/new"" class=""new-chef btn btn-primary pull-right"">Add a Chef</a></h2>
    <hr>
    <table class=""table table-striped table-dark"">
        <thead>
            <tr>
                <th scope=""col"">Name</th>
                <th scope=""col"">Age</th>
                <th scope=""col""># of Dishes</th>
            </tr>
        </thead>
        <tbody class=""smooth-scroll"">
");
            EndContext();
#line 23 "C:\Users\Ranveer\Documents\Dojo\cSharp\ASP\ChefsNDishes\Views\Home\Index.cshtml"
             foreach (var chef in ViewBag.AllChefs)
            {

#line default
#line hidden
            BeginContext(780, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(827, 14, false);
#line 26 "C:\Users\Ranveer\Documents\Dojo\cSharp\ASP\ChefsNDishes\Views\Home\Index.cshtml"
                   Write(chef.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(841, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(843, 13, false);
#line 26 "C:\Users\Ranveer\Documents\Dojo\cSharp\ASP\ChefsNDishes\Views\Home\Index.cshtml"
                                   Write(chef.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(856, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(888, 8, false);
#line 27 "C:\Users\Ranveer\Documents\Dojo\cSharp\ASP\ChefsNDishes\Views\Home\Index.cshtml"
                   Write(chef.Age);

#line default
#line hidden
            EndContext();
            BeginContext(896, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(928, 22, false);
#line 28 "C:\Users\Ranveer\Documents\Dojo\cSharp\ASP\ChefsNDishes\Views\Home\Index.cshtml"
                   Write(chef.AddedDishes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(950, 32, true);
            WriteLiteral("</td>\r\n                    <td >");
            EndContext();
            BeginContext(982, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a954fa3caac746d59d1e94a44be2364b", async() => {
                BeginContext(1088, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-chefId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 29 "C:\Users\Ranveer\Documents\Dojo\cSharp\ASP\ChefsNDishes\Views\Home\Index.cshtml"
                                                                                WriteLiteral(chef.ChefId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["chefId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-chefId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["chefId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1098, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 31 "C:\Users\Ranveer\Documents\Dojo\cSharp\ASP\ChefsNDishes\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1143, 38, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Chef> Html { get; private set; }
    }
}
#pragma warning restore 1591