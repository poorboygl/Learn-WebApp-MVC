#pragma checksum "D:\asp.net261T4TN\Module-04\slnWebAppBikeStore\WebApp\Areas\Dashboard\Views\Store\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa9327c87d795917987a4e236552860267bc6c42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Dashboard_Views_Store_Index), @"mvc.1.0.view", @"/Areas/Dashboard/Views/Store/Index.cshtml")]
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
#line 1 "D:\asp.net261T4TN\Module-04\slnWebAppBikeStore\WebApp\Areas\Dashboard\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa9327c87d795917987a4e236552860267bc6c42", @"/Areas/Dashboard/Views/Store/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7aa39adb7117bb7594389d2bee5f9b30f1af029", @"/Areas/Dashboard/Views/_ViewImports.cshtml")]
    public class Areas_Dashboard_Views_Store_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Store>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<a href=""/dashboard/store/create"" class=""btn btn-primary"">Create</a>
<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Phone</th>
            <th>Email</th>
            <th>Street</th>
            <th>City</th>
            <th>State</th>
            <th>ZipCode</th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 19 "D:\asp.net261T4TN\Module-04\slnWebAppBikeStore\WebApp\Areas\Dashboard\Views\Store\Index.cshtml"
         foreach (Store item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 22 "D:\asp.net261T4TN\Module-04\slnWebAppBikeStore\WebApp\Areas\Dashboard\Views\Store\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "D:\asp.net261T4TN\Module-04\slnWebAppBikeStore\WebApp\Areas\Dashboard\Views\Store\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "D:\asp.net261T4TN\Module-04\slnWebAppBikeStore\WebApp\Areas\Dashboard\Views\Store\Index.cshtml"
               Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "D:\asp.net261T4TN\Module-04\slnWebAppBikeStore\WebApp\Areas\Dashboard\Views\Store\Index.cshtml"
               Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "D:\asp.net261T4TN\Module-04\slnWebAppBikeStore\WebApp\Areas\Dashboard\Views\Store\Index.cshtml"
               Write(item.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "D:\asp.net261T4TN\Module-04\slnWebAppBikeStore\WebApp\Areas\Dashboard\Views\Store\Index.cshtml"
               Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "D:\asp.net261T4TN\Module-04\slnWebAppBikeStore\WebApp\Areas\Dashboard\Views\Store\Index.cshtml"
               Write(item.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "D:\asp.net261T4TN\Module-04\slnWebAppBikeStore\WebApp\Areas\Dashboard\Views\Store\Index.cshtml"
               Write(item.ZipCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 31 "D:\asp.net261T4TN\Module-04\slnWebAppBikeStore\WebApp\Areas\Dashboard\Views\Store\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Store>> Html { get; private set; }
    }
}
#pragma warning restore 1591
