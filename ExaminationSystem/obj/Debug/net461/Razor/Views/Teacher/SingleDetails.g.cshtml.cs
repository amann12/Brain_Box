#pragma checksum "E:\MVC Major Projects\ExaminationSystem\ExaminationSystem\Views\Teacher\SingleDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22d85cc33c1ebaa83774eb3542b0226393ba93a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_SingleDetails), @"mvc.1.0.view", @"/Views/Teacher/SingleDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Teacher/SingleDetails.cshtml", typeof(AspNetCore.Views_Teacher_SingleDetails))]
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
#line 1 "E:\MVC Major Projects\ExaminationSystem\ExaminationSystem\Views\_ViewImports.cshtml"
using ExaminationSystem;

#line default
#line hidden
#line 2 "E:\MVC Major Projects\ExaminationSystem\ExaminationSystem\Views\_ViewImports.cshtml"
using ExaminationSystem.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22d85cc33c1ebaa83774eb3542b0226393ba93a6", @"/Views/Teacher/SingleDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71532c4a3d77c37772a5d3b2328561ef564e602f", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_SingleDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExaminationSystem.Models.Teacher>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Course", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\MVC Major Projects\ExaminationSystem\ExaminationSystem\Views\Teacher\SingleDetails.cshtml"
  
    ViewData["Title"] = "SingleDetails";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(137, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(1784, 1330, true);
            WriteLiteral(@"


<style>
    body {
        margin-top: 20px;
        color: #1a202c;
        text-align: left;
        background-color: #e2e8f0;
    }

    .main-body {
        padding: 15px;
    }

    .card {
        box-shadow: 0 1px 3px 0 rgba(0,0,0,.1), 0 1px 2px 0 rgba(0,0,0,.06);
    }

    .card {
        position: relative;
        display: flex;
        flex-direction: column;
        min-width: 0;
        word-wrap: break-word;
        background-color: #fff;
        background-clip: border-box;
        border: 0 solid rgba(0,0,0,.125);
        border-radius: .25rem;
    }

    .card-body {
        flex: 1 1 auto;
        min-height: 1px;
        padding: 1rem;
    }

    .gutters-sm {
        margin-right: -8px;
        margin-left: -8px;
    }

        .gutters-sm > .col, .gutters-sm > [class*=col-] {
            padding-right: 8px;
            padding-left: 8px;
        }

    .mb-3, .my-3 {
        margin-bottom: 1rem !important;
    }

    .bg-gray-300 {");
            WriteLiteral(@"
        background-color: #e2e8f0;
    }

    .h-100 {
        height: 100% !important;
    }

    .shadow-none {
        box-shadow: none !important;
    }

    a {
        color: white;
    }
</style>

<div class=""container"">
    <div class=""main-body"">

        <!-- Breadcrumb -->
");
            EndContext();
            BeginContext(3535, 67, true);
            WriteLiteral("\r\n        <button type=\"button\" class=\"btn btn-info\">\r\n            ");
            EndContext();
            BeginContext(3602, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22d85cc33c1ebaa83774eb3542b0226393ba93a66685", async() => {
                BeginContext(3665, 22, true);
                WriteLiteral("Back to Course Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
            BeginContext(3691, 86, true);
            WriteLiteral("\r\n        </button>\r\n        <button type=\"button\" class=\"btn btn-info\">\r\n            ");
            EndContext();
            BeginContext(3777, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22d85cc33c1ebaa83774eb3542b0226393ba93a68573", async() => {
                BeginContext(3833, 12, true);
                WriteLiteral("Back to Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3849, 527, true);
            WriteLiteral(@"
        </button>

        <!-- /Breadcrumb -->

        <div class=""row gutters-sm"">
            <div class=""col-md-4 mb-3"">
                <div class=""card"">
                    <div class=""card-body"">
                        <div class=""d-flex flex-column align-items-center text-center"">
                            <img src=""https://bootdey.com/img/Content/avatar/avatar7.png"" alt=""Admin"" class=""rounded-circle"" width=""150"">
                            <div class=""mt-3"">
                                <h4>");
            EndContext();
            BeginContext(4377, 11, false);
#line 149 "E:\MVC Major Projects\ExaminationSystem\ExaminationSystem\Views\Teacher\SingleDetails.cshtml"
                               Write(Model.tName);

#line default
#line hidden
            EndContext();
            BeginContext(4388, 603, true);
            WriteLiteral(@"</h4>
                                

                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-8"">
                <div class=""card mb-3"">
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col-sm-3"">
                                <h6 class=""mb-0"">Teacher Name</h6>
                            </div>
                            <div class=""col-sm-9 text-secondary"">
                                ");
            EndContext();
            BeginContext(4992, 11, false);
#line 165 "E:\MVC Major Projects\ExaminationSystem\ExaminationSystem\Views\Teacher\SingleDetails.cshtml"
                           Write(Model.tName);

#line default
#line hidden
            EndContext();
            BeginContext(5003, 392, true);
            WriteLiteral(@"
                            </div>
                        </div>
                        <hr>
                        <div class=""row"">
                            <div class=""col-sm-3"">
                                <h6 class=""mb-0"">Gender</h6>
                            </div>
                            <div class=""col-sm-9 text-secondary"">
                                ");
            EndContext();
            BeginContext(5396, 13, false);
#line 174 "E:\MVC Major Projects\ExaminationSystem\ExaminationSystem\Views\Teacher\SingleDetails.cshtml"
                           Write(Model.tGender);

#line default
#line hidden
            EndContext();
            BeginContext(5409, 397, true);
            WriteLiteral(@"
                            </div>
                        </div>
                        <hr>
                        <div class=""row"">
                            <div class=""col-sm-3"">
                                <h6 class=""mb-0"">Blood Group</h6>
                            </div>
                            <div class=""col-sm-9 text-secondary"">
                                ");
            EndContext();
            BeginContext(5807, 17, false);
#line 183 "E:\MVC Major Projects\ExaminationSystem\ExaminationSystem\Views\Teacher\SingleDetails.cshtml"
                           Write(Model.tBloodGroup);

#line default
#line hidden
            EndContext();
            BeginContext(5824, 394, true);
            WriteLiteral(@"
                            </div>
                        </div>
                        <hr>
                        <div class=""row"">
                            <div class=""col-sm-3"">
                                <h6 class=""mb-0"">Email Id</h6>
                            </div>
                            <div class=""col-sm-9 text-secondary"">
                                ");
            EndContext();
            BeginContext(6219, 14, false);
#line 192 "E:\MVC Major Projects\ExaminationSystem\ExaminationSystem\Views\Teacher\SingleDetails.cshtml"
                           Write(Model.tEmailId);

#line default
#line hidden
            EndContext();
            BeginContext(6233, 399, true);
            WriteLiteral(@"
                            </div>
                        </div>
                        <hr>
                        <div class=""row"">
                            <div class=""col-sm-3"">
                                <h6 class=""mb-0"">Mobile Number</h6>
                            </div>
                            <div class=""col-sm-9 text-secondary"">
                                ");
            EndContext();
            BeginContext(6633, 19, false);
#line 201 "E:\MVC Major Projects\ExaminationSystem\ExaminationSystem\Views\Teacher\SingleDetails.cshtml"
                           Write(Model.tMobileNumber);

#line default
#line hidden
            EndContext();
            BeginContext(6652, 399, true);
            WriteLiteral(@"
                            </div>
                        </div>
                        <hr>
                        <div class=""row"">
                            <div class=""col-sm-3"">
                                <h6 class=""mb-0"">Qualification</h6>
                            </div>
                            <div class=""col-sm-9 text-secondary"">
                                ");
            EndContext();
            BeginContext(7052, 20, false);
#line 210 "E:\MVC Major Projects\ExaminationSystem\ExaminationSystem\Views\Teacher\SingleDetails.cshtml"
                           Write(Model.tQualification);

#line default
#line hidden
            EndContext();
            BeginContext(7072, 393, true);
            WriteLiteral(@"
                            </div>
                        </div>
                        <hr>
                        <div class=""row"">
                            <div class=""col-sm-3"">
                                <h6 class=""mb-0"">Address</h6>
                            </div>
                            <div class=""col-sm-9 text-secondary"">
                                ");
            EndContext();
            BeginContext(7466, 14, false);
#line 219 "E:\MVC Major Projects\ExaminationSystem\ExaminationSystem\Views\Teacher\SingleDetails.cshtml"
                           Write(Model.tAddress);

#line default
#line hidden
            EndContext();
            BeginContext(7480, 212, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <hr>\r\n\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExaminationSystem.Models.Teacher> Html { get; private set; }
    }
}
#pragma warning restore 1591
