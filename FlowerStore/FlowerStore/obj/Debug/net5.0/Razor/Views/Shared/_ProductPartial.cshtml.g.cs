#pragma checksum "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Shared\_ProductPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b56ea7fae2466f95eb2dabd44d5c967bbd7c5170"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductPartial), @"mvc.1.0.view", @"/Views/Shared/_ProductPartial.cshtml")]
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
#line 1 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\_ViewImports.cshtml"
using FlowerStore.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\_ViewImports.cshtml"
using FlowerStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b56ea7fae2466f95eb2dabd44d5c967bbd7c5170", @"/Views/Shared/_ProductPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe9dc3f933a48cef12520dd54ffebe326d2c3eef", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Shared\_ProductPartial.cshtml"
 foreach (var item in Model)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-sm-6 col-md-4 col-lg-3 mt-3\">\r\n        <div class=\"product-item text-center\" data-id=\"");
#nullable restore
#line 6 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Shared\_ProductPartial.cshtml"
                                                  Write(item.Category.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n            <div class=\"img\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 245, "\"", 252, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 9 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Shared\_ProductPartial.cshtml"
               Write(Html.Raw(item.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n            </div>\r\n            <div class=\"title mt-3\">\r\n                <h6>");
#nullable restore
#line 13 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Shared\_ProductPartial.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            </div>\r\n            <div class=\"price\">\r\n                <span class=\"text-black-50\">Add to cart</span>\r\n                <span class=\"text-black-50\">");
#nullable restore
#line 17 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Shared\_ProductPartial.cshtml"
                                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 21 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Shared\_ProductPartial.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
