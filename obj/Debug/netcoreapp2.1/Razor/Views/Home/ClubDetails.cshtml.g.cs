#pragma checksum "C:\Users\16475\OneDrive\Desktop\WebAssignment1\WebAssignment1\Views\Home\ClubDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d2163ad0c4e6f7dd3d42064ce3971d18e21f89b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ClubDetails), @"mvc.1.0.view", @"/Views/Home/ClubDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ClubDetails.cshtml", typeof(AspNetCore.Views_Home_ClubDetails))]
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
#line 1 "C:\Users\16475\OneDrive\Desktop\WebAssignment1\WebAssignment1\Views\_ViewImports.cshtml"
using WebAssignment1;

#line default
#line hidden
#line 2 "C:\Users\16475\OneDrive\Desktop\WebAssignment1\WebAssignment1\Views\_ViewImports.cshtml"
using WebAssignment1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d2163ad0c4e6f7dd3d42064ce3971d18e21f89b", @"/Views/Home/ClubDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ba6f541f12ec594f63815c97a9a776c23f8e6e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ClubDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Club>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 77, true);
            WriteLiteral("\r\n<div class=\"panel-body\">\r\n    <div class=\"panel-heading text-center\">  <h1>");
            EndContext();
            BeginContext(91, 14, false);
#line 4 "C:\Users\16475\OneDrive\Desktop\WebAssignment1\WebAssignment1\Views\Home\ClubDetails.cshtml"
                                            Write(Model.ClubName);

#line default
#line hidden
            EndContext();
            BeginContext(105, 149, true);
            WriteLiteral(" </h1></div>\r\n    <table class=\"table table-sm table-striped table-bordered\">\r\n        <tr>\r\n            <td>Official Website:</td>\r\n            <td>");
            EndContext();
            BeginContext(255, 13, false);
#line 8 "C:\Users\16475\OneDrive\Desktop\WebAssignment1\WebAssignment1\Views\Home\ClubDetails.cshtml"
           Write(Model.Website);

#line default
#line hidden
            EndContext();
            BeginContext(268, 86, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Contact NO:</td>\r\n            <td>");
            EndContext();
            BeginContext(355, 11, false);
#line 12 "C:\Users\16475\OneDrive\Desktop\WebAssignment1\WebAssignment1\Views\Home\ClubDetails.cshtml"
           Write(Model.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(366, 81, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Email:</td>\r\n            <td>");
            EndContext();
            BeginContext(448, 11, false);
#line 16 "C:\Users\16475\OneDrive\Desktop\WebAssignment1\WebAssignment1\Views\Home\ClubDetails.cshtml"
           Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(459, 46, true);
            WriteLiteral("</td>\r\n        </tr>\r\n\r\n    </table>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Club> Html { get; private set; }
    }
}
#pragma warning restore 1591