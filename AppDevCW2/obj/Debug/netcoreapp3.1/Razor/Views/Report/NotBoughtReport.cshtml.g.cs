#pragma checksum "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\NotBoughtReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bac0b7bccf1a74368bba06d89084b689b12d4d5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_NotBoughtReport), @"mvc.1.0.view", @"/Views/Report/NotBoughtReport.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bac0b7bccf1a74368bba06d89084b689b12d4d5d", @"/Views/Report/NotBoughtReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4c1a98010c5d0f32a49a612ad68677a8c00fe37", @"/Views/_ViewImports.cshtml")]
    public class Views_Report_NotBoughtReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppDevCW2.ViewModels.NotBoughtViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\NotBoughtReport.cshtml"
  
    ViewData["Title"] = "Not Bought Report";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Not Bought Report</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\NotBoughtReport.cshtml"
           Write(Html.DisplayNameFor(model => model.customerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\NotBoughtReport.cshtml"
           Write(Html.DisplayNameFor(model => model.customerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\NotBoughtReport.cshtml"
           Write(Html.DisplayNameFor(model => model.lastSaleDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\NotBoughtReport.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 29 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\NotBoughtReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.customerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\NotBoughtReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.customerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\NotBoughtReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.lastSaleDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 38 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\NotBoughtReport.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppDevCW2.ViewModels.NotBoughtViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
