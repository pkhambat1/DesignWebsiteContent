#pragma checksum "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7937ca6299e7570a9f98396a2525103e5edb5c0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\_ViewImports.cshtml"
using DesignWebsiteContent;

#line default
#line hidden
#line 2 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\_ViewImports.cshtml"
using DesignWebsiteContent.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7937ca6299e7570a9f98396a2525103e5edb5c0e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3ca8a87137d228f8e1eda02d668009e4ee19d68", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DesignWebsiteContent.Models.InputOutput>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(91, 166, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <h2>Home</h2>\r\n        <div class=\"col-md-6 col-12\">\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(258, 27, false);
#line 12 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
           Write(Html.LabelFor(m => m.Input));

#line default
#line hidden
            EndContext();
            BeginContext(285, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(304, 106, false);
#line 13 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
           Write(Html.TextAreaFor(m => m.Input, new { @class = "form-control", @id = "input", @rows = "10", @cols = "20" }));

#line default
#line hidden
            EndContext();
            BeginContext(410, 282, true);
            WriteLiteral(@"
            </div>
            <div class=""form-group"">
                <button type=""button"" class=""btn btn-success"" id=""convert"">Convert</button>
            </div>
        </div>
        <div class=""col-md-6 col-12"">
            <div class=""form-group"">
                ");
            EndContext();
            BeginContext(693, 28, false);
#line 21 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
           Write(Html.LabelFor(m => m.Output));

#line default
#line hidden
            EndContext();
            BeginContext(721, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(740, 108, false);
#line 22 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
           Write(Html.TextAreaFor(m => m.Output, new { @class = "form-control", @id = "output", @rows = "10", @cols = "20" }));

#line default
#line hidden
            EndContext();
            BeginContext(848, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
            BeginContext(1024, 38, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1080, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 32 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DesignWebsiteContent.Models.InputOutput> Html { get; private set; }
    }
}
#pragma warning restore 1591
