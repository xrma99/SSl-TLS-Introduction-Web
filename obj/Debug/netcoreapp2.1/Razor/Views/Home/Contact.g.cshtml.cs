#pragma checksum "C:\Users\t-xinma\source\repos\SSLTLSWeb\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a34a7116163d476b2d27d7aaf3b1d39c8098888e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a34a7116163d476b2d27d7aaf3b1d39c8098888e", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21148e7936e0be25ff36149f596c27e0e342f215", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\t-xinma\source\repos\SSLTLSWeb\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(43, 199, true);
            WriteLiteral("\r\n    <style>\r\n        #Co {\r\n            font-size: 14px;\r\n            font-weight: bold; /*字体粗细*/\r\n            background-color: #E1FCE0;\r\n            color: black;\r\n        }\r\n    </style>\r\n\r\n<h2>");
            EndContext();
            BeginContext(243, 17, false);
#line 14 "C:\Users\t-xinma\source\repos\SSLTLSWeb\Views\Home\Contact.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(260, 11, true);
            WriteLiteral("</h2>\r\n<h4>");
            EndContext();
            BeginContext(272, 18, false);
#line 15 "C:\Users\t-xinma\source\repos\SSLTLSWeb\Views\Home\Contact.cshtml"
Write(ViewData["Author"]);

#line default
#line hidden
            EndContext();
            BeginContext(290, 270, true);
            WriteLiteral(@"</h4>

<address>
    No.999 Zixing Rd,<br />
    Shanghai, China.<br />
    <abbr title=""Phone"">Tel:</abbr>
    (+86) 186-1683-5187
</address>

<address>
    <strong>E-mail:</strong> <a href=""t-xinma@microsoft.com"">Support@microsoft.com</a><br />
</address>
");
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
