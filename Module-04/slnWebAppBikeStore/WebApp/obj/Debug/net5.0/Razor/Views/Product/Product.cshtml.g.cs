#pragma checksum "D:\asp.net261T4TN\Module-04\slnWebAppBikeStore\WebApp\Views\Product\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48b333246d846af77ba0388b38602dbe8df9005a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Product), @"mvc.1.0.view", @"/Views/Product/Product.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48b333246d846af77ba0388b38602dbe8df9005a", @"/Views/Product/Product.cshtml")]
    public class Views_Product_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebApp.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table class=""table table-bordered"">
    <thead class=""table-primary"">
        <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Brand</th>
            <th>Category</th>
            <th>Model Year</th>
            <th>Price</th>
            <th>Edit</th>
        </tr>
    </thead>
    <tbody id=""sheet"">
");
#nullable restore
#line 16 "D:\asp.net261T4TN\Module-04\slnWebAppBikeStore\WebApp\Views\Product\Product.cshtml"
         foreach (WebApp.Models.Product item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 19 "D:\asp.net261T4TN\Module-04\slnWebAppBikeStore\WebApp\Views\Product\Product.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "D:\asp.net261T4TN\Module-04\slnWebAppBikeStore\WebApp\Views\Product\Product.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "D:\asp.net261T4TN\Module-04\slnWebAppBikeStore\WebApp\Views\Product\Product.cshtml"
               Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "D:\asp.net261T4TN\Module-04\slnWebAppBikeStore\WebApp\Views\Product\Product.cshtml"
               Write(item.BrandName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "D:\asp.net261T4TN\Module-04\slnWebAppBikeStore\WebApp\Views\Product\Product.cshtml"
               Write(item.ModelYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "D:\asp.net261T4TN\Module-04\slnWebAppBikeStore\WebApp\Views\Product\Product.cshtml"
               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 745, "\"", 774, 2);
            WriteAttributeValue("", 752, "/product/edit/", 752, 14, true);
#nullable restore
#line 26 "D:\asp.net261T4TN\Module-04\slnWebAppBikeStore\WebApp\Views\Product\Product.cshtml"
WriteAttributeValue("", 766, item.Id, 766, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-edit\"></i></a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 29 "D:\asp.net261T4TN\Module-04\slnWebAppBikeStore\WebApp\Views\Product\Product.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebApp.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
