#pragma checksum "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1af6006c48a2891ef00a7522bba84fefacb86e5"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1af6006c48a2891ef00a7522bba84fefacb86e5", @"/Views/Home/Index.cshtml")]
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
  
    ViewData["Title"] = "Home";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(137, 143, true);
            WriteLiteral("\r\n<div class=\"container mb-2\">\r\n    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n            <div class=\"form-group\">\r\n                <h2>");
            EndContext();
            BeginContext(281, 37, false);
#line 12 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
               Write(Html.LabelFor(m => m.ContentCarousel));

#line default
#line hidden
            EndContext();
            BeginContext(318, 289, true);
            WriteLiteral(@"</h2>
            </div>
        </div>
    </div>
</div>
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-6 col-12"">
            <h4>Project</h4>
        </div>
        <div class=""col-md-6 col-12"">
            <div class=""form-group"">
                ");
            EndContext();
            BeginContext(608, 46, false);
#line 24 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
           Write(Html.LabelFor(m => m.ContentCarousel.FilePath));

#line default
#line hidden
            EndContext();
            BeginContext(654, 40, true);
            WriteLiteral("\r\n                \r\n                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 694, "\"", 748, 1);
#line 26 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
WriteAttributeValue("", 702, Html.NameFor(m => m.ContentCarousel.FilePath), 702, 46, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(749, 240, true);
            WriteLiteral(">\r\n                    <div class=\"input-group mb-2\">\r\n                        <div class=\"input-group-prepend\">\r\n                            <div class=\"input-group-text\">img/</div>\r\n                        </div>\r\n                        ");
            EndContext();
            BeginContext(990, 81, false);
#line 31 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
                   Write(Html.TextBoxFor(m => m.ContentCarousel.FilePath, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1071, 220, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6 col-12\">\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(1292, 66, false);
#line 41 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
           Write(Html.LabelFor(m => m.ContentCarousel.ThumbnailSlidePair.Thumbnail));

#line default
#line hidden
            EndContext();
            BeginContext(1358, 22, true);
            WriteLiteral("\r\n                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1380, "\"", 1454, 1);
#line 42 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
WriteAttributeValue("", 1388, Html.NameFor(m => m.ContentCarousel.ThumbnailSlidePair.Thumbnail), 1388, 66, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1455, 304, true);
            WriteLiteral(@">
                    <input type=""file"" class=""form-control-file"">
                    <div class=""input-group mb-2"">
                        <div class=""input-group-prepend"">
                            <div class=""input-group-text"">/</div>
                        </div>
                        ");
            EndContext();
            BeginContext(1760, 119, false);
#line 48 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
                   Write(Html.TextBoxFor(m => m.ContentCarousel.ThumbnailSlidePair.Thumbnail, new { @class = "form-control", @disabled = true }));

#line default
#line hidden
            EndContext();
            BeginContext(1879, 185, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-6 col-12\">\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(2065, 71, false);
#line 56 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
           Write(Html.LabelFor(m => m.ContentCarousel.ThumbnailSlidePair.TitleBox.Title));

#line default
#line hidden
            EndContext();
            BeginContext(2136, 22, true);
            WriteLiteral("\r\n                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2158, "\"", 2237, 1);
#line 57 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
WriteAttributeValue("", 2166, Html.NameFor(m => m.ContentCarousel.ThumbnailSlidePair.TitleBox.Title), 2166, 71, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2238, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(2262, 106, false);
#line 58 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
               Write(Html.TextBoxFor(m => m.ContentCarousel.ThumbnailSlidePair.TitleBox.Title, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2368, 44, true);
            WriteLiteral("\r\n                </div>\r\n\r\n                ");
            EndContext();
            BeginContext(2413, 73, false);
#line 61 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
           Write(Html.LabelFor(m => m.ContentCarousel.ThumbnailSlidePair.TitleBox.Caption));

#line default
#line hidden
            EndContext();
            BeginContext(2486, 24, true);
            WriteLiteral("\r\n\r\n                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2510, "\"", 2591, 1);
#line 63 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
WriteAttributeValue("", 2518, Html.NameFor(m => m.ContentCarousel.ThumbnailSlidePair.TitleBox.Caption), 2518, 73, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2592, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(2616, 122, false);
#line 64 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
               Write(Html.TextAreaFor(m => m.ContentCarousel.ThumbnailSlidePair.TitleBox.Caption, new { @class = "form-control", @rows = "5" }));

#line default
#line hidden
            EndContext();
            BeginContext(2738, 159, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"col-md-6 col-12\">\r\n            <div class=\"form-group\">\r\n\r\n                ");
            EndContext();
            BeginContext(2898, 81, false);
#line 72 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
           Write(Html.LabelFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().LeftSlide.Image));

#line default
#line hidden
            EndContext();
            BeginContext(2979, 22, true);
            WriteLiteral("\r\n                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3001, "\"", 3090, 1);
#line 73 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
WriteAttributeValue("", 3009, Html.NameFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().LeftSlide.Image), 3009, 81, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3091, 304, true);
            WriteLiteral(@">
                    <input type=""file"" class=""form-control-file"">
                    <div class=""input-group mb-2"">
                        <div class=""input-group-prepend"">
                            <div class=""input-group-text"">/</div>
                        </div>
                        ");
            EndContext();
            BeginContext(3396, 140, false);
#line 79 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
                   Write(Html.TextBoxFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().LeftSlide.Image, new { @class = "form-control image", @disabled = true }));

#line default
#line hidden
            EndContext();
            BeginContext(3536, 72, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                ");
            EndContext();
            BeginContext(3609, 109, false);
#line 83 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
           Write(Html.LabelFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().LeftSlide.TextBoxes.FirstOrDefault().Header));

#line default
#line hidden
            EndContext();
            BeginContext(3718, 22, true);
            WriteLiteral("\r\n                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3740, "\"", 3857, 1);
#line 84 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
WriteAttributeValue("", 3748, Html.NameFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().LeftSlide.TextBoxes.FirstOrDefault().Header), 3748, 109, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3858, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(3882, 144, false);
#line 85 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
               Write(Html.TextBoxFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().LeftSlide.TextBoxes.FirstOrDefault().Header, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(4026, 42, true);
            WriteLiteral("\r\n                </div>\r\n                ");
            EndContext();
            BeginContext(4069, 107, false);
#line 87 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
           Write(Html.LabelFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().LeftSlide.TextBoxes.FirstOrDefault().Text));

#line default
#line hidden
            EndContext();
            BeginContext(4176, 22, true);
            WriteLiteral("\r\n                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 4198, "\"", 4313, 1);
#line 88 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
WriteAttributeValue("", 4206, Html.NameFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().LeftSlide.TextBoxes.FirstOrDefault().Text), 4206, 107, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4314, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(4338, 156, false);
#line 89 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
               Write(Html.TextAreaFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().LeftSlide.TextBoxes.FirstOrDefault().Text, new { @class = "form-control", @rows = "5" }));

#line default
#line hidden
            EndContext();
            BeginContext(4494, 159, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"col-md-6 col-12\">\r\n            <div class=\"form-group\">\r\n\r\n                ");
            EndContext();
            BeginContext(4654, 82, false);
#line 97 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
           Write(Html.LabelFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().RightSlide.Image));

#line default
#line hidden
            EndContext();
            BeginContext(4736, 22, true);
            WriteLiteral("\r\n                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 4758, "\"", 4848, 1);
#line 98 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
WriteAttributeValue("", 4766, Html.NameFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().RightSlide.Image), 4766, 82, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4849, 304, true);
            WriteLiteral(@">
                    <input type=""file"" class=""form-control-file"">
                    <div class=""input-group mb-2"">
                        <div class=""input-group-prepend"">
                            <div class=""input-group-text"">/</div>
                        </div>
                        ");
            EndContext();
            BeginContext(5154, 141, false);
#line 104 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
                   Write(Html.TextBoxFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().RightSlide.Image, new { @class = "form-control image", @disabled = true }));

#line default
#line hidden
            EndContext();
            BeginContext(5295, 72, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                ");
            EndContext();
            BeginContext(5368, 110, false);
#line 108 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
           Write(Html.LabelFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().RightSlide.TextBoxes.FirstOrDefault().Header));

#line default
#line hidden
            EndContext();
            BeginContext(5478, 22, true);
            WriteLiteral("\r\n                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 5500, "\"", 5618, 1);
#line 109 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
WriteAttributeValue("", 5508, Html.NameFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().RightSlide.TextBoxes.FirstOrDefault().Header), 5508, 110, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5619, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(5643, 145, false);
#line 110 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
               Write(Html.TextBoxFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().RightSlide.TextBoxes.FirstOrDefault().Header, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(5788, 44, true);
            WriteLiteral("\r\n                </div>\r\n\r\n                ");
            EndContext();
            BeginContext(5833, 108, false);
#line 113 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
           Write(Html.LabelFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().RightSlide.TextBoxes.FirstOrDefault().Text));

#line default
#line hidden
            EndContext();
            BeginContext(5941, 22, true);
            WriteLiteral("\r\n                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 5963, "\"", 6079, 1);
#line 114 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
WriteAttributeValue("", 5971, Html.NameFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().RightSlide.TextBoxes.FirstOrDefault().Text), 5971, 108, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6080, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(6104, 157, false);
#line 115 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
               Write(Html.TextAreaFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().RightSlide.TextBoxes.FirstOrDefault().Text, new { @class = "form-control", @rows = "5" }));

#line default
#line hidden
            EndContext();
            BeginContext(6261, 159, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"col-md-6 col-12\">\r\n            <div class=\"form-group\">\r\n\r\n                ");
            EndContext();
            BeginContext(6421, 81, false);
#line 123 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
           Write(Html.LabelFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().LeftSlide.Image));

#line default
#line hidden
            EndContext();
            BeginContext(6502, 22, true);
            WriteLiteral("\r\n                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 6524, "\"", 6613, 1);
#line 124 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
WriteAttributeValue("", 6532, Html.NameFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().LeftSlide.Image), 6532, 81, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6614, 304, true);
            WriteLiteral(@">
                    <input type=""file"" class=""form-control-file"">
                    <div class=""input-group mb-2"">
                        <div class=""input-group-prepend"">
                            <div class=""input-group-text"">/</div>
                        </div>
                        ");
            EndContext();
            BeginContext(6919, 140, false);
#line 130 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
                   Write(Html.TextBoxFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().LeftSlide.Image, new { @class = "form-control image", @disabled = true }));

#line default
#line hidden
            EndContext();
            BeginContext(7059, 72, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                ");
            EndContext();
            BeginContext(7132, 109, false);
#line 134 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
           Write(Html.LabelFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().LeftSlide.TextBoxes.FirstOrDefault().Header));

#line default
#line hidden
            EndContext();
            BeginContext(7241, 22, true);
            WriteLiteral("\r\n                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 7263, "\"", 7380, 1);
#line 135 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
WriteAttributeValue("", 7271, Html.NameFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().LeftSlide.TextBoxes.FirstOrDefault().Header), 7271, 109, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7381, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(7405, 144, false);
#line 136 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
               Write(Html.TextBoxFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().LeftSlide.TextBoxes.FirstOrDefault().Header, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(7549, 42, true);
            WriteLiteral("\r\n                </div>\r\n                ");
            EndContext();
            BeginContext(7592, 107, false);
#line 138 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
           Write(Html.LabelFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().LeftSlide.TextBoxes.FirstOrDefault().Text));

#line default
#line hidden
            EndContext();
            BeginContext(7699, 22, true);
            WriteLiteral("\r\n                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 7721, "\"", 7836, 1);
#line 139 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
WriteAttributeValue("", 7729, Html.NameFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().LeftSlide.TextBoxes.FirstOrDefault().Text), 7729, 107, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7837, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(7861, 156, false);
#line 140 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
               Write(Html.TextAreaFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().LeftSlide.TextBoxes.FirstOrDefault().Text, new { @class = "form-control", @rows = "5" }));

