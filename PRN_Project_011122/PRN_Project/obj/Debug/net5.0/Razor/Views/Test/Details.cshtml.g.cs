#pragma checksum "D:\FU_Hub\FA22\PRN211\Project\FINAL_PROJECT\Code\PRN_Project_03112022\PRN_Project_02112022\PRN_Project_01112022\PRN_Project_011122\PRN_Project\Views\Test\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf2bdf596a0630bbd406439296e0fde3f75c9e34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_Details), @"mvc.1.0.view", @"/Views/Test/Details.cshtml")]
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
#line 1 "D:\FU_Hub\FA22\PRN211\Project\FINAL_PROJECT\Code\PRN_Project_03112022\PRN_Project_02112022\PRN_Project_01112022\PRN_Project_011122\PRN_Project\Views\_ViewImports.cshtml"
using PRN_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FU_Hub\FA22\PRN211\Project\FINAL_PROJECT\Code\PRN_Project_03112022\PRN_Project_02112022\PRN_Project_01112022\PRN_Project_011122\PRN_Project\Views\_ViewImports.cshtml"
using PRN_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf2bdf596a0630bbd406439296e0fde3f75c9e34", @"/Views/Test/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"338c0757b3221eca7c40b229392d324a233b1778", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Test_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRN_Project.Models.Account>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\FU_Hub\FA22\PRN211\Project\FINAL_PROJECT\Code\PRN_Project_03112022\PRN_Project_02112022\PRN_Project_01112022\PRN_Project_011122\PRN_Project\Views\Test\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Details</h1>\n\n<div>\n    <h4>Account</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 15 "D:\FU_Hub\FA22\PRN211\Project\FINAL_PROJECT\Code\PRN_Project_03112022\PRN_Project_02112022\PRN_Project_01112022\PRN_Project_011122\PRN_Project\Views\Test\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 18 "D:\FU_Hub\FA22\PRN211\Project\FINAL_PROJECT\Code\PRN_Project_03112022\PRN_Project_02112022\PRN_Project_01112022\PRN_Project_011122\PRN_Project\Views\Test\Details.cshtml"
       Write(Html.DisplayFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 21 "D:\FU_Hub\FA22\PRN211\Project\FINAL_PROJECT\Code\PRN_Project_03112022\PRN_Project_02112022\PRN_Project_01112022\PRN_Project_011122\PRN_Project\Views\Test\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 24 "D:\FU_Hub\FA22\PRN211\Project\FINAL_PROJECT\Code\PRN_Project_03112022\PRN_Project_02112022\PRN_Project_01112022\PRN_Project_011122\PRN_Project\Views\Test\Details.cshtml"
       Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 27 "D:\FU_Hub\FA22\PRN211\Project\FINAL_PROJECT\Code\PRN_Project_03112022\PRN_Project_02112022\PRN_Project_01112022\PRN_Project_011122\PRN_Project\Views\Test\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsCus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 30 "D:\FU_Hub\FA22\PRN211\Project\FINAL_PROJECT\Code\PRN_Project_03112022\PRN_Project_02112022\PRN_Project_01112022\PRN_Project_011122\PRN_Project\Views\Test\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsCus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 33 "D:\FU_Hub\FA22\PRN211\Project\FINAL_PROJECT\Code\PRN_Project_03112022\PRN_Project_02112022\PRN_Project_01112022\PRN_Project_011122\PRN_Project\Views\Test\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 36 "D:\FU_Hub\FA22\PRN211\Project\FINAL_PROJECT\Code\PRN_Project_03112022\PRN_Project_02112022\PRN_Project_01112022\PRN_Project_011122\PRN_Project\Views\Test\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 39 "D:\FU_Hub\FA22\PRN211\Project\FINAL_PROJECT\Code\PRN_Project_03112022\PRN_Project_02112022\PRN_Project_01112022\PRN_Project_011122\PRN_Project\Views\Test\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 42 "D:\FU_Hub\FA22\PRN211\Project\FINAL_PROJECT\Code\PRN_Project_03112022\PRN_Project_02112022\PRN_Project_01112022\PRN_Project_011122\PRN_Project\Views\Test\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 45 "D:\FU_Hub\FA22\PRN211\Project\FINAL_PROJECT\Code\PRN_Project_03112022\PRN_Project_02112022\PRN_Project_01112022\PRN_Project_011122\PRN_Project\Views\Test\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 48 "D:\FU_Hub\FA22\PRN211\Project\FINAL_PROJECT\Code\PRN_Project_03112022\PRN_Project_02112022\PRN_Project_01112022\PRN_Project_011122\PRN_Project\Views\Test\Details.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 51 "D:\FU_Hub\FA22\PRN211\Project\FINAL_PROJECT\Code\PRN_Project_03112022\PRN_Project_02112022\PRN_Project_01112022\PRN_Project_011122\PRN_Project\Views\Test\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 54 "D:\FU_Hub\FA22\PRN211\Project\FINAL_PROJECT\Code\PRN_Project_03112022\PRN_Project_02112022\PRN_Project_01112022\PRN_Project_011122\PRN_Project\Views\Test\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 57 "D:\FU_Hub\FA22\PRN211\Project\FINAL_PROJECT\Code\PRN_Project_03112022\PRN_Project_02112022\PRN_Project_01112022\PRN_Project_011122\PRN_Project\Views\Test\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BonusPoint));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 60 "D:\FU_Hub\FA22\PRN211\Project\FINAL_PROJECT\Code\PRN_Project_03112022\PRN_Project_02112022\PRN_Project_01112022\PRN_Project_011122\PRN_Project\Views\Test\Details.cshtml"
       Write(Html.DisplayFor(model => model.BonusPoint));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf2bdf596a0630bbd406439296e0fde3f75c9e3410947", async() => {
                WriteLiteral("Edit");
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
#nullable restore
#line 65 "D:\FU_Hub\FA22\PRN211\Project\FINAL_PROJECT\Code\PRN_Project_03112022\PRN_Project_02112022\PRN_Project_01112022\PRN_Project_011122\PRN_Project\Views\Test\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf2bdf596a0630bbd406439296e0fde3f75c9e3413177", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\n</div>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PRN_Project.Models.Account> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
