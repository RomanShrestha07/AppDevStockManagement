#pragma checksum "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\OutOfStockReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1748fc1f46a1928590606bf17b6c3dd136cbb4f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_OutOfStockReport), @"mvc.1.0.view", @"/Views/Report/OutOfStockReport.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1748fc1f46a1928590606bf17b6c3dd136cbb4f6", @"/Views/Report/OutOfStockReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4c1a98010c5d0f32a49a612ad68677a8c00fe37", @"/Views/_ViewImports.cshtml")]
    public class Views_Report_OutOfStockReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppDevCW2.ViewModels.OutOfStockViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\OutOfStockReport.cshtml"
  
    ViewData["Title"] = "Out of Stock Report";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Out of Stock Report</h1>\r\n\r\n<div class=\"float-right\" style=\"margin-bottom: 15px;\">\r\n");
#nullable restore
#line 10 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\OutOfStockReport.cshtml"
 using (Html.BeginForm("OutOfStockReport", "Report", FormMethod.Get))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <b>Sort: </b> ");
#nullable restore
#line 12 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\OutOfStockReport.cshtml"
             Write(Html.RadioButton("option", "Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <label> Name </label> ");
#nullable restore
#line 12 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\OutOfStockReport.cshtml"
                                                                       Write(Html.RadioButton("option", "Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <label> Date </label> <input class=\"btn btn-outline-secondary my-2 my-sm-0\" type=\"submit\" name=\"submit\" value=\"Sort\" />\r\n");
#nullable restore
#line 13 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\OutOfStockReport.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\OutOfStockReport.cshtml"
           Write(Html.DisplayNameFor(model => model.itemCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\OutOfStockReport.cshtml"
           Write(Html.DisplayNameFor(model => model.itemName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\OutOfStockReport.cshtml"
           Write(Html.DisplayNameFor(model => model.itemQuantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\OutOfStockReport.cshtml"
           Write(Html.DisplayNameFor(model => model.stockedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\OutOfStockReport.cshtml"
           Write(Html.DisplayNameFor(model => model.itemCategory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 38 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\OutOfStockReport.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\OutOfStockReport.cshtml"
           Write(Html.DisplayFor(modelItem => item.itemCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\OutOfStockReport.cshtml"
           Write(Html.DisplayFor(modelItem => item.itemName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\OutOfStockReport.cshtml"
           Write(Html.DisplayFor(modelItem => item.itemQuantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\OutOfStockReport.cshtml"
           Write(Html.DisplayFor(modelItem => item.stockedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\OutOfStockReport.cshtml"
           Write(Html.DisplayFor(modelItem => item.itemCategory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 57 "C:\Users\User\Desktop\AppDevCW2\Project3\AppDevCW2\Views\Report\OutOfStockReport.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppDevCW2.ViewModels.OutOfStockViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