#line default
#line hidden
            EndContext();
            BeginContext(8017, 159, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"col-md-6 col-12\">\r\n            <div class=\"form-group\">\r\n\r\n                ");
            EndContext();
            BeginContext(8177, 82, false);
#line 148 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
           Write(Html.LabelFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().RightSlide.Image));

#line default
#line hidden
            EndContext();
            BeginContext(8259, 22, true);
            WriteLiteral("\r\n                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 8281, "\"", 8371, 1);
#line 149 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
WriteAttributeValue("", 8289, Html.NameFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().RightSlide.Image), 8289, 82, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8372, 304, true);
            WriteLiteral(@">
                    <input type=""file"" class=""form-control-file"">
                    <div class=""input-group mb-2"">
                        <div class=""input-group-prepend"">
                            <div class=""input-group-text"">/</div>
                        </div>
                        ");
            EndContext();
            BeginContext(8677, 141, false);
#line 155 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
                   Write(Html.TextBoxFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().RightSlide.Image, new { @class = "form-control image", @disabled = true }));

#line default
#line hidden
            EndContext();
            BeginContext(8818, 72, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                ");
            EndContext();
            BeginContext(8891, 110, false);
#line 159 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
           Write(Html.LabelFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().RightSlide.TextBoxes.FirstOrDefault().Header));

