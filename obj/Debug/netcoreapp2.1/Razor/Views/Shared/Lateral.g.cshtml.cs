#pragma checksum "C:\Users\aspnet7892\Documents\LC\Blog\Views\Shared\Lateral.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31fa5f74feee132d6f472f7e28c08da2e74c543a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Lateral), @"mvc.1.0.view", @"/Views/Shared/Lateral.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Lateral.cshtml", typeof(AspNetCore.Views_Shared_Lateral))]
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
#line 1 "C:\Users\aspnet7892\Documents\LC\Blog\Views\_ViewImports.cshtml"
using Blog.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31fa5f74feee132d6f472f7e28c08da2e74c543a", @"/Views/Shared/Lateral.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d1121c9a2f25f76d56b45f4806a37b9fee91b8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Lateral : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 59, true);
            WriteLiteral("<aside>\r\n    <div>\r\n        <h3>Buscar</h3>\r\n    </div>\r\n\r\n");
            EndContext();
#line 6 "C:\Users\aspnet7892\Documents\LC\Blog\Views\Shared\Lateral.cshtml"
     using(@Html.BeginForm("Busca","Home",FormMethod.Get, new {@class = "inline-form"})){

#line default
#line hidden
            BeginContext(150, 47, true);
            WriteLiteral("        <div class=\"input-group\">\r\n            ");
            EndContext();
            BeginContext(198, 87, false);
#line 8 "C:\Users\aspnet7892\Documents\LC\Blog\Views\Shared\Lateral.cshtml"
       Write(Html.TextBox("termo", null, new {@class = "form-control", placeholder="Buscar por..."}));

#line default
#line hidden
            EndContext();
            BeginContext(285, 167, true);
            WriteLiteral("\r\n\r\n            <span class=\"input-group-append\">\r\n                <button class=\"btn btn-primary\" type=\"submit\">Ok</button>\r\n            </span>\r\n        </div>    \r\n");
            EndContext();
#line 14 "C:\Users\aspnet7892\Documents\LC\Blog\Views\Shared\Lateral.cshtml"
    }

#line default
#line hidden
            BeginContext(459, 141, true);
            WriteLiteral("\r\n    <div id=\"categorias\">\r\n        <h3>Categorias</h3>\r\n    </div>\r\n    <div id=\"autores\">\r\n        <h3>Autores</h3>\r\n    </div>\r\n</aside> ");
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
