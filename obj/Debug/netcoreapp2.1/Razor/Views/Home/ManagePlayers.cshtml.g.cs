#pragma checksum "C:\Users\16475\OneDrive\Desktop\WebAssignment1\WebAssignment1\Views\Home\ManagePlayers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a322e153be6ba2f10aa8b791e203b59997d834e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ManagePlayers), @"mvc.1.0.view", @"/Views/Home/ManagePlayers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ManagePlayers.cshtml", typeof(AspNetCore.Views_Home_ManagePlayers))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a322e153be6ba2f10aa8b791e203b59997d834e0", @"/Views/Home/ManagePlayers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ba6f541f12ec594f63815c97a9a776c23f8e6e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ManagePlayers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 579, true);
            WriteLiteral(@"<div class=""panel-body"">
    <div class=""panel-heading text-center""><h1>Here is the list of all the Players </h1></div>
    <table class=""table table-sm table-striped table-bordered"">
        <thead>
            <tr>
                <th>
                    First Name
                </th>
                <th>
                    Last Name
                </th>
                <th>Age</th>
                <th>Position</th>
                <th>Contact</th>
            </tr>
        </thead>
        <tbody>
           
        </tbody>
    </table>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
