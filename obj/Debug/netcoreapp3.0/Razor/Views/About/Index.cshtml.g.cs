#pragma checksum "D:\GIT\Coffee\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6b9232da1727b19b76dfcc7418f5bb536336b4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
#line 1 "D:\GIT\Coffee\Views\_ViewImports.cshtml"
using Coffee;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GIT\Coffee\Views\_ViewImports.cshtml"
using Coffee.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6b9232da1727b19b76dfcc7418f5bb536336b4e", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"339c788173a40e9bec207f55d81c92e5443ef456", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/person_1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/person_2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/person_3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-outline-primary px-4 py-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 1 "D:\GIT\Coffee\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Giới thiệu";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""home-slider owl-carousel"">

    <div class=""slider-item"" style=""background-image: url(/images/bg_3.jpg);"" data-stellar-background-ratio=""0.5"">
        <div class=""overlay""></div>
        <div class=""container"">
            <div class=""row slider-text justify-content-center align-items-center"">

                <div class=""col-md-7 col-sm-12 text-center ftco-animate"">
                    <h1 class=""mb-3 mt-5 bread"">Về chúng tôi</h1>
                    <p class=""breadcrumbs""><span class=""mr-2"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6b9232da1727b19b76dfcc7418f5bb536336b4e6512", async() => {
                WriteLiteral("Trang chủ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</span> <span>Giới Thiệu</span></p>
                </div>

            </div>
        </div>
    </div>
</section>

<section class=""ftco-about d-md-flex"">
    <div class=""one-half img"" style=""background-image: url(/images/about.jpg);""></div>
    <div class=""one-half ftco-animate"">
        <div class=""overlap"">
            <div class=""heading-section ftco-animate "">
                <span class=""subheading"">Khám phá</span>
                <h2 class=""mb-4"">Câu chuyện</h2>
            </div>
            <div>
                <p>
                    Cuộc đời cafe, cũng như cuộc đời của con người, cũng phải 9 tháng 10 ngày thai nghén mới được thu hoạch.

                    Café cũng có quãng thời gian trưởng thành, có thăng trầm và cả những sắc thái.

                    Sinh ra từ mầm cây, cafe chưa phải là hạt, cafe là thứ hoa trắng muốt, tinh khôi và cũng rất ngây thơ và dễ thương nữa.

                    Lớn hơn một chút, hoa kết thành trái.

                    Trái xanh non và yếu");
            WriteLiteral(@" ớt.

                    Trái như con người, chuẩn bị những bước chân đầu và chưa hề biết mùi vị của cuộc đời.

                    Rồi trái cafe xanh non ấy trải qua những cuộc ngụm lặn khi đất trời đổi thay.
                </p>
            </div>
        </div>
    </div>
</section>

<section class=""ftco-section img"" id=""ftco-testimony"" style=""background-image: url(/images/bg_1.jpg);"" data-stellar-background-ratio=""0.5"">
    <div class=""overlay""></div>
    <div class=""container"">
        <div class=""row justify-content-center mb-5"">
            <div class=""col-md-7 heading-section text-center ftco-animate"">
                <span class=""subheading"">Lời khai</span>
                <h2 class=""mb-4"">Khách hàng nói</h2>
                <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
            </div>
        </div>
    </div>
    <div class=""container-wrap"">
        <div class=""row d-flex no-gutters"">
         ");
            WriteLiteral(@"   <div class=""col-lg align-self-sm-end"">
                <div class=""testimony"">
                    <blockquote>
                        <p>&ldquo;Một ly cafe tuyệt hảo bắt đầu từ những hạt cafe chất lượng. Còn những hạt cafe chất lượng lại khởi nguồn từ giống, điều kiện tự nhiên của vùng và nghệ thuật rang xay cafe.&rdquo;</p>
                    </blockquote>
                    <div class=""author d-flex mt-4"">
                        <div class=""image mr-3 align-self-center"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d6b9232da1727b19b76dfcc7418f5bb536336b4e10554", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""name align-self-center"">Louise Kelly <span class=""position"">Illustrator Designer</span></div>
                    </div>
                </div>
            </div>
            <div class=""col-lg align-self-sm-end"">
                <div class=""testimony overlay"">
                    <blockquote>
                        <p>&ldquo;Even the all-powerful Pointing has no control about the blind texts it is an almost unorthographic life One day however a small line of blind text by the name of Lorem Ipsum decided to leave for the far World of Grammar.&rdquo;</p>
                    </blockquote>
                    <div class=""author d-flex mt-4"">
                        <div class=""image mr-3 align-self-center"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d6b9232da1727b19b76dfcc7418f5bb536336b4e12502", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""name align-self-center"">Louise Kelly <span class=""position"">Illustrator Designer</span></div>
                    </div>
                </div>
            </div>
            <div class=""col-lg align-self-sm-end"">
                <div class=""testimony"">
                    <blockquote>
                        <p>&ldquo;Even the all-powerful Pointing has no control about the blind texts it is an almost unorthographic life One day however a small  line of blind text by the name. &rdquo;</p>
                    </blockquote>
                    <div class=""author d-flex mt-4"">
                        <div class=""image mr-3 align-self-center"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d6b9232da1727b19b76dfcc7418f5bb536336b4e14383", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""name align-self-center"">Louise Kelly <span class=""position"">Illustrator Designer</span></div>
                    </div>
                </div>
            </div>
            <div class=""col-lg align-self-sm-end"">
                <div class=""testimony overlay"">
                    <blockquote>
                        <p>&ldquo;Even the all-powerful Pointing has no control about the blind texts it is an almost unorthographic life One day however.&rdquo;</p>
                    </blockquote>
                    <div class=""author d-flex mt-4"">
                        <div class=""image mr-3 align-self-center"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d6b9232da1727b19b76dfcc7418f5bb536336b4e16231", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""name align-self-center"">Louise Kelly <span class=""position"">Illustrator Designer</span></div>
                    </div>
                </div>
            </div>
            <div class=""col-lg align-self-sm-end"">
                <div class=""testimony"">
                    <blockquote>
                        <p>&ldquo;Even the all-powerful Pointing has no control about the blind texts it is an almost unorthographic life One day however a small  line of blind text by the name. &rdquo;</p>
                    </blockquote>
                    <div class=""author d-flex mt-4"">
                        <div class=""image mr-3 align-self-center"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d6b9232da1727b19b76dfcc7418f5bb536336b4e18112", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""name align-self-center"">Louise Kelly <span class=""position"">Illustrator Designer</span></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<section class=""ftco-section"">
    <div class=""container"">
        <div class=""row align-items-center"">
            <div class=""col-md-6 pr-md-5"">
                <div class=""heading-section text-md-right ftco-animate"">
                    <span class=""subheading"">Khám phá</span>
                    <h2 class=""mb-4"">Thực đơn</h2>
                    <p class=""mb-4"">Thư thả để nếm trải từng hương từng vị trong tách3in1 thơm ngon nguyên bản, tôi cảm nhận đủ 5 vị của một loại cà phê thật chất, chua thanh, đắng dịu, hơi chát, ngọt nhẹ và chút béo . Và nếu tinh ý một chút, bạn sẽ thấy cuộc sống chứa đựng tất cả những hương vị đó.</p>
                    <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6b9232da1727b19b76dfcc7418f5bb536336b4e20191", async() => {
                WriteLiteral("Xem thực đơn");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</p>
                </div>
            </div>
            <div class=""col-md-6"">
                <div class=""row"">
                    <div class=""col-md-6"">
                        <div class=""menu-entry"">
                            <a href=""#"" class=""img"" style=""background-image: url(images/menu-1.jpg);""></a>
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <div class=""menu-entry mt-lg-4"">
                            <a href=""#"" class=""img"" style=""background-image: url(images/menu-2.jpg);""></a>
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <div class=""menu-entry"">
                            <a href=""#"" class=""img"" style=""background-image: url(images/menu-3.jpg);""></a>
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <div class=""menu-entry mt-lg-4"">
       ");
            WriteLiteral(@"                     <a href=""#"" class=""img"" style=""background-image: url(images/menu-4.jpg);""></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<section class=""ftco-counter ftco-bg-dark img"" id=""section-counter"" style=""background-image: url(images/bg_2.jpg);"" data-stellar-background-ratio=""0.5"">
    <div class=""overlay""></div>
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-md-10"">
                <div class=""row"">
                    <div class=""col-md-6 col-lg-3 d-flex justify-content-center counter-wrap ftco-animate"">
                        <div class=""block-18 text-center"">
                            <div class=""text"">
                                <div class=""icon""><span class=""flaticon-coffee-cup""></span></div>
                                <strong class=""number"" data-number=""100"">0</strong>
                                <span>");
            WriteLiteral(@"Chi nhánh</span>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-6 col-lg-3 d-flex justify-content-center counter-wrap ftco-animate"">
                        <div class=""block-18 text-center"">
                            <div class=""text"">
                                <div class=""icon""><span class=""flaticon-coffee-cup""></span></div>
                                <strong class=""number"" data-number=""85"">0</strong>
                                <span>Số lượng giải thưởng</span>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-6 col-lg-3 d-flex justify-content-center counter-wrap ftco-animate"">
                        <div class=""block-18 text-center"">
                            <div class=""text"">
                                <div class=""icon""><span class=""flaticon-coffee-cup""></span></div>
                               ");
            WriteLiteral(@" <strong class=""number"" data-number=""10567"">0</strong>
                                <span>Khách hàng hài lòng</span>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-6 col-lg-3 d-flex justify-content-center counter-wrap ftco-animate"">
                        <div class=""block-18 text-center"">
                            <div class=""text"">
                                <div class=""icon""><span class=""flaticon-coffee-cup""></span></div>
                                <strong class=""number"" data-number=""900"">0</strong>
                                <span>Nhân viên</span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>");
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