#pragma checksum "C:\Users\rishi\source\repos\IndiaMart\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8410e48f2ee4d8f2ca9673a9831aec4e11cfba8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8410e48f2ee4d8f2ca9673a9831aec4e11cfba8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc1a07fa2ab43e13d65b5cfdb92239a8625e15fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\rishi\source\repos\IndiaMart\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""jumbotron"" style=""background-color:powderblue"" ;>
    <h1 style=""color:black;"">India Mart</h1>
    <p class=""lead"" style=""background-color:powderblue; color :darkblue;"">Welcome To IndiaMart. Here you can find list of different products and their sellers. </p>

</div>

<div class=""row"">
    <div class=""col-md-4"" style=""background-color: lightyellow;"">
        <h2>SELLERS</h2>
        <p>
            Below you can find the list of all available Sellers.
        </p>
        <p><a class=""btn btn-success"" href=""https://localhost:44339/Seller/Index"">Go to Sellers &spades;</a></p>
    </div>
    <div class=""col-md-4"">
        <p></p>
        <p></p>
    </div>
    <div class=""col-md-4"" style=""background-color: lightyellow; "">
        <h2>PRODUCTS</h2> 
        <p>Below you can find the list of all available Prodcts.</p>
        <p><a class=""btn btn-success"" href=""https://localhost:44339/Product/Index"">Go to Products &clubs;</a></p>
    </div>

</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591