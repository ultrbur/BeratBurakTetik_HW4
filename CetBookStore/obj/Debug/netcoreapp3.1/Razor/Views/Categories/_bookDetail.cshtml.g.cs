#pragma checksum "C:\Users\Berat Burak Tetik\Desktop\GitHub\BeratBurakTetik_HW4\CetBookStore\Views\Categories\_bookDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aebfb8278e7d140443ee7187b6ca37a3aa16da1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories__bookDetail), @"mvc.1.0.view", @"/Views/Categories/_bookDetail.cshtml")]
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
#line 1 "C:\Users\Berat Burak Tetik\Desktop\GitHub\BeratBurakTetik_HW4\CetBookStore\Views\_ViewImports.cshtml"
using CetBookStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Berat Burak Tetik\Desktop\GitHub\BeratBurakTetik_HW4\CetBookStore\Views\_ViewImports.cshtml"
using CetBookStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aebfb8278e7d140443ee7187b6ca37a3aa16da1d", @"/Views/Categories/_bookDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"707d4729bdbc90453f54b4a9e8aa730a59206bfa", @"/Views/_ViewImports.cshtml")]
    public class Views_Categories__bookDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CetBookStore.Models.Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <div>\n         <h4> ");
#nullable restore
#line 3 "C:\Users\Berat Burak Tetik\Desktop\GitHub\BeratBurakTetik_HW4\CetBookStore\Views\Categories\_bookDetail.cshtml"
         Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n\n        <dl class=\"row\">\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 7 "C:\Users\Berat Burak Tetik\Desktop\GitHub\BeratBurakTetik_HW4\CetBookStore\Views\Categories\_bookDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.Authors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 10 "C:\Users\Berat Burak Tetik\Desktop\GitHub\BeratBurakTetik_HW4\CetBookStore\Views\Categories\_bookDetail.cshtml"
           Write(Html.DisplayFor(model => model.Authors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>          \n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 13 "C:\Users\Berat Burak Tetik\Desktop\GitHub\BeratBurakTetik_HW4\CetBookStore\Views\Categories\_bookDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10 alert-danger\" >\n                ");
#nullable restore
#line 16 "C:\Users\Berat Burak Tetik\Desktop\GitHub\BeratBurakTetik_HW4\CetBookStore\Views\Categories\_bookDetail.cshtml"
           Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n           \n        </dl>\n    </div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CetBookStore.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
