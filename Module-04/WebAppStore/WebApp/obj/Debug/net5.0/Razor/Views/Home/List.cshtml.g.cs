#pragma checksum "D:\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Home\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98e113e1f89a290f579d638ef30baf51166e21af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_List), @"mvc.1.0.view", @"/Views/Home/List.cshtml")]
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
#line 1 "D:\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98e113e1f89a290f579d638ef30baf51166e21af", @"/Views/Home/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee2e25ed8b2fdc34cc2ed11280fba0ebc34d2baa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n");
#nullable restore
#line 4 "D:\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Home\List.cshtml"
         foreach (Category item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2 class=\"a\">");
#nullable restore
#line 6 "D:\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Home\List.cshtml"
                     Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <div class=\"row hide\">\r\n");
#nullable restore
#line 8 "D:\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Home\List.cshtml"
                 foreach (Product product in item.Products)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-4\">\r\n                        <h3>");
#nullable restore
#line 11 "D:\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Home\List.cshtml"
                       Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\\</h3>\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 385, "\"", 430, 2);
            WriteAttributeValue("", 391, "/photos/", 391, 8, true);
#nullable restore
#line 12 "D:\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Home\List.cshtml"
WriteAttributeValue("", 399, product.ImageUrl.Split(',')[0], 399, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"70\" />\r\n                    </div>\r\n");
#nullable restore
#line 14 "D:\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Home\List.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 16 "D:\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Home\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<style>\r\n.a{\r\n    cursor: pointer;\r\n}\r\n.hide {\r\n    display: none;\r\n}\r\n</style>\r\n<script>\r\n    $(\'.a\').click(function () {\r\n        $(this).next(\'div\').toggleClass(\'hide\');\r\n    });\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
