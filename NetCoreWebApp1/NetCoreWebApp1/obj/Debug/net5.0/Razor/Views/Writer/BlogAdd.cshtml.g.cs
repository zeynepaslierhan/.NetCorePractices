#pragma checksum "C:\Users\zerha\Documents\GitHub\.NetCorePractices\NetCoreWebApp1\NetCoreWebApp1\Views\Writer\BlogAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce397a49b2e6a8e52b0bb4ef81219fc87687b11a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Writer_BlogAdd), @"mvc.1.0.view", @"/Views/Writer/BlogAdd.cshtml")]
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
#line 1 "C:\Users\zerha\Documents\GitHub\.NetCorePractices\NetCoreWebApp1\NetCoreWebApp1\Views\_ViewImports.cshtml"
using NetCoreWebApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zerha\Documents\GitHub\.NetCorePractices\NetCoreWebApp1\NetCoreWebApp1\Views\_ViewImports.cshtml"
using NetCoreWebApp1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\zerha\Documents\GitHub\.NetCorePractices\NetCoreWebApp1\NetCoreWebApp1\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce397a49b2e6a8e52b0bb4ef81219fc87687b11a", @"/Views/Writer/BlogAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4ab36396bdd8ca1cc686a04a082617ba4224c7f", @"/Views/_ViewImports.cshtml")]
    public class Views_Writer_BlogAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Blog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/ckeditor/ckeditor.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\zerha\Documents\GitHub\.NetCorePractices\NetCoreWebApp1\NetCoreWebApp1\Views\Writer\BlogAdd.cshtml"
  
    ViewData["Title"] = "BlogAdd";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-12 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <h4 class=\"card-title\">Blog Yaz??s?? Ekle</h4>\r\n            <p class=\"card-description\"> </p>\r\n");
#nullable restore
#line 12 "C:\Users\zerha\Documents\GitHub\.NetCorePractices\NetCoreWebApp1\NetCoreWebApp1\Views\Writer\BlogAdd.cshtml"
             using (Html.BeginForm("BlogEdit", "Writer", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce397a49b2e6a8e52b0bb4ef81219fc87687b11a5256", async() => {
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n\r\n                        <label>Blog Ba??l??????:</label>\r\n                        ");
#nullable restore
#line 18 "C:\Users\zerha\Documents\GitHub\.NetCorePractices\NetCoreWebApp1\NetCoreWebApp1\Views\Writer\BlogAdd.cshtml"
                   Write(Html.TextBoxFor(x => x.BlogTitle, "", new { @class = "form-control", @placeholder = "Blog Ba??l??????" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 19 "C:\Users\zerha\Documents\GitHub\.NetCorePractices\NetCoreWebApp1\NetCoreWebApp1\Views\Writer\BlogAdd.cshtml"
                   Write(Html.ValidationMessageFor(x => x.BlogTitle, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label>Blog Kategorisi:</label>\r\n                        ");
#nullable restore
#line 23 "C:\Users\zerha\Documents\GitHub\.NetCorePractices\NetCoreWebApp1\NetCoreWebApp1\Views\Writer\BlogAdd.cshtml"
                   Write(Html.DropDownListFor(x => x.CategoryID, (List<SelectListItem>)ViewBag.cv, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                    <div class=""form-group"">
                        <label>Foto??raf Y??kle</label>
                        <input type=""file"" name=""img[]"" class=""file-upload-default"">
                        <div class=""input-group col-xs-12"">
                            <input type=""text"" class=""form-control file-upload-info""");
                BeginWriteAttribute("disabled", " disabled=\"", 1436, "\"", 1447, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Foto??raf Y??kle"">
                            <span class=""input-group-append"">
                                <button class=""file-upload-browse btn btn-gradient-primary"" type=""button"">Upload</button>
                            </span>
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label>Blog ????eri??i:</label>
                        ");
#nullable restore
#line 37 "C:\Users\zerha\Documents\GitHub\.NetCorePractices\NetCoreWebApp1\NetCoreWebApp1\Views\Writer\BlogAdd.cshtml"
                   Write(Html.TextArea("BlogContent", new { @class = "form-control", @placeholder = "Blog ????eri??i", @id="editor"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 38 "C:\Users\zerha\Documents\GitHub\.NetCorePractices\NetCoreWebApp1\NetCoreWebApp1\Views\Writer\BlogAdd.cshtml"
                   Write(Html.ValidationMessageFor(x => x.BlogContent, "", new { @class = "text-danger", @placeholder = "Blog ????eri??i" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                    <button type=""submit"" class=""btn btn-gradient-primary mr-2"">
                        Kaydet
                        <i class=""mdi mdi-file-check""></i>
                    </button>
                    <a href=""/Writer/BlogListByWriter"" class=""btn btn-light"">Cancel</a>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 46 "C:\Users\zerha\Documents\GitHub\.NetCorePractices\NetCoreWebApp1\NetCoreWebApp1\Views\Writer\BlogAdd.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </div>\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce397a49b2e6a8e52b0bb4ef81219fc87687b11a10326", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n    CKEDITOR.replace(\"editor\")\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
