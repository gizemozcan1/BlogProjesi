#pragma checksum "C:\Users\201\Desktop\GizemBlog\GizemBlog\Views\Blog\EditBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e3643587a90ae1033ca145382799ba547a0c73e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_EditBlog), @"mvc.1.0.view", @"/Views/Blog/EditBlog.cshtml")]
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
#line 1 "C:\Users\201\Desktop\GizemBlog\GizemBlog\Views\_ViewImports.cshtml"
using GizemBlog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\201\Desktop\GizemBlog\GizemBlog\Views\_ViewImports.cshtml"
using GizemBlog.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e3643587a90ae1033ca145382799ba547a0c73e", @"/Views/Blog/EditBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"996ec665c065812787315369e094f2e15c7e6369", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_EditBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Blog>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\201\Desktop\GizemBlog\GizemBlog\Views\Blog\EditBlog.cshtml"
  
    ViewData["Title"] = "EditBlog";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Blog Düzenleme Sayfası</h1>\r\n<br />\r\n");
#nullable restore
#line 10 "C:\Users\201\Desktop\GizemBlog\GizemBlog\Views\Blog\EditBlog.cshtml"
 using (Html.BeginForm("EditBlog", "Blog", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\201\Desktop\GizemBlog\GizemBlog\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog ID"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\201\Desktop\GizemBlog\GizemBlog\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x=>x.BlogID, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 15 "C:\Users\201\Desktop\GizemBlog\GizemBlog\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Başlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\201\Desktop\GizemBlog\GizemBlog\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x=>x.BlogTitle, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 18 "C:\Users\201\Desktop\GizemBlog\GizemBlog\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Thumnail Url"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\201\Desktop\GizemBlog\GizemBlog\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x=>x.BlogThumbnailImage, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 21 "C:\Users\201\Desktop\GizemBlog\GizemBlog\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Görseli"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\201\Desktop\GizemBlog\GizemBlog\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x=>x.BlogImage, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 24 "C:\Users\201\Desktop\GizemBlog\GizemBlog\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Kategori"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\201\Desktop\GizemBlog\GizemBlog\Views\Blog\EditBlog.cshtml"
Write(Html.DropDownListFor(x=>x.CategoryID,(List<SelectListItem>)ViewBag.cv, new{@class ="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 27 "C:\Users\201\Desktop\GizemBlog\GizemBlog\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog İçeriği"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\201\Desktop\GizemBlog\GizemBlog\Views\Blog\EditBlog.cshtml"
Write(Html.TextAreaFor(x=>x.BlogContent,10,3, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-success\">Güncelle</button>\r\n");
#nullable restore
#line 31 "C:\Users\201\Desktop\GizemBlog\GizemBlog\Views\Blog\EditBlog.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Blog> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
