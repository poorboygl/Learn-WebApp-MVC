#pragma checksum "D:\asp.net261T4TN\Module-04\slnWebAppBikeStore\WebApp\Views\Brand\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78427c5aeac869d78bcc71bba89e894347d09966"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Brand_Index), @"mvc.1.0.view", @"/Views/Brand/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78427c5aeac869d78bcc71bba89e894347d09966", @"/Views/Brand/Index.cshtml")]
    public class Views_Brand_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebApp.Models.Brand>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Button trigger modal -->
<button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#staticBackdrop"">
    Launch static backdrop modal
</button>

<!-- Modal -->
<div class=""modal fade"" id=""staticBackdrop"" data-backdrop=""static"" data-keyboard=""false"" tabindex=""-1"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <form class=""modal-content"" action=""/brand/create"" method=""post"" name=""frm"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""staticBackdropLabel"">Modal title</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <input type=""hidden"" name=""id"" />
                <div>
                    <label>Name</label>
                    <input type=""text"" name=""name"" />
                </d");
            WriteLiteral(@"iv>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                <button class=""btn btn-primary"">Understood</button>
            </div>
        </form>
    </div>
</div>

");
            WriteLiteral("\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Name</th>\r\n            <th>Edit</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 52 "D:\asp.net261T4TN\Module-04\slnWebAppBikeStore\WebApp\Views\Brand\Index.cshtml"
         foreach (WebApp.Models.Brand item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 55 "D:\asp.net261T4TN\Module-04\slnWebAppBikeStore\WebApp\Views\Brand\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 56 "D:\asp.net261T4TN\Module-04\slnWebAppBikeStore\WebApp\Views\Brand\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><i");
            BeginWriteAttribute("v", " v=\"", 1989, "\"", 2001, 1);
#nullable restore
#line 57 "D:\asp.net261T4TN\Module-04\slnWebAppBikeStore\WebApp\Views\Brand\Index.cshtml"
WriteAttributeValue("", 1993, item.Id, 1993, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"far fa-edit\"></i></td>\r\n            </tr>\r\n");
#nullable restore
#line 59 "D:\asp.net261T4TN\Module-04\slnWebAppBikeStore\WebApp\Views\Brand\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
<script>
    $('.fa-edit').click(function () {
        var m = new bootstrap.Modal(staticBackdrop); //id=staticBackdrop
        m.show();
        //console.log($(this).attr('v'));
        var v = $(this).attr('v');
        $.get('/brand/detail/' + v, function (o) {
            console.log(o);
            $(frm['id']).val(o['id']);
            $(frm['name']).val(o['name']);
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebApp.Models.Brand>> Html { get; private set; }
    }
}
#pragma warning restore 1591
