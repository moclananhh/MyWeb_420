#pragma checksum "D:\FU_Hub\FA22\PRN211\Project\FINAL_PROJECT\Code\PRN_Project_03112022\PRN_Project_02112022\PRN_Project_01112022\PRN_Project_011122\PRN_Project\Views\AccountsInfor\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f11193cd0ed5c622203cd17a2e7d3e162efb841e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AccountsInfor_Details), @"mvc.1.0.view", @"/Views/AccountsInfor/Details.cshtml")]
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
#nullable restore
#line 2 "D:\FU_Hub\FA22\PRN211\Project\FINAL_PROJECT\Code\PRN_Project_03112022\PRN_Project_02112022\PRN_Project_01112022\PRN_Project_011122\PRN_Project\Views\AccountsInfor\Details.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f11193cd0ed5c622203cd17a2e7d3e162efb841e", @"/Views/AccountsInfor/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"338c0757b3221eca7c40b229392d324a233b1778", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AccountsInfor_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PRN_Project.Models.Account>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/app.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\FU_Hub\FA22\PRN211\Project\FINAL_PROJECT\Code\PRN_Project_03112022\PRN_Project_02112022\PRN_Project_01112022\PRN_Project_011122\PRN_Project\Views\AccountsInfor\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<thead>\n\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f11193cd0ed5c622203cd17a2e7d3e162efb841e5559", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</thead>
<div class=""app"">
    <div class=""layout"">
        <div class=""page-container"">
            <!-- Content Wrapper START -->
            <div class=""main-content1"">
                <div class=""page-header1 no-gutters has-tab"">
                    <h2 class=""font-weight-normal"">Setting</h2>
                    <ul class=""nav nav-tabs1"">
                        <li class=""nav-item1"">
                            <a class=""nav-link1 active1 font-weight-bold"" data-toggle=""tab"" href=""#tab-account"">Account</a>
                        </li>

                    </ul>
                </div>
                <div class=""container"">
                    <div class=""tab-content m-t-15"">
                        <div class=""tab-pane1 fade1 show1 active1"" id=""tab-account"">
                            <div class=""card1"">
                                <div class=""card1-header1"">
                                    <h4 class=""card1-title1 font-weight-bold"">Basic Infomation</h4>
                                </div>
  ");
            WriteLiteral(@"                              <div class=""card1-body1"">
                                    <div class=""media align-items-center"">
                                        <div class=""avatar1 avatar-image  m-h-10 m-r-15"" style=""height: 80px; width: 80px"">
                                            <img src=""https://cdn-icons-png.flaticon.com/512/149/149071.png"" alt=""Không tìm thấy"">
                                        </div>
                                        <div class=""m-l-20 m-r-20"">
                                            <h5 class=""m-b-5 font-size-18"">Change Avatar</h5>
                                            <p class=""opacity-07 font-size-13 m-b-0"">
                                                Recommended Dimensions: <br>
                                                120x120 Max fil size: 5MB
                                            </p>
                                        </div>
                                        <div>
                                            <butto");
            WriteLiteral("n class=\"btne btne-tone btne-primary\">Upload</button>\n                                        </div>\n                                    </div>\n                                    <hr class=\"m-v-25\">\n");
#nullable restore
#line 49 "D:\FU_Hub\FA22\PRN211\Project\FINAL_PROJECT\Code\PRN_Project_03112022\PRN_Project_02112022\PRN_Project_01112022\PRN_Project_011122\PRN_Project\Views\AccountsInfor\Details.cshtml"
                                     foreach (var item in Model)
                                    {
                                        if (@item.Username == @Context.Session.GetString("username"))
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f11193cd0ed5c622203cd17a2e7d3e162efb841e9627", async() => {
                WriteLiteral(@"
                                                <div class=""form-row"">
                                                    <div class=""form-group1 col-md-6ver2"">
                                                        <label1 class=""font-weight-semibold"" for=""userName"">User Name:</label1>
                                                        <input type=""text"" class=""form-control1"" id=""userName"" placeholder=""User Name""");
                BeginWriteAttribute("value", " value=\"", 3211, "\"", 3233, 1);
#nullable restore
#line 57 "D:\FU_Hub\FA22\PRN211\Project\FINAL_PROJECT\Code\PRN_Project_03112022\PRN_Project_02112022\PRN_Project_01112022\PRN_Project_011122\PRN_Project\Views\AccountsInfor\Details.cshtml"
WriteAttributeValue("", 3219, item.Username, 3219, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly>
                                                    </div>
                                                    <div class=""form-group1 col-md-6ver2"">
                                                        <label1 class=""font-weight-semibold"" for=""password"">Password:</label1>
                                                        <input type=""text"" class=""form-control1"" id=""password"" placeholder=""password""");
                BeginWriteAttribute("value", " value=\"", 3655, "\"", 3677, 1);
#nullable restore
#line 61 "D:\FU_Hub\FA22\PRN211\Project\FINAL_PROJECT\Code\PRN_Project_03112022\PRN_Project_02112022\PRN_Project_01112022\PRN_Project_011122\PRN_Project\Views\AccountsInfor\Details.cshtml"
WriteAttributeValue("", 3663, item.Password, 3663, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly>
                                                    </div>
                                                </div>
                                                <div class=""form-row"">
                                                    <div class=""form-group1 col-md-4"">
                                                        <label1 class=""font-weight-semibold"" for=""email"">Email:</label1>
                                                        <input type=""text"" class=""form-control1"" id=""email"" placeholder=""Email""");
                BeginWriteAttribute("value", " value=\"", 4209, "\"", 4228, 1);
#nullable restore
#line 67 "D:\FU_Hub\FA22\PRN211\Project\FINAL_PROJECT\Code\PRN_Project_03112022\PRN_Project_02112022\PRN_Project_01112022\PRN_Project_011122\PRN_Project\Views\AccountsInfor\Details.cshtml"
WriteAttributeValue("", 4217, item.Email, 4217, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly>
                                                    </div>
                                                    <div class=""form-group1 col-md-4"">
                                                        <label1 class=""font-weight-semibold"" for=""phoneNumber"">Phone number:</label1>
                                                        <input type=""text"" class=""form-control1"" id=""phoneNumber"" placeholder=""Phone Number""");
                BeginWriteAttribute("value", " value=\"", 4660, "\"", 4679, 1);
#nullable restore
#line 71 "D:\FU_Hub\FA22\PRN211\Project\FINAL_PROJECT\Code\PRN_Project_03112022\PRN_Project_02112022\PRN_Project_01112022\PRN_Project_011122\PRN_Project\Views\AccountsInfor\Details.cshtml"
WriteAttributeValue("", 4668, item.Phone, 4668, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly>
                                                    </div>
                                                    <div class=""form-group1 col-md-4"">
                                                        <label1 class=""font-weight-semibold"" for=""Address"">Address:</label1>
                                                        <input type=""text"" class=""form-control1"" id=""address"" placeholder=""Address""");
                BeginWriteAttribute("value", " value=\"", 5093, "\"", 5114, 1);
#nullable restore
#line 75 "D:\FU_Hub\FA22\PRN211\Project\FINAL_PROJECT\Code\PRN_Project_03112022\PRN_Project_02112022\PRN_Project_01112022\PRN_Project_011122\PRN_Project\Views\AccountsInfor\Details.cshtml"
WriteAttributeValue("", 5101, item.Address, 5101, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly>
                                                    </div>
                                                </div>

                                                <button class=""btne btne-tone btne-primary"" style=""color:white"" type=""submit"">
                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f11193cd0ed5c622203cd17a2e7d3e162efb841e14871", async() => {
                    WriteLiteral("Edit");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "D:\FU_Hub\FA22\PRN211\Project\FINAL_PROJECT\Code\PRN_Project_03112022\PRN_Project_02112022\PRN_Project_01112022\PRN_Project_011122\PRN_Project\Views\AccountsInfor\Details.cshtml"
                                                                           WriteLiteral(item.Id);

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
                WriteLiteral("\n                                                </button>\n\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 84 "D:\FU_Hub\FA22\PRN211\Project\FINAL_PROJECT\Code\PRN_Project_03112022\PRN_Project_02112022\PRN_Project_01112022\PRN_Project_011122\PRN_Project\Views\AccountsInfor\Details.cshtml"
                                        }

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Content Wrapper END -->
        </div>
        <!-- Page Container END -->
    </div>
</div>

<!-- Core Vendors JS -->
<script src=""assets/js/vendors.min.js""></script>

<!-- page js -->
<!-- Core JS -->
<script src=""assets/js/app.min.js""></script>
<script src=""js/manager.js"" type=""text/javascript""></script>





");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PRN_Project.Models.Account>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