#line default
#line hidden
            EndContext();
            BeginContext(9001, 22, true);
            WriteLiteral("\r\n                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 9023, "\"", 9141, 1);
#line 160 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
WriteAttributeValue("", 9031, Html.NameFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().RightSlide.TextBoxes.FirstOrDefault().Header), 9031, 110, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9142, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(9166, 145, false);
#line 161 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
               Write(Html.TextBoxFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().RightSlide.TextBoxes.FirstOrDefault().Header, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(9311, 44, true);
            WriteLiteral("\r\n                </div>\r\n\r\n                ");
            EndContext();
            BeginContext(9356, 108, false);
#line 164 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
           Write(Html.LabelFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().RightSlide.TextBoxes.FirstOrDefault().Text));

#line default
#line hidden
            EndContext();
            BeginContext(9464, 22, true);
            WriteLiteral("\r\n                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 9486, "\"", 9602, 1);
#line 165 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
WriteAttributeValue("", 9494, Html.NameFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().RightSlide.TextBoxes.FirstOrDefault().Text), 9494, 108, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9603, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(9627, 157, false);
#line 166 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
               Write(Html.TextAreaFor(m => m.ContentCarousel.SlidePairs.FirstOrDefault().RightSlide.TextBoxes.FirstOrDefault().Text, new { @class = "form-control", @rows = "5" }));

