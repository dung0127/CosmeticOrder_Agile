#pragma checksum "D:\Nam-IV\Agile\CosmeticOrder_Agile-master\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1dfaf8e92ae32a46676b13a112a8d00d940e18f"
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
#line 1 "D:\Nam-IV\Agile\CosmeticOrder_Agile-master\Cosmetic\Cosmetic\Views\_ViewImports.cshtml"
using Cosmetic;

#line default
#line hidden
#line 2 "D:\Nam-IV\Agile\CosmeticOrder_Agile-master\Cosmetic\Cosmetic\Views\_ViewImports.cshtml"
using Cosmetic.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1dfaf8e92ae32a46676b13a112a8d00d940e18f", @"/Views/SanPhams/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f98c58fe1896fb78cbba9dc053d8a35efcfe68e", @"/Views/_ViewImports.cshtml")]
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
            BeginContext(44, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "D:\Nam-IV\Agile\CosmeticOrder_Agile-master\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
  
    ViewData["Title"] = "| Sản phẩm";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(139, 220, true);
            WriteLiteral("<div class=\"row\">\n    <div class=\"col-lg-12\">\n        <h1 class=\"page-header\">Sản phẩm</h1>\n    </div>\n    <!-- /.col-lg-12 -->\n</div>\n<!-- /.row -->\n<div class=\"row\">\n    <div class=\"col-lg-12\">\n        <p>\n            ");
            EndContext();
            BeginContext(359, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae2aa30a573b437a855a317dd0b207b4", async() => {
                BeginContext(382, 8, true);
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
            BeginContext(394, 420, true);
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
            BeginContext(815, 40, false);
#line 28 "D:\Nam-IV\Agile\CosmeticOrder_Agile-master\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.MaSp));

#line default
#line hidden
            EndContext();
            BeginContext(855, 38, true);
            WriteLiteral("</th>\n                            <th>");
            EndContext();
            BeginContext(894, 41, false);
#line 29 "D:\Nam-IV\Agile\CosmeticOrder_Agile-master\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.TenSp));

#line default
#line hidden
            EndContext();
            BeginContext(935, 38, true);
            WriteLiteral("</th>\n                            <th>");
            EndContext();
            BeginContext(974, 42, false);
#line 30 "D:\Nam-IV\Agile\CosmeticOrder_Agile-master\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.MaLoai));

#line default
#line hidden
            EndContext();
            BeginContext(1016, 38, true);
            WriteLiteral("</th>\n                            <th>");
            EndContext();
            BeginContext(1055, 40, false);
#line 31 "D:\Nam-IV\Agile\CosmeticOrder_Agile-master\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.MoTa));

#line default
#line hidden
            EndContext();
            BeginContext(1095, 38, true);
            WriteLiteral("</th>\n                            <th>");
            EndContext();
            BeginContext(1134, 42, false);
#line 32 "D:\Nam-IV\Agile\CosmeticOrder_Agile-master\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.DonGia));

#line default
#line hidden
            EndContext();
            BeginContext(1176, 38, true);
            WriteLiteral("</th>\n                            <th>");
            EndContext();
            BeginContext(1215, 40, false);
#line 33 "D:\Nam-IV\Agile\CosmeticOrder_Agile-master\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Hinh));

#line default
#line hidden
            EndContext();
            BeginContext(1255, 38, true);
            WriteLiteral("</th>\n                            <th>");
            EndContext();
            BeginContext(1294, 41, false);
#line 34 "D:\Nam-IV\Agile\CosmeticOrder_Agile-master\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Hinh2));

#line default
#line hidden
            EndContext();
            BeginContext(1335, 38, true);
            WriteLiteral("</th>\n                            <th>");
            EndContext();
            BeginContext(1374, 41, false);
#line 35 "D:\Nam-IV\Agile\CosmeticOrder_Agile-master\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.GiaCu));

#line default
#line hidden
            EndContext();
            BeginContext(1415, 169, true);
            WriteLiteral("</th>\n                            <th></th>\n                            <th></th>\n                        </tr>\n                    </thead>\n                    <tbody>\n");
            EndContext();
#line 41 "D:\Nam-IV\Agile\CosmeticOrder_Agile-master\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1663, 88, true);
            WriteLiteral("                            <tr class=\"odd gradeX\">\n                                <td>");
            EndContext();
            BeginContext(1752, 39, false);
#line 44 "D:\Nam-IV\Agile\CosmeticOrder_Agile-master\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MaSp));

#line default
#line hidden
            EndContext();
            BeginContext(1791, 42, true);
            WriteLiteral("</td>\n                                <td>");
            EndContext();
            BeginContext(1834, 40, false);
#line 45 "D:\Nam-IV\Agile\CosmeticOrder_Agile-master\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.TenSp));

#line default
#line hidden
            EndContext();
            BeginContext(1874, 42, true);
            WriteLiteral("</td>\n                                <td>");
            EndContext();
            BeginContext(1917, 41, false);
#line 46 "D:\Nam-IV\Agile\CosmeticOrder_Agile-master\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MaLoai));

#line default
#line hidden
            EndContext();
            BeginContext(1958, 42, true);
            WriteLiteral("</td>\n                                <td>");
            EndContext();
            BeginContext(2001, 39, false);
#line 47 "D:\Nam-IV\Agile\CosmeticOrder_Agile-master\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MoTa));

#line default
#line hidden
            EndContext();
            BeginContext(2040, 42, true);
            WriteLiteral("</td>\n                                <td>");
            EndContext();
            BeginContext(2083, 41, false);
#line 48 "D:\Nam-IV\Agile\CosmeticOrder_Agile-master\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.DonGia));

#line default
#line hidden
            EndContext();
            BeginContext(2124, 42, true);
            WriteLiteral("</td>\n                                <td>");
            EndContext();
            BeginContext(2166, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4eb56d26ca2e4da7989b52e4e2a9d865", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2212, "~/Hinh/beauty/", 2212, 14, true);
#line 49 "D:\Nam-IV\Agile\CosmeticOrder_Agile-master\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
AddHtmlAttributeValue("", 2226, item.Hinh, 2226, 10, false);

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
            BeginContext(2240, 42, true);
            WriteLiteral("</td>\n                                <td>");
            EndContext();
            BeginContext(2282, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "034ea574803b4cd4b3c16bb163ca88ec", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2328, "~/Hinh/beauty/", 2328, 14, true);
#line 50 "D:\Nam-IV\Agile\CosmeticOrder_Agile-master\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
AddHtmlAttributeValue("", 2342, item.Hinh2, 2342, 11, false);

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
            BeginContext(2357, 42, true);
            WriteLiteral("</td>\n                                <td>");
            EndContext();
            BeginContext(2400, 40, false);
#line 51 "D:\Nam-IV\Agile\CosmeticOrder_Agile-master\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.GiaCu));

#line default
#line hidden
            EndContext();
            BeginContext(2440, 42, true);
            WriteLiteral("</td>\n                                <td>");
            EndContext();
            BeginContext(2482, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de2f5341f2994f0086c028a5fd800854", async() => {
                BeginContext(2529, 8, true);
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
#line 52 "D:\Nam-IV\Agile\CosmeticOrder_Agile-master\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
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
            BeginContext(2541, 42, true);
            WriteLiteral("</td>\n                                <td>");
            EndContext();
            BeginContext(2583, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02d45562c2404af3b1157201f98e022e", async() => {
                BeginContext(2632, 3, true);
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
#line 53 "D:\Nam-IV\Agile\CosmeticOrder_Agile-master\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
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
            BeginContext(2639, 40, true);
            WriteLiteral("</td>\n                            </tr>\n");
            EndContext();
#line 55 "D:\Nam-IV\Agile\CosmeticOrder_Agile-master\Cosmetic\Cosmetic\Views\SanPhams\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2705, 249, true);
            WriteLiteral("                    </tbody>\n                </table>\n                <!-- /.table-responsive -->\n            </div>\n            <!-- /.panel-body -->\n        </div>\n        <!-- /.panel -->\n    </div>\n    <!-- /.col-lg-12 -->\n</div>\n<!-- /.row -->\n");
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
