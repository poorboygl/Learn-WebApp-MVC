#pragma checksum "D:\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Home\Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0616b23659c0d28bbcb13fe8eb7c097e27a4d84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Category), @"mvc.1.0.view", @"/Views/Home/Category.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0616b23659c0d28bbcb13fe8eb7c097e27a4d84", @"/Views/Home/Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee2e25ed8b2fdc34cc2ed11280fba0ebc34d2baa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::WebApp.PaginationTagHelper __WebApp_PaginationTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pagination", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0616b23659c0d28bbcb13fe8eb7c097e27a4d842890", async() => {
            }
            );
            __WebApp_PaginationTagHelper = CreateTagHelper<global::WebApp.PaginationTagHelper>();
            __tagHelperExecutionContext.Add(__WebApp_PaginationTagHelper);
#nullable restore
#line 8 "D:\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Home\Category.cshtml"
__WebApp_PaginationTagHelper.Size = 10;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("size", __WebApp_PaginationTagHelper.Size, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            WriteLiteral("/home/category/");
#nullable restore
#line 8 "D:\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Home\Category.cshtml"
                                  WriteLiteral(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("/{0}");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __WebApp_PaginationTagHelper.Url = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("url", __WebApp_PaginationTagHelper.Url, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 8 "D:\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Home\Category.cshtml"
__WebApp_PaginationTagHelper.Total = ViewBag.total;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("total", __WebApp_PaginationTagHelper.Total, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
#nullable restore
#line 12 "D:\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Home\Category.cshtml"
  
    int p = Convert.ToInt32(@ViewContext.RouteData.Values["p"]) - 1;
    if (p == -1)
    {
        p = 0;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 21 "D:\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Home\Category.cshtml"
Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n");
#nullable restore
#line 22 "D:\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Home\Category.cshtml"
Write(ViewContext.RouteData.Values["p"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n<script>\r\n    $($(\'.pagination li.page-item\')[");
#nullable restore
#line 25 "D:\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Home\Category.cshtml"
                               Write(p);

#line default
#line hidden
#nullable disable
            WriteLiteral("]).addClass(\'active\');\r\n</script>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-3\">\r\n        <ul>\r\n");
#nullable restore
#line 31 "D:\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Home\Category.cshtml"
             foreach (Category item in ViewBag.categories)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("href", " href=\"", 771, "\"", 809, 2);
            WriteAttributeValue("", 778, "/home/category/", 778, 15, true);
#nullable restore
#line 33 "D:\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Home\Category.cshtml"
WriteAttributeValue("", 793, item.CategoryId, 793, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 33 "D:\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Home\Category.cshtml"
                                                         Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 34 "D:\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Home\Category.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n    <div class=\"col-9\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 39 "D:\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Home\Category.cshtml"
             foreach (Product item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-6\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1054, "\"", 1089, 2);
            WriteAttributeValue("", 1061, "/home/detail/", 1061, 13, true);
#nullable restore
#line 42 "D:\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Home\Category.cshtml"
WriteAttributeValue("", 1074, item.ProductId, 1074, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><h3>");
#nullable restore
#line 42 "D:\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Home\Category.cshtml"
                                                          Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1145, "\"", 1180, 2);
            WriteAttributeValue("", 1152, "/home/detail/", 1152, 13, true);
#nullable restore
#line 43 "D:\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Home\Category.cshtml"
WriteAttributeValue("", 1165, item.ProductId, 1165, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 1230, "\"", 1272, 2);
            WriteAttributeValue("", 1236, "/photos/", 1236, 8, true);
#nullable restore
#line 44 "D:\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Home\Category.cshtml"
WriteAttributeValue("", 1244, item.ImageUrl.Split(',')[0], 1244, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1273, "\"", 1296, 1);
#nullable restore
#line 44 "D:\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Home\Category.cshtml"
WriteAttributeValue("", 1279, item.ProductName, 1279, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </a>\r\n                    <p>Price: <b>");
#nullable restore
#line 46 "D:\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Home\Category.cshtml"
                            Write(item.UnitOfPrice.ToString("#,###"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                </div>\r\n");
#nullable restore
#line 48 "D:\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Home\Category.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
