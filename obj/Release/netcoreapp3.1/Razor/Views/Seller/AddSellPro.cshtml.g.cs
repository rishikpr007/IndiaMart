#pragma checksum "C:\Users\rishi\source\repos\IndiaMart\Views\Seller\AddSellPro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "833045219d37966d39488a8aee53fa83bbbce5aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Seller_AddSellPro), @"mvc.1.0.view", @"/Views/Seller/AddSellPro.cshtml")]
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
#line 1 "C:\Users\rishi\source\repos\IndiaMart\Views\_ViewImports.cshtml"
using IndiaMart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rishi\source\repos\IndiaMart\Views\_ViewImports.cshtml"
using IndiaMart.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"833045219d37966d39488a8aee53fa83bbbce5aa", @"/Views/Seller/AddSellPro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc1a07fa2ab43e13d65b5cfdb92239a8625e15fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Seller_AddSellPro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndiaMart.Models.SellPro>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\rishi\source\repos\IndiaMart\Views\Seller\AddSellPro.cshtml"
  
    ViewData["Title"] = "AddSellPro";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Add Products</h2>\r\n\r\n\r\n");
#nullable restore
#line 11 "C:\Users\rishi\source\repos\IndiaMart\Views\Seller\AddSellPro.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\rishi\source\repos\IndiaMart\Views\Seller\AddSellPro.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\" style=\"background-color:aqua;\">\r\n        <h4>Select from the products below</h4>\r\n        <hr />\r\n        ");
#nullable restore
#line 18 "C:\Users\rishi\source\repos\IndiaMart\Views\Seller\AddSellPro.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 22 "C:\Users\rishi\source\repos\IndiaMart\Views\Seller\AddSellPro.cshtml"
       Write(Html.LabelFor(model => model.Product, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 24 "C:\Users\rishi\source\repos\IndiaMart\Views\Seller\AddSellPro.cshtml"
           Write(Html.DropDownListFor(model => model.ProductID, (IEnumerable<SelectListItem>)ViewBag.ProductList, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                ");
#nullable restore
#line 26 "C:\Users\rishi\source\repos\IndiaMart\Views\Seller\AddSellPro.cshtml"
           Write(Html.ValidationMessageFor(model => model.ProductID, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 36 "C:\Users\rishi\source\repos\IndiaMart\Views\Seller\AddSellPro.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 39 "C:\Users\rishi\source\repos\IndiaMart\Views\Seller\AddSellPro.cshtml"
Write(Html.ActionLink("Back to List", "Seller"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndiaMart.Models.SellPro> Html { get; private set; }
    }
}
#pragma warning restore 1591