#line default
#line hidden
            EndContext();
            BeginContext(9784, 494, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-12"">
            <div class=""form-group"">
                <button type=""button"" class=""btn btn-success"" id=""generate"">Generate HTML</button>
            </div>
        </div>
    </div>
    <hr>
</div>

<div class=""container"">
    <div class=""row justify-content-middle"">
        <div class=""col-12"">
            <div class=""form-group"">
                <h4>");
            EndContext();
            BeginContext(10279, 28, false);
#line 186 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
               Write(Html.LabelFor(m => m.Output));

#line default
#line hidden
            EndContext();
            BeginContext(10307, 23, true);
            WriteLiteral("</h4>\r\n                ");
            EndContext();
            BeginContext(10331, 126, false);
#line 187 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
           Write(Html.TextAreaFor(m => m.Output, new { @class = "form-control", @id = "output", @rows = "10", @style = "font-family:calibri;"}));

#line default
#line hidden
            EndContext();
            BeginContext(10457, 932, true);
            WriteLiteral(@"
            </div>
        </div>
        <div class=""col-auto mr-auto"">
            <div class=""form-group"">
                <button type=""button"" class=""btn btn-success"" id=""refresh"">Refresh Preview</button>
            </div>
        </div>
        <div class=""col-auto"">
            <div class=""form-group"">

                <button type=""button"" class=""btn btn-dark"" id=""copy"">Copy</button>

            </div>
        </div>
        <div class=""col-12"" style=""min-height: 3rem;text-align:right;"">
            <p class=""copied""></p>
        </div>
    </div>
    
</div>


<div class=""container"">
    <div class=""row"">
        <div class=""col-12 mb-4"">
            <h4>Preview</h4>
        </div>
    </div>
</div>
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-12"">
            <div class=""preview"">
            </div>
        </div>
    </div>

</div>


");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(11407, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 229 "D:\DesignWebsiteContent\DesignWebsiteContent\Views\Home\Index.cshtml"
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
