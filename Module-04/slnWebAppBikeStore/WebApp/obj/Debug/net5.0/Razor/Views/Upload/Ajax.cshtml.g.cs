#pragma checksum "D:\asp.net261T4TN\Module-04\slnWebAppBikeStore\WebApp\Views\Upload\Ajax.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e7205a17e4f5cac72ec860e13ac33c79f8e839a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Upload_Ajax), @"mvc.1.0.view", @"/Views/Upload/Ajax.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e7205a17e4f5cac72ec860e13ac33c79f8e839a", @"/Views/Upload/Ajax.cshtml")]
    public class Views_Upload_Ajax : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<form enctype=""multipart/form-data"" method=""post"" name=""frm"">
    <input type=""file"" name=""f"" />
    <button>Upload</button>
</form>

<div id=""rs""></div>

<script>
    $(frm).submit(function (ev) {
        ev.preventDefault();
        //var f = frm['f'].files[0];
        //console.log(f.name);
        var fd = new FormData();
        fd.append('f', frm['f'].files[0]);
        $.ajax({
            url: '/upload/ajax',
            type: 'post',
            data: fd,
            processData: false,
            contentType: false,
            success: function (o) {
                //Console.log(o);
                $(rs).append(`<img width=""100"" src=""/upload/${o.name}"" />`);
            }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
