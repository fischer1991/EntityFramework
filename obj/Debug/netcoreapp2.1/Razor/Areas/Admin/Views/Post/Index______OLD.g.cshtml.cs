#pragma checksum "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Index______OLD.csHtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a16c06a31e3fb107f77e18dab68013790c4d4628"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Post_Index______OLD), @"mvc.1.0.view", @"/Areas/Admin/Views/Post/Index______OLD.csHtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Post/Index______OLD.csHtml", typeof(AspNetCore.Areas_Admin_Views_Post_Index______OLD))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a16c06a31e3fb107f77e18dab68013790c4d4628", @"/Areas/Admin/Views/Post/Index______OLD.csHtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"887d246da44e986970baa8a30bab746cfd1ca913", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Post_Index______OLD : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Blog.Models.Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(34, 212, true);
            WriteLiteral("\r\n<h1>Lista de Posts</h1>\r\n<table border=\"1\">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t<th>Titulo</th>\r\n\t\t\t<th>Resumo</th>\r\n\t\t\t<th>Categoria</th>\r\n\t\t\t<th>Publicado</th>\r\n\t\t\t<th colspan=\"2\">Ações</th>\r\n\t\t</tr>\r\n\t</thead>\r\n\t<tbody>\r\n");
            EndContext();
#line 16 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Index______OLD.csHtml"
         foreach(var post in Model){

#line default
#line hidden
            BeginContext(278, 17, true);
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(296, 62, false);
#line 18 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Index______OLD.csHtml"
               Write(Html.ActionLink(@post.Titulo,"Visualiza", new { ID= @post.ID}));

#line default
#line hidden
            EndContext();
            BeginContext(358, 15, true);
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(374, 11, false);
#line 19 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Index______OLD.csHtml"
               Write(post.Resumo);

#line default
#line hidden
            EndContext();
            BeginContext(385, 15, true);
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(401, 14, false);
#line 20 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Index______OLD.csHtml"
               Write(post.Categoria);

#line default
#line hidden
            EndContext();
            BeginContext(415, 17, true);
            WriteLiteral("</td>\r\n\t\t\t\t<td>\r\n");
            EndContext();
#line 22 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Index______OLD.csHtml"
                     if(@post.Publicado){
						

#line default
#line hidden
            BeginContext(467, 77, false);
#line 23 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Index______OLD.csHtml"
                   Write(Html.Raw(string.Format("{0: dd/MM/yyyy} às {0:HH:mm}", @post.DataPublicacao)));

#line default
#line hidden
            EndContext();
#line 23 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Index______OLD.csHtml"
                                                                                                      ;
					}else{
						

#line default
#line hidden
            BeginContext(567, 15, false);
#line 25 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Index______OLD.csHtml"
                   Write(Html.Raw("Não"));

#line default
#line hidden
            EndContext();
#line 25 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Index______OLD.csHtml"
                                        ;
					}

#line default
#line hidden
            BeginContext(593, 21, true);
            WriteLiteral("\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n");
            EndContext();
#line 29 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Index______OLD.csHtml"
                     if(!@post.Publicado){
						

#line default
#line hidden
            BeginContext(650, 59, false);
#line 30 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Index______OLD.csHtml"
                   Write(Html.ActionLink("Publicar","Publica", new { ID = @post.ID}));

#line default
#line hidden
            EndContext();
#line 30 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Index______OLD.csHtml"
                                                                                    
					}

#line default
#line hidden
            BeginContext(719, 26, true);
            WriteLiteral("\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(746, 61, false);
#line 34 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Index______OLD.csHtml"
               Write(Html.ActionLink("Remover","RemovePost", new { ID = @post.ID}));

#line default
#line hidden
            EndContext();
            BeginContext(807, 26, true);
            WriteLiteral("\t\t\t\r\n\t\t\t\t</td>\r\n\t\t\t</tr>\r\n");
            EndContext();
#line 37 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Index______OLD.csHtml"
		}	

#line default
#line hidden
            BeginContext(839, 21, true);
            WriteLiteral("\t</tbody>\r\n</table>\r\n");
            EndContext();
            BeginContext(861, 35, false);
#line 40 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Index______OLD.csHtml"
Write(Html.ActionLink("Novo post","Novo"));

#line default
#line hidden
            EndContext();
            BeginContext(896, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Blog.Models.Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
