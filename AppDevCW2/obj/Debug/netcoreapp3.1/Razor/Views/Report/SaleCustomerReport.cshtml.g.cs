#pragma checksum "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\SaleCustomerReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a4be0242bb67054c8c8766646b8c7f0b69ee237"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_SaleCustomerReport), @"mvc.1.0.view", @"/Views/Report/SaleCustomerReport.cshtml")]
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
#line 1 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\_ViewImports.cshtml"
using AppDevCW2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\_ViewImports.cshtml"
using AppDevCW2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a4be0242bb67054c8c8766646b8c7f0b69ee237", @"/Views/Report/SaleCustomerReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4c1a98010c5d0f32a49a612ad68677a8c00fe37", @"/Views/_ViewImports.cshtml")]
    public class Views_Report_SaleCustomerReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppDevCW2.ViewModels.SaleCustomerViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom: 15px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\SaleCustomerReport.cshtml"
  
    ViewData["Title"] = "Sale Customer Report";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Sale Customer Report</h1>\r\n<p>User enters a customer name. Only the details of customers that have made a purchase in last 31 days are displayed.</p>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a4be0242bb67054c8c8766646b8c7f0b69ee2374467", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\SaleCustomerReport.cshtml"
     using (Html.BeginForm("SaleCustomerReport", "Report", FormMethod.Get))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input class=\"form-control mr-sm-2\" name=\"search\" id=\"search\" type=\"search\" placeholder=\"Search\" aria-label=\"Search\">\r\n        <button class=\"btn btn-outline-secondary my-2 my-sm-0\" type=\"submit\">Search</button>\r\n        <br />\r\n");
#nullable restore
#line 16 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\SaleCustomerReport.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\SaleCustomerReport.cshtml"
           Write(Html.DisplayNameFor(model => model.customerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\SaleCustomerReport.cshtml"
           Write(Html.DisplayNameFor(model => model.saleDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\SaleCustomerReport.cshtml"
           Write(Html.DisplayNameFor(model => model.saleQuantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\SaleCustomerReport.cshtml"
           Write(Html.DisplayNameFor(model => model.unitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\SaleCustomerReport.cshtml"
           Write(Html.DisplayNameFor(model => model.totalAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\SaleCustomerReport.cshtml"
           Write(Html.DisplayNameFor(model => model.itemName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 44 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\SaleCustomerReport.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\SaleCustomerReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.customerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\SaleCustomerReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.saleDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\SaleCustomerReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.saleQuantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\SaleCustomerReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.unitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 60 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\SaleCustomerReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.totalAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\SaleCustomerReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.itemName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 66 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\SaleCustomerReport.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppDevCW2.ViewModels.SaleCustomerViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
