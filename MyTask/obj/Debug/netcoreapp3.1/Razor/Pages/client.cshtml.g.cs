#pragma checksum "C:\Users\MVC\source\repos\MyTask\Pages\client.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7760a57df3081b7d36b2f0e3375c92d2ec55aca7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyTask.Pages.Pages_client), @"mvc.1.0.razor-page", @"/Pages/client.cshtml")]
namespace MyTask.Pages
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
#line 1 "C:\Users\MVC\source\repos\MyTask\Pages\_ViewImports.cshtml"
using MyTask;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7760a57df3081b7d36b2f0e3375c92d2ec55aca7", @"/Pages/client.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54c9d05f85e5647622316e133860c3885c70ebce", @"/Pages/_ViewImports.cshtml")]
    public class Pages_client : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div id=""result"">

</div>
<script src=""https://code.jquery.com/jquery-1.12.4.min.js""></script>
<script>
    $( document ).ready(function() {
        $.ajax({
            type: 'GET',
            url: 'https://localhost:44310/handler?=employee_name',
            contentType: 'json',
            success: function (data) {
                var result = JSON.parse(data);

                for (var i = 0; i < result.length; i++)
                {
                    $(""#result"").append(""<br>""+result[i]);
                }
            },
            error: function () {
                alert(""Page Not Found"");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_client> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_client> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_client>)PageContext?.ViewData;
        public Pages_client Model => ViewData.Model;
    }
}
#pragma warning restore 1591
