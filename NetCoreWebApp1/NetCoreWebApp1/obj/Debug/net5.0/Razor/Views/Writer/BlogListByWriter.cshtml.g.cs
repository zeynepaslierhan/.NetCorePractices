#pragma checksum "C:\Users\zerha\Documents\GitHub\.NetCorePractices\NetCoreWebApp1\NetCoreWebApp1\Views\Writer\BlogListByWriter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e056d8e572e806fd5e6bc7a085198b9eddb39458"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Writer_BlogListByWriter), @"mvc.1.0.view", @"/Views/Writer/BlogListByWriter.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e056d8e572e806fd5e6bc7a085198b9eddb39458", @"/Views/Writer/BlogListByWriter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4ab36396bdd8ca1cc686a04a082617ba4224c7f", @"/Views/_ViewImports.cshtml")]
    public class Views_Writer_BlogListByWriter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\zerha\Documents\GitHub\.NetCorePractices\NetCoreWebApp1\NetCoreWebApp1\Views\Writer\BlogListByWriter.cshtml"
  
    ViewData["Title"] = "BlogListByWriter";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Yazarın Blogları</h1>\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Blog Başlığı</th>\r\n        <th>Oluşturma Tarihi</th>\r\n        <th>Kategori</th>\r\n        <th>Durumu</th>\r\n    </tr>\r\n");
#nullable restore
#line 16 "C:\Users\zerha\Documents\GitHub\.NetCorePractices\NetCoreWebApp1\NetCoreWebApp1\Views\Writer\BlogListByWriter.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 19 "C:\Users\zerha\Documents\GitHub\.NetCorePractices\NetCoreWebApp1\NetCoreWebApp1\Views\Writer\BlogListByWriter.cshtml"
   Write(item.BlogID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 20 "C:\Users\zerha\Documents\GitHub\.NetCorePractices\NetCoreWebApp1\NetCoreWebApp1\Views\Writer\BlogListByWriter.cshtml"
   Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 21 "C:\Users\zerha\Documents\GitHub\.NetCorePractices\NetCoreWebApp1\NetCoreWebApp1\Views\Writer\BlogListByWriter.cshtml"
   Write(item.BlogCreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 22 "C:\Users\zerha\Documents\GitHub\.NetCorePractices\NetCoreWebApp1\NetCoreWebApp1\Views\Writer\BlogListByWriter.cshtml"
   Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>\r\n");
#nullable restore
#line 24 "C:\Users\zerha\Documents\GitHub\.NetCorePractices\NetCoreWebApp1\NetCoreWebApp1\Views\Writer\BlogListByWriter.cshtml"
         if (item.BlogStatus)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"badge badge-success\">Aktif</span> ");
#nullable restore
#line 25 "C:\Users\zerha\Documents\GitHub\.NetCorePractices\NetCoreWebApp1\NetCoreWebApp1\Views\Writer\BlogListByWriter.cshtml"
                                                        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"badge badge-secondary\">Pasif</span>");
#nullable restore
#line 27 "C:\Users\zerha\Documents\GitHub\.NetCorePractices\NetCoreWebApp1\NetCoreWebApp1\Views\Writer\BlogListByWriter.cshtml"
                                                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </td>\r\n    <td><button class=\"btn btn-outline-danger\">Sil</button></td>\r\n    <td><button class=\"btn btn-outline-warning\">Güncelle</button></td>\r\n</tr>\r\n");
#nullable restore
#line 32 "C:\Users\zerha\Documents\GitHub\.NetCorePractices\NetCoreWebApp1\NetCoreWebApp1\Views\Writer\BlogListByWriter.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<a href=\"/Writer/BlogAdd\" class=\"btn btn-outline-success\"><h3>Blog Oluştur</h3></a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
