#pragma checksum "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a11540d19569ad01ef4e7aecd11022f96db10854"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SanPhams_Delete), @"mvc.1.0.view", @"/Views/SanPhams/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SanPhams/Delete.cshtml", typeof(AspNetCore.Views_SanPhams_Delete))]
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
#line 1 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\_ViewImports.cshtml"
using Cosmetic;

#line default
#line hidden
#line 2 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\_ViewImports.cshtml"
using Cosmetic.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a11540d19569ad01ef4e7aecd11022f96db10854", @"/Views/SanPhams/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45e46a70e22261359788c4d073dc157268b599e9", @"/Views/_ViewImports.cshtml")]
    public class Views_SanPhams_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cosmetic.Models.SanPham>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Delete.cshtml"
  
    ViewData["Title"] = "| Xóa sản phẩm";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(136, 45, true);
            WriteLiteral("\r\n<br />\r\n<br />\r\n\r\n<h3>Bạn có chắc chắn xóa ");
            EndContext();
            BeginContext(182, 37, false);
#line 11 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Delete.cshtml"
                    Write(Html.DisplayFor(model => model.TenSp));

#line default
#line hidden
            EndContext();
            BeginContext(219, 120, true);
            WriteLiteral(" ? </h3>\r\n<div>\r\n    <h4>Thông tin sản phẩm</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(340, 40, false);
#line 17 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MaSp));

#line default
#line hidden
            EndContext();
            BeginContext(380, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(424, 36, false);
#line 20 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MaSp));

#line default
#line hidden
            EndContext();
            BeginContext(460, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(504, 41, false);
#line 23 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TenSp));

#line default
#line hidden
            EndContext();
            BeginContext(545, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(589, 37, false);
#line 26 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TenSp));

#line default
#line hidden
            EndContext();
            BeginContext(626, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(670, 42, false);
#line 29 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MaLoai));

#line default
#line hidden
            EndContext();
            BeginContext(712, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(756, 38, false);
#line 32 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MaLoai));

#line default
#line hidden
            EndContext();
            BeginContext(794, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(838, 40, false);
#line 35 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MoTa));

#line default
#line hidden
            EndContext();
            BeginContext(878, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(922, 36, false);
#line 38 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MoTa));

#line default
#line hidden
            EndContext();
            BeginContext(958, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1002, 42, false);
#line 41 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DonGia));

#line default
#line hidden
            EndContext();
            BeginContext(1044, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1088, 38, false);
#line 44 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DonGia));

#line default
#line hidden
            EndContext();
            BeginContext(1126, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1170, 40, false);
#line 47 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Hinh));

#line default
#line hidden
            EndContext();
            BeginContext(1210, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1253, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fd05b6ceb71a485d97adc5be0aa06c3c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1263, "~/Hinh/beauty/", 1263, 14, true);
#line 50 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Delete.cshtml"
AddHtmlAttributeValue("", 1277, Model.Hinh, 1277, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1305, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1349, 41, false);
#line 53 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Hinh2));

#line default
#line hidden
            EndContext();
            BeginContext(1390, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1433, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d3e272a0789647b89edc3c6d09e97a68", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1443, "~/Hinh/beauty/", 1443, 14, true);
#line 56 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Delete.cshtml"
AddHtmlAttributeValue("", 1457, Model.Hinh2, 1457, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1486, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1530, 41, false);
#line 59 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.GiaCu));

#line default
#line hidden
            EndContext();
            BeginContext(1571, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1615, 37, false);
#line 62 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayFor(model => model.GiaCu));

#line default
#line hidden
            EndContext();
            BeginContext(1652, 34, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(1686, 212, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f12a688e54f84b0d993aa31aa371bc72", async() => {
                BeginContext(1712, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1722, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9f8b3fe041a24d0d8d4e54336e0fcc04", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 67 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MaSp);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1760, 92, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Xóa\" class=\"btn btn-default\" /> <br /><br />\r\n        ");
                EndContext();
                BeginContext(1852, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdccf03a7b0f4bddb8b373ec6881696a", async() => {
                    BeginContext(1874, 7, true);
                    WriteLiteral("Quay về");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
                BeginContext(1885, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1898, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cosmetic.Models.SanPham> Html { get; private set; }
    }
}
#pragma warning restore 1591
