#pragma checksum "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Novo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0a11d2600400a049863f7f2c2170e4f022e767d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Post_Novo), @"mvc.1.0.view", @"/Areas/Admin/Views/Post/Novo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Post/Novo.cshtml", typeof(AspNetCore.Areas_Admin_Views_Post_Novo))]
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
#line 1 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\_ViewImports.cshtml"
using Blog.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0a11d2600400a049863f7f2c2170e4f022e767d", @"/Areas/Admin/Views/Post/Novo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"887d246da44e986970baa8a30bab746cfd1ca913", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Post_Novo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog.Models.Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Novo.cshtml"
 using(@Html.BeginForm("Adiciona", "Post")){
    

#line default
#line hidden
            BeginContext(79, 23, false);
#line 4 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Novo.cshtml"
Write(Html.EditorFor( p => p));

#line default
#line hidden
            EndContext();
            BeginContext(106, 70, true);
            WriteLiteral("    <button class=\"btn btn-primary\" type=\"submit\">Cadastrar</button>\r\n");
            EndContext();
#line 7 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Novo.cshtml"
}

#line default
#line hidden
            BeginContext(179, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(198, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(205, 24, false);
#line 10 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Novo.cshtml"
Write(Html.Partial("_Scripts"));

#line default
#line hidden
                EndContext();
                BeginContext(229, 2, true);
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog.Models.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
