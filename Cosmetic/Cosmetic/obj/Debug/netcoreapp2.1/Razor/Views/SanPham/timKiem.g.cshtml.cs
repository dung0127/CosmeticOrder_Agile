#pragma checksum "D:\Clone\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPham\timKiem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "779fd40d262a70887ad18adcc0d9bd59c99cc8ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SanPham_timKiem), @"mvc.1.0.view", @"/Views/SanPham/timKiem.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SanPham/timKiem.cshtml", typeof(AspNetCore.Views_SanPham_timKiem))]
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
#line 1 "D:\Clone\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\_ViewImports.cshtml"
using Cosmetic;

#line default
#line hidden
#line 2 "D:\Clone\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\_ViewImports.cshtml"
using Cosmetic.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"779fd40d262a70887ad18adcc0d9bd59c99cc8ee", @"/Views/SanPham/timKiem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45e46a70e22261359788c4d073dc157268b599e9", @"/Views/_ViewImports.cshtml")]
    public class Views_SanPham_timKiem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Clone\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPham\timKiem.cshtml"
  
    ViewData["Title"] = "timKiem";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(92, 42, true);
            WriteLiteral("\r\n<h2>timKiem</h2>\r\n<div class=\"search\">\r\n");
            EndContext();
#line 9 "D:\Clone\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPham\timKiem.cshtml"
     using (Html.BeginForm("timSp", "SanPham"))
    {

#line default
#line hidden
            BeginContext(190, 211, true);
            WriteLiteral("        <div class=\"form-group\">\r\n            <input type=\"text\" name=\"keysearch\" value=\"\" placeholder=\"Điền tên sản phẩm\" />\r\n            <input type=\"submit\" name=\"submit\" value=\"Tìm kiếm\" />\r\n        </div>\r\n");
            EndContext();
#line 15 "D:\Clone\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPham\timKiem.cshtml"
    }

#line default
#line hidden
            BeginContext(408, 12, true);
            WriteLiteral("</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
