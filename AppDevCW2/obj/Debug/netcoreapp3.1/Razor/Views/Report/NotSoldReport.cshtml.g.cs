#pragma checksum "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\NotSoldReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a99e4b5f8eebf563d5786fcba71ef49f6c2df0ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_NotSoldReport), @"mvc.1.0.view", @"/Views/Report/NotSoldReport.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a99e4b5f8eebf563d5786fcba71ef49f6c2df0ec", @"/Views/Report/NotSoldReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4c1a98010c5d0f32a49a612ad68677a8c00fe37", @"/Views/_ViewImports.cshtml")]
    public class Views_Report_NotSoldReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppDevCW2.ViewModels.NotSoldViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\NotSoldReport.cshtml"
  
    ViewData["Title"] = "Not Sold Report";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Not Sold Report</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\NotSoldReport.cshtml"
           Write(Html.DisplayNameFor(model => model.itemCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\NotSoldReport.cshtml"
           Write(Html.DisplayNameFor(model => model.itemName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\NotSoldReport.cshtml"
           Write(Html.DisplayNameFor(model => model.itemQuantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\NotSoldReport.cshtml"
           Write(Html.DisplayNameFor(model => model.lastSaleDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\NotSoldReport.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\NotSoldReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.itemCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\NotSoldReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.itemName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\NotSoldReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.itemQuantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\NotSoldReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.lastSaleDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 44 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\NotSoldReport.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppDevCW2.ViewModels.NotSoldViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
