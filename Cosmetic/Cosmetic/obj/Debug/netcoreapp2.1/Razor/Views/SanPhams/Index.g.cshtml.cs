#pragma checksum "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b01e0c105532c6ce9ea4b4e434b46bd0eb1646b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SanPhams_Index), @"mvc.1.0.view", @"/Views/SanPhams/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SanPhams/Index.cshtml", typeof(AspNetCore.Views_SanPhams_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b01e0c105532c6ce9ea4b4e434b46bd0eb1646b", @"/Views/SanPhams/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45e46a70e22261359788c4d073dc157268b599e9", @"/Views/_ViewImports.cshtml")]
    public class Views_SanPhams_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Cosmetic.Models.SanPham>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 100px; width: 100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
  
    ViewData["Title"] = "| Sản phẩm";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(145, 230, true);
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n        <h1 class=\"page-header\">Sản phẩm</h1>\r\n    </div>\r\n    <!-- /.col-lg-12 -->\r\n</div>\r\n<!-- /.row -->\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(375, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68fc0281809d40d79b736df01c62742e", async() => {
                BeginContext(398, 8, true);
                WriteLiteral("Thêm mới");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(410, 431, true);
            WriteLiteral(@"
        </p>
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                Danh sách
            </div>
            <!-- /.panel-heading -->
            <div class=""panel-body"">
                <table width=""100%"" class=""table table-striped table-bordered table-hover"" id=""dataTables-example"">
                    <thead>
                        <tr>
                            <th>");
            EndContext();
            BeginContext(842, 40, false);
#line 28 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.MaSp));

#line default
#line hidden
            EndContext();
            BeginContext(882, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(922, 41, false);
#line 29 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.TenSp));

#line default
#line hidden
            EndContext();
            BeginContext(963, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1003, 42, false);
#line 30 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.MaLoai));

#line default
#line hidden
            EndContext();
            BeginContext(1045, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1085, 40, false);
#line 31 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.MoTa));

#line default
#line hidden
            EndContext();
            BeginContext(1125, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1165, 42, false);
#line 32 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.DonGia));

#line default
#line hidden
            EndContext();
            BeginContext(1207, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1247, 40, false);
#line 33 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Hinh));

#line default
#line hidden
            EndContext();
            BeginContext(1287, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1327, 41, false);
#line 34 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Hinh2));

#line default
#line hidden
            EndContext();
            BeginContext(1368, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1408, 41, false);
#line 35 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.GiaCu));

#line default
#line hidden
            EndContext();
            BeginContext(1449, 175, true);
            WriteLiteral("</th>\r\n                            <th></th>\r\n                            <th></th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 41 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1705, 89, true);
            WriteLiteral("                            <tr class=\"odd gradeX\">\r\n                                <td>");
            EndContext();
            BeginContext(1795, 39, false);
#line 44 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MaSp));

#line default
#line hidden
            EndContext();
            BeginContext(1834, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1878, 40, false);
#line 45 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.TenSp));

#line default
#line hidden
            EndContext();
            BeginContext(1918, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1962, 41, false);
#line 46 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MaLoai));

#line default
#line hidden
            EndContext();
            BeginContext(2003, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2047, 39, false);
#line 47 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MoTa));

#line default
#line hidden
            EndContext();
            BeginContext(2086, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2130, 41, false);
#line 48 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.DonGia));

#line default
#line hidden
            EndContext();
            BeginContext(2171, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2214, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6e886e1fee3449a09096f6296623426f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2260, "~/Hinh/beauty/", 2260, 14, true);
#line 49 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
AddHtmlAttributeValue("", 2274, item.Hinh, 2274, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2288, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2331, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1be3b822fc5247b0923d3c98cc1ce3da", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2377, "~/Hinh/beauty/", 2377, 14, true);
#line 50 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
AddHtmlAttributeValue("", 2391, item.Hinh2, 2391, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2406, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2450, 40, false);
#line 51 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.GiaCu));

#line default
#line hidden
            EndContext();
            BeginContext(2490, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2533, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1524fd61bde14566b9436bf55b722e7f", async() => {
                BeginContext(2580, 8, true);
                WriteLiteral("Cập nhật");
                EndContext();
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
#line 52 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
                                                           WriteLiteral(item.MaSp);

#line default
#line hidden
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
            EndContext();
            BeginContext(2592, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2635, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27905a9da8a44634992a0a6ae02c0e3a", async() => {
                BeginContext(2684, 3, true);
                WriteLiteral("Xóa");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
                                                             WriteLiteral(item.MaSp);

#line default
#line hidden
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
            EndContext();
            BeginContext(2691, 42, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n");
            EndContext();
#line 55 "C:\Users\vi\Documents\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2760, 260, true);
            WriteLiteral(@"                    </tbody>
                </table>
                <!-- /.table-responsive -->
            </div>
            <!-- /.panel-body -->
        </div>
        <!-- /.panel -->
    </div>
    <!-- /.col-lg-12 -->
</div>
<!-- /.row -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Cosmetic.Models.SanPham>> Html { get; private set; }
    }
}
#pragma warning restore 1591
