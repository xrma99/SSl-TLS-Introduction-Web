#pragma checksum "C:\Users\t-xinma\source\repos\SSLTLSWeb\Views\Details\Clienthello.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b33ba77a5b9f9836b732a77bc17af041fc8992ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Details_Clienthello), @"mvc.1.0.view", @"/Views/Details/Clienthello.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Details/Clienthello.cshtml", typeof(AspNetCore.Views_Details_Clienthello))]
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
#line 1 "C:\Users\t-xinma\source\repos\SSLTLSWeb\Views\_ViewImports.cshtml"
using SSLTLSWeb;

#line default
#line hidden
#line 2 "C:\Users\t-xinma\source\repos\SSLTLSWeb\Views\_ViewImports.cshtml"
using SSLTLSWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b33ba77a5b9f9836b732a77bc17af041fc8992ae", @"/Views/Details/Clienthello.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21148e7936e0be25ff36149f596c27e0e342f215", @"/Views/_ViewImports.cshtml")]
    public class Views_Details_Clienthello : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(130, 579, true);
            WriteLiteral(@"

<h3><strong>Client Hello</strong></h3>

<ul>
    <li>The highest TLS protocol version it supports;</li>
    <li>A random number;</li>
    <li>A list of suggested cipher suites and suggested compression methods;</li>
    <li>Session ID, if the client is attempting to perform a resumed handshake;</li>
    <li>A list of supported application protocols, such as HTTP/2, if the client can use Application-Layer Protocol Negotiation.</li>
</ul>

<div>
    <a href=""/Details/Index"">
        <strong>
            &lArr; Back
        </strong>
    </a>
</div>       ");
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
