#pragma checksum "C:\Home\github\razor-pages\Pages\2columns\2Columns.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf145859edc090ce6763ed3934f0c99ae2eef53e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(razor_pages.Pages._2columns.Pages_2columns_2Columns), @"mvc.1.0.razor-page", @"/Pages/2columns/2Columns.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/2columns/2Columns.cshtml", typeof(razor_pages.Pages._2columns.Pages_2columns_2Columns), null)]
namespace razor_pages.Pages._2columns
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Home\github\razor-pages\Pages\_ViewImports.cshtml"
using razor_pages;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf145859edc090ce6763ed3934f0c99ae2eef53e", @"/Pages/2columns/2Columns.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d45e63f997e68bd8ec1dfbd8cb9a4057c4fad5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_2columns_2Columns : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Home\github\razor-pages\Pages\2columns\2Columns.cshtml"
  
    Layout = "Shared/2ColumnLayout";

#line default
#line hidden
            BeginContext(52, 44, true);
            WriteLiteral("<div>I\'m using the 2 column layout</div>\r\n\r\n");
            EndContext();
            DefineSection("RightColumn", async() => {
                BeginContext(117, 36, true);
                WriteLiteral("\r\n    I\'m the right column content\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_2columns_2Columns> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_2columns_2Columns> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_2columns_2Columns>)PageContext?.ViewData;
        public Pages_2columns_2Columns Model => ViewData.Model;
    }
}
#pragma warning restore 1591
