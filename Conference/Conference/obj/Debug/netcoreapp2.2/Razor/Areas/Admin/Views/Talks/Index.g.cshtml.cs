#pragma checksum "F:\MVC\Conference\Conference\Areas\Admin\Views\Talks\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e29d0edb36b4d13aef4f58a536f613022f3383e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Talks_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Talks/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Talks/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Talks_Index))]
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
#line 1 "F:\MVC\Conference\Conference\Areas\Admin\Views\Talks\_ViewImports.cshtml"
using Conference;

#line default
#line hidden
#line 2 "F:\MVC\Conference\Conference\Areas\Admin\Views\Talks\_ViewImports.cshtml"
using Conference.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e29d0edb36b4d13aef4f58a536f613022f3383e1", @"/Areas/Admin/Views/Talks/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c0fb2b8b9ff9d6f9423133fdddc48d4c185afeb", @"/Areas/Admin/Views/Talks/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Talks_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Conference.Domain.Entities.Talks>>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\MVC\Conference\Conference\Areas\Admin\Views\Talks\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(97, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(126, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e29d0edb36b4d13aef4f58a536f613022f3383e13858", async() => {
                BeginContext(149, 10, true);
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
            BeginContext(163, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(256, 38, false);
#line 16 "F:\MVC\Conference\Conference\Areas\Admin\Views\Talks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(294, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(350, 45, false);
#line 19 "F:\MVC\Conference\Conference\Areas\Admin\Views\Talks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SpeakerId));

#line default
#line hidden
            EndContext();
            BeginContext(395, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(451, 40, false);
#line 22 "F:\MVC\Conference\Conference\Areas\Admin\Views\Talks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(491, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(547, 47, false);
#line 25 "F:\MVC\Conference\Conference\Areas\Admin\Views\Talks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(594, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(650, 43, false);
#line 28 "F:\MVC\Conference\Conference\Areas\Admin\Views\Talks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(693, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 34 "F:\MVC\Conference\Conference\Areas\Admin\Views\Talks\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(811, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(860, 37, false);
#line 37 "F:\MVC\Conference\Conference\Areas\Admin\Views\Talks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(897, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(953, 44, false);
#line 40 "F:\MVC\Conference\Conference\Areas\Admin\Views\Talks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SpeakerId));

#line default
#line hidden
            EndContext();
            BeginContext(997, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1053, 39, false);
#line 43 "F:\MVC\Conference\Conference\Areas\Admin\Views\Talks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1092, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1148, 46, false);
#line 46 "F:\MVC\Conference\Conference\Areas\Admin\Views\Talks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1194, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1250, 42, false);
#line 49 "F:\MVC\Conference\Conference\Areas\Admin\Views\Talks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(1292, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1348, 53, false);
#line 52 "F:\MVC\Conference\Conference\Areas\Admin\Views\Talks\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1401, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1422, 58, false);
#line 53 "F:\MVC\Conference\Conference\Areas\Admin\Views\Talks\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.Id}));

#line default
#line hidden
            EndContext();
            BeginContext(1480, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1501, 57, false);
#line 54 "F:\MVC\Conference\Conference\Areas\Admin\Views\Talks\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1558, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 57 "F:\MVC\Conference\Conference\Areas\Admin\Views\Talks\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1597, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Conference.Domain.Entities.Talks>> Html { get; private set; }
    }
}
#pragma warning restore 1591
