#pragma checksum "C:\Users\Ahmet\Desktop\ÇEREZLİK RSS WEB SİTE\CerezlikWeb\CerezlikWeb.App\Views\Home\GetArticle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a8204a41dff28da96426a999b21ca350900ddd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetArticle), @"mvc.1.0.view", @"/Views/Home/GetArticle.cshtml")]
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
#line 1 "C:\Users\Ahmet\Desktop\ÇEREZLİK RSS WEB SİTE\CerezlikWeb\CerezlikWeb.App\Views\_ViewImports.cshtml"
using CerezlikWeb.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ahmet\Desktop\ÇEREZLİK RSS WEB SİTE\CerezlikWeb\CerezlikWeb.App\Views\_ViewImports.cshtml"
using CerezlikWeb.App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a8204a41dff28da96426a999b21ca350900ddd1", @"/Views/Home/GetArticle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b4b6f2b9f6953f1e3643331554c0684fb0885e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetArticle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Article>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Assets/index.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("breadcrumb-item f1-s-3 cl9"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Assets/blog-list-01.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Assets/#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("f1-s-10 cl0 hov-cl10 trans-03 text-uppercase txt-center m-b-33"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Assets/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("f1-s-3 cl8 m-rl-7 txt-center hov-cl10 trans-03"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ahmet\Desktop\ÇEREZLİK RSS WEB SİTE\CerezlikWeb\CerezlikWeb.App\Views\Home\GetArticle.cshtml"
  
    ViewData["Title"] = "GetArtical";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Breadcrumb -->\r\n<div class=\"container\">\r\n    <div class=\"headline bg0 flex-wr-sb-c p-rl-20 p-tb-8\">\r\n        <div class=\"f2-s-1 p-r-30 m-tb-6\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a8204a41dff28da96426a999b21ca350900ddd16436", async() => {
                WriteLiteral("\r\n                Anasayfa\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a8204a41dff28da96426a999b21ca350900ddd17648", async() => {
                WriteLiteral("\r\n                Yazı\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            <span class=\"breadcrumb-item f1-s-3 cl9\">\r\n                ");
#nullable restore
#line 19 "C:\Users\Ahmet\Desktop\ÇEREZLİK RSS WEB SİTE\CerezlikWeb\CerezlikWeb.App\Views\Home\GetArticle.cshtml"
           Write(Model.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </span>
        </div>

        <div class=""pos-relative size-a-2 bo-1-rad-22 of-hidden bocl11 m-tb-6"">
            <input class=""f1-s-1 cl6 plh9 s-full p-l-25 p-r-45"" type=""text"" name=""search"" placeholder=""Search"">
            <button class=""flex-c-c size-a-1 ab-t-r fs-20 cl2 hov-cl10 trans-03"">
                <i class=""zmdi zmdi-search""></i>
            </button>
        </div>
    </div>
</div>

<!-- Content -->
<section class=""bg0 p-b-70 p-t-5"">
    <!-- Title -->
");
#nullable restore
#line 35 "C:\Users\Ahmet\Desktop\ÇEREZLİK RSS WEB SİTE\CerezlikWeb\CerezlikWeb.App\Views\Home\GetArticle.cshtml"
     if (Model.Generator != "SABAH")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"bg-img1 size-a-18 how-overlay1\"");
            BeginWriteAttribute("style", " style=\"", 1150, "\"", 1194, 4);
            WriteAttributeValue("", 1158, "background-image:", 1158, 17, true);
            WriteAttributeValue(" ", 1175, "url(", 1176, 5, true);
#nullable restore
#line 37 "C:\Users\Ahmet\Desktop\ÇEREZLİK RSS WEB SİTE\CerezlikWeb\CerezlikWeb.App\Views\Home\GetArticle.cshtml"
WriteAttributeValue("", 1180, Model.Photo, 1180, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1192, ");", 1192, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"container h-full flex-col-e-c p-b-58\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a8204a41dff28da96426a999b21ca350900ddd110688", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 40 "C:\Users\Ahmet\Desktop\ÇEREZLİK RSS WEB SİTE\CerezlikWeb\CerezlikWeb.App\Views\Home\GetArticle.cshtml"
               Write(Model.Generator);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                <h3 class=\"f1-l-5 cl0 p-b-16 txt-center respon2\">\r\n                    ");
#nullable restore
#line 44 "C:\Users\Ahmet\Desktop\ÇEREZLİK RSS WEB SİTE\CerezlikWeb\CerezlikWeb.App\Views\Home\GetArticle.cshtml"
               Write(Model.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3>\r\n\r\n                <div class=\"flex-wr-c-s\">\r\n                    <span class=\"f1-s-3 cl8 m-rl-7 txt-center\">\r\n");
            WriteLiteral("\r\n                        <span class=\"m-rl-3\">-</span>\r\n\r\n                        <span>\r\n                            ");
#nullable restore
#line 56 "C:\Users\Ahmet\Desktop\ÇEREZLİK RSS WEB SİTE\CerezlikWeb\CerezlikWeb.App\Views\Home\GetArticle.cshtml"
                       Write(Model.PublishedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n                    </span>\r\n\r\n                    <span class=\"f1-s-3 cl8 m-rl-7 txt-center\">\r\n                        5239 Views\r\n                    </span>\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a8204a41dff28da96426a999b21ca350900ddd113300", async() => {
                WriteLiteral("\r\n                        0 Comment\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 70 "C:\Users\Ahmet\Desktop\ÇEREZLİK RSS WEB SİTE\CerezlikWeb\CerezlikWeb.App\Views\Home\GetArticle.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <!-- Detail -->
    <div class=""container p-t-82"">
        <div class=""row justify-content-center"">
            <div class=""col-md-10 col-lg-8 p-b-100"">
                <div class=""p-r-10 p-r-0-sr991"">
                    <!-- Blog Detail -->
                    <div class=""p-b-70"">
                        ");
#nullable restore
#line 80 "C:\Users\Ahmet\Desktop\ÇEREZLİK RSS WEB SİTE\CerezlikWeb\CerezlikWeb.App\Views\Home\GetArticle.cshtml"
                   Write(Html.Raw(Model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <!-- Leave a comment -->\r\n                    <div>\r\n                        <h4 class=\"f1-l-4 cl3 p-b-12\">\r\n                            Yorum Yap\r\n                        </h4>\r\n\r\n");
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a8204a41dff28da96426a999b21ca350900ddd115713", async() => {
                WriteLiteral(@"
                            <textarea class=""bo-1-rad-3 bocl13 size-a-15 f1-s-13 cl5 plh6 p-rl-18 p-tb-14 m-b-20"" name=""msg"" placeholder=""Yorum...""></textarea>

                            <input class=""bo-1-rad-3 bocl13 size-a-16 f1-s-13 cl5 plh6 p-rl-18 m-b-20"" type=""text"" name=""name"" placeholder=""İsim*"">

                            <input class=""bo-1-rad-3 bocl13 size-a-16 f1-s-13 cl5 plh6 p-rl-18 m-b-20"" type=""text"" name=""email"" placeholder=""Email*"">

                            <input class=""bo-1-rad-3 bocl13 size-a-16 f1-s-13 cl5 plh6 p-rl-18 m-b-20"" type=""text"" name=""website"" placeholder=""Website"">

                            <button class=""size-a-17 bg2 borad-3 f1-s-12 cl0 hov-btn1 trans-03 p-rl-15 m-t-10"">
                                Gönder
                            </button>
                        ");
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
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<!-- Back to top -->
<div class=""btn-back-to-top"" id=""myBtn"">
    <span class=""symbol-btn-back-to-top"">
        <span class=""fas fa-angle-up""></span>
    </span>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Article> Html { get; private set; }
    }
}
#pragma warning restore 1591
