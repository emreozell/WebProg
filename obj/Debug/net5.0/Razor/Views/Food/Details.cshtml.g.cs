#pragma checksum "C:\Users\ASUS\source\repos\WebOdev\Views\Food\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "850df23dd75e89ac7743a84ff7391a59185588f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_Details), @"mvc.1.0.view", @"/Views/Food/Details.cshtml")]
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
#line 1 "C:\Users\ASUS\source\repos\WebOdev\Views\_ViewImports.cshtml"
using WebOdev;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\WebOdev\Views\_ViewImports.cshtml"
using WebOdev.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"850df23dd75e89ac7743a84ff7391a59185588f4", @"/Views/Food/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98f3774794d3c6eb510431a7a67f53e959bd8910", @"/Views/_ViewImports.cshtml")]
    public class Views_Food_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebOdev.Models.Food>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ASUS\source\repos\WebOdev\Views\Food\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n<div class=\"site-cover site-cover-sm same-height overlay single-page\"");
            BeginWriteAttribute("style", " style=\"", 192, "\"", 245, 4);
            WriteAttributeValue("", 200, "background-image:", 200, 17, true);
            WriteAttributeValue(" ", 217, "url(\'/images/", 218, 14, true);
#nullable restore
#line 8 "C:\Users\ASUS\source\repos\WebOdev\Views\Food\Details.cshtml"
WriteAttributeValue("", 231, Model.Resim, 231, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 243, "\')", 243, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""container"">
        <div class=""row same-height justify-content-center"">
            <div class=""col-md-12 col-lg-10"">
                <div class=""post-entry text-center"">
                    <span class=""post-category text-white bg-success mb-3"">");
#nullable restore
#line 13 "C:\Users\ASUS\source\repos\WebOdev\Views\Food\Details.cshtml"
                                                                      Write(Model.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <h1 class=\"mb-4\"><a href=\"#\">");
#nullable restore
#line 14 "C:\Users\ASUS\source\repos\WebOdev\Views\Food\Details.cshtml"
                                            Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></h1>
                    <div class=""post-meta align-items-center text-center"">
                  
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<section class=""site-section py-lg"">
    <div class=""container"">

        <div class=""row blog-entries element-animate"">

");
            WriteLiteral("            <div class=\"col-md-12 col-lg-10 main-content\">\r\n                <div class=\"post-content-body\">\r\n                    <p>\r\n                        ");
#nullable restore
#line 33 "C:\Users\ASUS\source\repos\WebOdev\Views\Food\Details.cshtml"
                   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n\r\n\r\n                </div>\r\n            </div>\r\n\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebOdev.Models.Food> Html { get; private set; }
    }
}
#pragma warning restore 1591
