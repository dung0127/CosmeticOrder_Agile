#pragma checksum "D:\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\GioHang\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f889ac169fa86a83bd3cef353b7c3e1b6627084"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GioHang_Index), @"mvc.1.0.view", @"/Views/GioHang/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GioHang/Index.cshtml", typeof(AspNetCore.Views_GioHang_Index))]
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
#line 1 "D:\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\_ViewImports.cshtml"
using Cosmetic;

#line default
#line hidden
#line 2 "D:\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\_ViewImports.cshtml"
using Cosmetic.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f889ac169fa86a83bd3cef353b7c3e1b6627084", @"/Views/GioHang/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45e46a70e22261359788c4d073dc157268b599e9", @"/Views/_ViewImports.cshtml")]
    public class Views_GioHang_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("checkout1.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\GioHang\Index.cshtml"
  
    ViewData["Title"] = "View";
    Layout = "~/Views/Shared/_Frontend.cshtml";

#line default
#line hidden
            BeginContext(89, 595, true);
            WriteLiteral(@"
<div id=""content"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <!-- breadcrumb-->
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                        <li aria-current=""page"" class=""breadcrumb-item active"">Shopping cart</li>
                    </ol>
                </nav>
            </div>
            <div id=""basket"" class=""col-lg-9"">
                <div class=""box"">
                    ");
            EndContext();
            BeginContext(684, 3483, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf31a3880e9947e0bc8972ceff551840", async() => {
                BeginContext(728, 3432, true);
                WriteLiteral(@"
                        <h1>Giỏ Hàng</h1>
                        <p class=""text-muted"">You currently have 3 item(s) in your cart.</p>
                        <div class=""table-responsive"">
                            <table class=""table"">
                                <thead>
                                    <tr>
                                        <th colspan=""2"">Product</th>
                                        <th>Quantity</th>
                                        <th>Unit price</th>
                                        <th>Discount</th>
                                        <th colspan=""2"">Total</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td><a href=""#""><img src=""img/detailsquare.jpg"" alt=""White Blouse Armani""></a></td>
                                        <td><a href=""#"">White Blouse Armani</a></td>");
                WriteLiteral(@"
                                        <td>
                                            <input type=""number"" value=""2"" class=""form-control"">
                                        </td>
                                        <td>$123.00</td>
                                        <td>$0.00</td>
                                        <td>$246.00</td>
                                        <td><a href=""#""><i class=""fa fa-trash-o""></i></a></td>
                                    </tr>
                                    <tr>
                                        <td><a href=""#""><img src=""img/basketsquare.jpg"" alt=""Black Blouse Armani""></a></td>
                                        <td><a href=""#"">Black Blouse Armani</a></td>
                                        <td>
                                            <input type=""number"" value=""1"" class=""form-control"">
                                        </td>
                                        <td>$200.00</td>
                   ");
                WriteLiteral(@"                     <td>$0.00</td>
                                        <td>$200.00</td>
                                        <td><a href=""#""><i class=""fa fa-trash-o""></i></a></td>
                                    </tr>
                                </tbody>
                                <tfoot>
                                    <tr>
                                        <th colspan=""5"">Total</th>
                                        <th colspan=""2"">$446.00</th>
                                    </tr>
                                </tfoot>
                            </table>
                        </div>
                        <!-- /.table-responsive-->
                        <div class=""box-footer d-flex justify-content-between flex-column flex-lg-row"">
                            <div class=""left""><a href=""category.html"" class=""btn btn-outline-secondary""><i class=""fa fa-chevron-left""></i> Continue shopping</a></div>
                            <div class=""right"">");
                WriteLiteral(@"
                                <button class=""btn btn-outline-secondary""><i class=""fa fa-refresh""></i> Update cart</button>
                                <button type=""submit"" class=""btn btn-primary"">Proceed to checkout <i class=""fa fa-chevron-right""></i></button>
                            </div>
                        </div>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4167, 5040, true);
            WriteLiteral(@"
                </div>
                <!-- /.box-->
                <div class=""row same-height-row"">
                    <div class=""col-lg-3 col-md-6"">
                        <div class=""box same-height"">
                            <h3>You may also like these products</h3>
                        </div>
                    </div>
                    <div class=""col-md-3 col-sm-6"">
                        <div class=""product same-height"">
                            <div class=""flip-container"">
                                <div class=""flipper"">
                                    <div class=""front""><a href=""detail.html""><img src=""img/product2.jpg"" alt="""" class=""img-fluid""></a></div>
                                    <div class=""back""><a href=""detail.html""><img src=""img/product2_2.jpg"" alt="""" class=""img-fluid""></a></div>
                                </div>
                            </div><a href=""detail.html"" class=""invisible""><img src=""img/product2.jpg"" alt="""" class=""img-fluid"">");
            WriteLiteral(@"</a>
                            <div class=""text"">
                                <h3>Fur coat</h3>
                                <p class=""price"">$143</p>
                            </div>
                        </div>
                        <!-- /.product-->
                    </div>
                    <div class=""col-md-3 col-sm-6"">
                        <div class=""product same-height"">
                            <div class=""flip-container"">
                                <div class=""flipper"">
                                    <div class=""front""><a href=""detail.html""><img src=""img/product1.jpg"" alt="""" class=""img-fluid""></a></div>
                                    <div class=""back""><a href=""detail.html""><img src=""img/product1_2.jpg"" alt="""" class=""img-fluid""></a></div>
                                </div>
                            </div><a href=""detail.html"" class=""invisible""><img src=""img/product1.jpg"" alt="""" class=""img-fluid""></a>
                            <div class");
            WriteLiteral(@"=""text"">
                                <h3>Fur coat</h3>
                                <p class=""price"">$143</p>
                            </div>
                        </div>
                        <!-- /.product-->
                    </div>
                    <div class=""col-md-3 col-sm-6"">
                        <div class=""product same-height"">
                            <div class=""flip-container"">
                                <div class=""flipper"">
                                    <div class=""front""><a href=""detail.html""><img src=""img/product3.jpg"" alt="""" class=""img-fluid""></a></div>
                                    <div class=""back""><a href=""detail.html""><img src=""img/product3_2.jpg"" alt="""" class=""img-fluid""></a></div>
                                </div>
                            </div><a href=""detail.html"" class=""invisible""><img src=""img/product3.jpg"" alt="""" class=""img-fluid""></a>
                            <div class=""text"">
                                <h");
            WriteLiteral(@"3>Fur coat</h3>
                                <p class=""price"">$143</p>
                            </div>
                        </div>
                        <!-- /.product-->
                    </div>
                </div>
            </div>
            <!-- /.col-lg-9-->
            <div class=""col-lg-3"">
                <div id=""order-summary"" class=""box"">
                    <div class=""box-header"">
                        <h3 class=""mb-0"">Order summary</h3>
                    </div>
                    <p class=""text-muted"">Shipping and additional costs are calculated based on the values you have entered.</p>
                    <div class=""table-responsive"">
                        <table class=""table"">
                            <tbody>
                                <tr>
                                    <td>Order subtotal</td>
                                    <th>$446.00</th>
                                </tr>
                                <tr>
            ");
            WriteLiteral(@"                        <td>Shipping and handling</td>
                                    <th>$10.00</th>
                                </tr>
                                <tr>
                                    <td>Tax</td>
                                    <th>$0.00</th>
                                </tr>
                                <tr class=""total"">
                                    <td>Total</td>
                                    <th>$456.00</th>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
                <div class=""box"">
                    <div class=""box-header"">
                        <h4 class=""mb-0"">Coupon code</h4>
                    </div>
                    <p class=""text-muted"">If you have a coupon code, please enter it in the box below.</p>
                    ");
            EndContext();
            BeginContext(9207, 419, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53ba926f895e48198402405d970b9d18", async() => {
                BeginContext(9213, 406, true);
                WriteLiteral(@"
                        <div class=""input-group"">
                            <input type=""text"" class=""form-control""><span class=""input-group-append"">
                                <button type=""button"" class=""btn btn-primary""><i class=""fa fa-gift""></i></button>
                            </span>
                        </div>
                        <!-- /input-group-->
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9626, 112, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <!-- /.col-md-3-->\r\n        </div>\r\n    </div>\r\n</div>");
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
