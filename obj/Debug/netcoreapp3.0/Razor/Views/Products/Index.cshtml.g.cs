#pragma checksum "D:\GIT\Coffee\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49279ff1d6d096379d0c68b86319bc308bfc0664"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49279ff1d6d096379d0c68b86319bc308bfc0664", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"339c788173a40e9bec207f55d81c92e5443ef456", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Coffee.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("appointment-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\GIT\Coffee\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Thực đơn";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""home-slider owl-carousel"">

    <div class=""slider-item"" style=""background-image: url(images/bg_3.jpg);"" data-stellar-background-ratio=""0.5"">
        <div class=""overlay""></div>
        <div class=""container"">
            <div class=""row slider-text justify-content-center align-items-center"">

                <div class=""col-md-7 col-sm-12 text-center ftco-animate"">
                    <h1 class=""mb-3 mt-5 bread"">Thực đơn</h1>
                    <p class=""breadcrumbs""><span class=""mr-2"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49279ff1d6d096379d0c68b86319bc308bfc06645300", async() => {
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
            WriteLiteral(@"</span> <span>Thực đơn</span></p>
                </div>

            </div>
        </div>
    </div>
</section>

<section class=""ftco-intro"">
    <div class=""container-wrap"">
        <div class=""wrap d-md-flex align-items-xl-end"">
            <div class=""info"">
                <div class=""row no-gutters"">
                    <div class=""col-md-4 d-flex ftco-animate"">
                        <div class=""icon""><span class=""icon-phone""></span></div>
                        <div class=""text"">
                            <h3>000 (123) 456 7890</h3>
                            <p>A small river named Duden flows by their place and supplies.</p>
                        </div>
                    </div>
                    <div class=""col-md-4 d-flex ftco-animate"">
                        <div class=""icon""><span class=""icon-my_location""></span></div>
                        <div class=""text"">
                            <h3>198 West 21th Street</h3>
                            <p>	203 Fake St");
            WriteLiteral(@". Mountain View, San Francisco, California, USA</p>
                        </div>
                    </div>
                    <div class=""col-md-4 d-flex ftco-animate"">
                        <div class=""icon""><span class=""icon-clock-o""></span></div>
                        <div class=""text"">
                            <h3>Open Monday-Friday</h3>
                            <p>8:00am - 9:00pm</p>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""book p-4"">
                <h3>Book a Table</h3>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49279ff1d6d096379d0c68b86319bc308bfc06648362", async() => {
                WriteLiteral(@"
                    <div class=""d-md-flex"">
                        <div class=""form-group"">
                            <input type=""text"" class=""form-control"" placeholder=""First Name"">
                        </div>
                        <div class=""form-group ml-md-4"">
                            <input type=""text"" class=""form-control"" placeholder=""Last Name"">
                        </div>
                    </div>
                    <div class=""d-md-flex"">
                        <div class=""form-group"">
                            <div class=""input-wrap"">
                                <div class=""icon""><span class=""ion-md-calendar""></span></div>
                                <input type=""text"" class=""form-control appointment_date"" placeholder=""Date"">
                            </div>
                        </div>
                        <div class=""form-group ml-md-4"">
                            <div class=""input-wrap"">
                                <div class=""icon""><spa");
                WriteLiteral(@"n class=""ion-ios-clock""></span></div>
                                <input type=""text"" class=""form-control appointment_time"" placeholder=""Time"">
                            </div>
                        </div>
                        <div class=""form-group ml-md-4"">
                            <input type=""text"" class=""form-control"" placeholder=""Phone"">
                        </div>
                    </div>
                    <div class=""d-md-flex"">
                        <div class=""form-group"">
                            <textarea");
                BeginWriteAttribute("name", " name=\"", 3922, "\"", 3929, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 3930, "\"", 3935, 0);
                EndWriteAttribute();
                WriteLiteral(@" cols=""30"" rows=""2"" class=""form-control"" placeholder=""Message""></textarea>
                        </div>
                        <div class=""form-group ml-md-4"">
                            <input type=""submit"" value=""Appointment"" class=""btn btn-white py-3 px-4"">
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
        </div>
    </div>
</section>

<section class=""ftco-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 mb-5 pb-3"">
                <h3 class=""mb-5 heading-pricing ftco-animate"">Cà phê</h3>
");
#nullable restore
#line 99 "D:\GIT\Coffee\Views\Products\Index.cshtml"
                  
                    foreach (var item in Model)
                    {
                        if (item.Genre == "Coffee")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"pricing-entry d-flex ftco-animate\">\r\n                                <div class=\"img\"");
            BeginWriteAttribute("style", " style=\"", 4858, "\"", 4908, 4);
            WriteAttributeValue("", 4866, "background-image:", 4866, 17, true);
            WriteAttributeValue(" ", 4883, "url(images/", 4884, 12, true);
#nullable restore
#line 105 "D:\GIT\Coffee\Views\Products\Index.cshtml"
WriteAttributeValue("", 4895, item.Image, 4895, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4906, ");", 4906, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                                <div class=\"desc pl-3\">\r\n                                    <div class=\"d-flex text align-items-center\">\r\n                                        <h3><span>");
#nullable restore
#line 108 "D:\GIT\Coffee\Views\Products\Index.cshtml"
                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h3>\r\n                                        <span class=\"price\">");
#nullable restore
#line 109 "D:\GIT\Coffee\Views\Products\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" K</span>\r\n                                    </div>\r\n                                    <div class=\"d-block\">\r\n                                        <p>");
#nullable restore
#line 112 "D:\GIT\Coffee\Views\Products\Index.cshtml"
                                      Write(item.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 116 "D:\GIT\Coffee\Views\Products\Index.cshtml"
                        }
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n            <div class=\"col-md-6 mb-5 pb-3\">\r\n                <h3 class=\"mb-5 heading-pricing ftco-animate\">Trà sữa</h3>\r\n");
#nullable restore
#line 123 "D:\GIT\Coffee\Views\Products\Index.cshtml"
                  
                    foreach (var item in Model)
                    {
                        if (item.Genre == "MilkTea")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"pricing-entry d-flex ftco-animate\">\r\n                                <div class=\"img\"");
            BeginWriteAttribute("style", " style=\"", 6036, "\"", 6086, 4);
            WriteAttributeValue("", 6044, "background-image:", 6044, 17, true);
            WriteAttributeValue(" ", 6061, "url(images/", 6062, 12, true);
#nullable restore
#line 129 "D:\GIT\Coffee\Views\Products\Index.cshtml"
WriteAttributeValue("", 6073, item.Image, 6073, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6084, ");", 6084, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                                <div class=\"desc pl-3\">\r\n                                    <div class=\"d-flex text align-items-center\">\r\n                                        <h3><span>");
#nullable restore
#line 132 "D:\GIT\Coffee\Views\Products\Index.cshtml"
                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h3>\r\n                                        <span class=\"price\">");
#nullable restore
#line 133 "D:\GIT\Coffee\Views\Products\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" K</span>\r\n                                    </div>\r\n                                    <div class=\"d-block\">\r\n                                        <p>");
#nullable restore
#line 136 "D:\GIT\Coffee\Views\Products\Index.cshtml"
                                      Write(item.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 140 "D:\GIT\Coffee\Views\Products\Index.cshtml"
                        }
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"col-md-6\">\r\n                <h3 class=\"mb-5 heading-pricing ftco-animate\">Sinh Tố</h3>\r\n");
#nullable restore
#line 148 "D:\GIT\Coffee\Views\Products\Index.cshtml"
                  
                    foreach (var item in Model)
                    {
                        if (item.Genre == "SinhTo")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"pricing-entry d-flex ftco-animate\">\r\n                                <div class=\"img\"");
            BeginWriteAttribute("style", " style=\"", 7205, "\"", 7255, 4);
            WriteAttributeValue("", 7213, "background-image:", 7213, 17, true);
            WriteAttributeValue(" ", 7230, "url(images/", 7231, 12, true);
#nullable restore
#line 154 "D:\GIT\Coffee\Views\Products\Index.cshtml"
WriteAttributeValue("", 7242, item.Image, 7242, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7253, ");", 7253, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                                <div class=\"desc pl-3\">\r\n                                    <div class=\"d-flex text align-items-center\">\r\n                                        <h3><span>");
#nullable restore
#line 157 "D:\GIT\Coffee\Views\Products\Index.cshtml"
                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h3>\r\n                                        <span class=\"price\">");
#nullable restore
#line 158 "D:\GIT\Coffee\Views\Products\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" K</span>\r\n                                    </div>\r\n                                    <div class=\"d-block\">\r\n                                        <p>");
#nullable restore
#line 161 "D:\GIT\Coffee\Views\Products\Index.cshtml"
                                      Write(item.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 165 "D:\GIT\Coffee\Views\Products\Index.cshtml"
                        }
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"col-md-6\">\r\n                <h3 class=\"mb-5 heading-pricing ftco-animate\">Soda</h3>\r\n");
#nullable restore
#line 173 "D:\GIT\Coffee\Views\Products\Index.cshtml"
                  
                    foreach (var item in Model)
                    {
                        if (item.Genre == "Soda")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"pricing-entry d-flex ftco-animate\">\r\n                                <div class=\"img\"");
            BeginWriteAttribute("style", " style=\"", 8369, "\"", 8419, 4);
            WriteAttributeValue("", 8377, "background-image:", 8377, 17, true);
            WriteAttributeValue(" ", 8394, "url(images/", 8395, 12, true);
#nullable restore
#line 179 "D:\GIT\Coffee\Views\Products\Index.cshtml"
WriteAttributeValue("", 8406, item.Image, 8406, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8417, ");", 8417, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                                <div class=\"desc pl-3\">\r\n                                    <div class=\"d-flex text align-items-center\">\r\n                                        <h3><span>");
#nullable restore
#line 182 "D:\GIT\Coffee\Views\Products\Index.cshtml"
                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h3>\r\n                                        <span class=\"price\">");
#nullable restore
#line 183 "D:\GIT\Coffee\Views\Products\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" K</span>\r\n                                    </div>\r\n                                    <div class=\"d-block\">\r\n                                        <p>");
#nullable restore
#line 186 "D:\GIT\Coffee\Views\Products\Index.cshtml"
                                      Write(item.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 190 "D:\GIT\Coffee\Views\Products\Index.cshtml"
                        }
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Coffee.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
