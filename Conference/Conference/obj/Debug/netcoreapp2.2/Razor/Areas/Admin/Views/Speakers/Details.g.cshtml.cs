#pragma checksum "F:\MVC\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f05707bdfd6212acb6c00e5bab7178d0334a3ab6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Speakers_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Speakers/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Speakers/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_Speakers_Details))]
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
#line 1 "F:\MVC\Conference\Conference\Areas\Admin\Views\Speakers\_ViewImports.cshtml"
using Conference;

#line default
#line hidden
#line 2 "F:\MVC\Conference\Conference\Areas\Admin\Views\Speakers\_ViewImports.cshtml"
using Conference.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f05707bdfd6212acb6c00e5bab7178d0334a3ab6", @"/Areas/Admin/Views/Speakers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"730217b378615efac836ac18994c698ac7ffdc81", @"/Areas/Admin/Views/Speakers/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Speakers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Conference.Areas.Admin.Models.SpeakerViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\MVC\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(100, 29, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n");
            EndContext();
            BeginContext(175, 26, true);
            WriteLiteral("        <dl class=\"row\">\r\n");
            EndContext();
            BeginContext(313, 51, true);
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(365, 45, false);
#line 17 "F:\MVC\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(410, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(484, 41, false);
#line 20 "F:\MVC\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
           Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(525, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(598, 44, false);
#line 23 "F:\MVC\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(642, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(716, 40, false);
#line 26 "F:\MVC\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
           Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(756, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(829, 44, false);
#line 29 "F:\MVC\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Position));

#line default
#line hidden
            EndContext();
            BeginContext(873, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(947, 40, false);
#line 32 "F:\MVC\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
           Write(Html.DisplayFor(model => model.Position));

#line default
#line hidden
            EndContext();
            BeginContext(987, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(1060, 43, false);
#line 35 "F:\MVC\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Website));

#line default
#line hidden
            EndContext();
            BeginContext(1103, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1177, 39, false);
#line 38 "F:\MVC\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
           Write(Html.DisplayFor(model => model.Website));

#line default
#line hidden
            EndContext();
            BeginContext(1216, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(1289, 44, false);
#line 41 "F:\MVC\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Facebook));

#line default
#line hidden
            EndContext();
            BeginContext(1333, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1407, 40, false);
#line 44 "F:\MVC\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
           Write(Html.DisplayFor(model => model.Facebook));

#line default
#line hidden
            EndContext();
            BeginContext(1447, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(1520, 41, false);
#line 47 "F:\MVC\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1561, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1635, 37, false);
#line 50 "F:\MVC\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
           Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1672, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(1745, 44, false);
#line 53 "F:\MVC\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.LinkedIn));

#line default
#line hidden
            EndContext();
            BeginContext(1789, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1863, 40, false);
#line 56 "F:\MVC\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
           Write(Html.DisplayFor(model => model.LinkedIn));

#line default
#line hidden
            EndContext();
            BeginContext(1903, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(1976, 41, false);
#line 59 "F:\MVC\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Skype));

#line default
#line hidden
            EndContext();
            BeginContext(2017, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(2091, 37, false);
#line 62 "F:\MVC\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
           Write(Html.DisplayFor(model => model.Skype));

#line default
#line hidden
            EndContext();
            BeginContext(2128, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(2201, 42, false);
#line 65 "F:\MVC\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.GitHub));

#line default
#line hidden
            EndContext();
            BeginContext(2243, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(2317, 38, false);
#line 68 "F:\MVC\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
           Write(Html.DisplayFor(model => model.GitHub));

#line default
#line hidden
            EndContext();
            BeginContext(2355, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(2428, 43, false);
#line 71 "F:\MVC\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Twitter));

#line default
#line hidden
            EndContext();
            BeginContext(2471, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(2545, 39, false);
#line 74 "F:\MVC\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
           Write(Html.DisplayFor(model => model.Twitter));

#line default
#line hidden
            EndContext();
            BeginContext(2584, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(2657, 47, false);
#line 77 "F:\MVC\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(2704, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(2778, 43, false);
#line 80 "F:\MVC\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
           Write(Html.DisplayFor(model => model.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(2821, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(2894, 50, false);
#line 83 "F:\MVC\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.CompanyWebsite));

#line default
#line hidden
            EndContext();
            BeginContext(2944, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(3018, 46, false);
#line 86 "F:\MVC\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
           Write(Html.DisplayFor(model => model.CompanyWebsite));

#line default
#line hidden
            EndContext();
            BeginContext(3064, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(3137, 47, false);
#line 89 "F:\MVC\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(3184, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(3258, 43, false);
#line 92 "F:\MVC\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
           Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(3301, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(3374, 44, false);
#line 95 "F:\MVC\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.PageSlug));

#line default
#line hidden
            EndContext();
            BeginContext(3418, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(3492, 40, false);
#line 98 "F:\MVC\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
           Write(Html.DisplayFor(model => model.PageSlug));

#line default
#line hidden
            EndContext();
            BeginContext(3532, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(3605, 43, false);
#line 101 "F:\MVC\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(3648, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(3722, 39, false);
#line 104 "F:\MVC\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
           Write(Html.DisplayFor(model => model.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(3761, 53, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n</div>\r\n\r\n<div>\r\n");
            EndContext();
            BeginContext(3895, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(3899, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f05707bdfd6212acb6c00e5bab7178d0334a3ab617164", async() => {
                BeginContext(3921, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(3937, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Conference.Areas.Admin.Models.SpeakerViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
