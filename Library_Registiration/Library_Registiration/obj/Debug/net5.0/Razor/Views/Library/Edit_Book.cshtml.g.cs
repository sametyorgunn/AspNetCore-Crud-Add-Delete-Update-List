#pragma checksum "C:\Users\Samet\source\repos\Library_Registiration\Library_Registiration\Views\Library\Edit_Book.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5001604525c25e13e608df2cc94f5c077f986c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Library_Edit_Book), @"mvc.1.0.view", @"/Views/Library/Edit_Book.cshtml")]
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
#line 1 "C:\Users\Samet\source\repos\Library_Registiration\Library_Registiration\Views\_ViewImports.cshtml"
using Library_Registiration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Samet\source\repos\Library_Registiration\Library_Registiration\Views\_ViewImports.cshtml"
using Library_Registiration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5001604525c25e13e608df2cc94f5c077f986c1", @"/Views/Library/Edit_Book.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bd15592859d162b94ca94c77ba5d4de43b7bc4a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Library_Edit_Book : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Samet\source\repos\Library_Registiration\Library_Registiration\Views\Library\Edit_Book.cshtml"
  
    ViewData["Title"] = "Edit_Book";
    Layout = "~/Views/Shared/_LibraryLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Samet\source\repos\Library_Registiration\Library_Registiration\Views\Library\Edit_Book.cshtml"
 using (Html.BeginForm("Edit_Book","Library", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Samet\source\repos\Library_Registiration\Library_Registiration\Views\Library\Edit_Book.cshtml"
Write(Html.Label("Book id"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Samet\source\repos\Library_Registiration\Library_Registiration\Views\Library\Edit_Book.cshtml"
Write(Html.TextBoxFor(x=>x.Book_id, new{Class="form-control",@readonly="readonly"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 13 "C:\Users\Samet\source\repos\Library_Registiration\Library_Registiration\Views\Library\Edit_Book.cshtml"
Write(Html.Label("Book name"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Samet\source\repos\Library_Registiration\Library_Registiration\Views\Library\Edit_Book.cshtml"
Write(Html.TextBoxFor(x=>x.Book_name, new{Class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 17 "C:\Users\Samet\source\repos\Library_Registiration\Library_Registiration\Views\Library\Edit_Book.cshtml"
Write(Html.Label("Book Author"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Samet\source\repos\Library_Registiration\Library_Registiration\Views\Library\Edit_Book.cshtml"
Write(Html.TextBoxFor(x=>x.Book_author, new{Class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 21 "C:\Users\Samet\source\repos\Library_Registiration\Library_Registiration\Views\Library\Edit_Book.cshtml"
Write(Html.Label("Book Publisher"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Samet\source\repos\Library_Registiration\Library_Registiration\Views\Library\Edit_Book.cshtml"
Write(Html.TextBoxFor(x=>x.Book_publisher, new{Class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 24 "C:\Users\Samet\source\repos\Library_Registiration\Library_Registiration\Views\Library\Edit_Book.cshtml"
Write(Html.Label("Subject"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Samet\source\repos\Library_Registiration\Library_Registiration\Views\Library\Edit_Book.cshtml"
Write(Html.TextAreaFor(x=>x.Book_subject,10,3, new{Class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button type=\"submit\" class=\"btn-primary \">Update</button>\r\n");
#nullable restore
#line 28 "C:\Users\Samet\source\repos\Library_Registiration\Library_Registiration\Views\Library\Edit_Book.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
