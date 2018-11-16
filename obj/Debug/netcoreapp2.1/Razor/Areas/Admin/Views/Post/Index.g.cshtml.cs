#pragma checksum "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0382f0abbe4a98ce369650cf8330e3b36d18608c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Post_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Post/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Post/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Post_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0382f0abbe4a98ce369650cf8330e3b36d18608c", @"/Areas/Admin/Views/Post/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"887d246da44e986970baa8a30bab746cfd1ca913", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Post_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Blog.Models.Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 27, true);
            WriteLiteral("\r\n<h2>Lista de Posts</h2>\r\n");
            EndContext();
            BeginContext(60, 83, false);
#line 4 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Index.cshtml"
Write(Html.ActionLink("Incluir post","Novo", null, null, new{ @class ="btn btn-primary"}));

#line default
#line hidden
            EndContext();
            BeginContext(143, 272, true);
            WriteLiteral(@"

<table class=""table table-striped table-hover table-bordered"">
	<caption>Lista dos posts cadastrados no blog.</caption>
	<thead>
		<tr>
			<th>Post</th>
			<th>Categoria</th>
			<th>Publicado em</th>
			<th colspan=""2"">Ações</th>
		</tr>
	</thead>
	<tbody>
");
            EndContext();
#line 17 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Index.cshtml"
         foreach(var p in Model){

#line default
#line hidden
            BeginContext(444, 43, true);
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t\r\n\t\t\t\t\t<h4>\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(488, 57, false);
#line 22 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Index.cshtml"
                   Write(Html.ActionLink(@p.Titulo, "Visualiza",new {Id = @p.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(545, 23, true);
            WriteLiteral("\r\n\t\t\t\t\t\t</h4>\r\n\t\t\t\t\t<p>");
            EndContext();
            BeginContext(569, 8, false);
#line 24 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Index.cshtml"
                  Write(p.Resumo);

#line default
#line hidden
            EndContext();
            BeginContext(577, 25, true);
            WriteLiteral("</p>\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(603, 11, false);
#line 26 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Index.cshtml"
               Write(p.Categoria);

#line default
#line hidden
            EndContext();
            BeginContext(614, 17, true);
            WriteLiteral("</td>\r\n\t\t\t\t<td>\r\n");
            EndContext();
#line 28 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Index.cshtml"
                     if(@p.Publicado){
						

#line default
#line hidden
            BeginContext(663, 74, false);
#line 29 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Index.cshtml"
                   Write(Html.Raw(string.Format("{0: dd/MM/yyyy} às {0:HH:mm}", @p.DataPublicacao)));

#line default
#line hidden
            EndContext();
#line 29 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Index.cshtml"
                                                                                                   ;
					}else{
						

#line default
#line hidden
            BeginContext(760, 25, false);
#line 31 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Index.cshtml"
                   Write(Html.Raw("Não publicado"));

#line default
#line hidden
            EndContext();
#line 31 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Index.cshtml"
                                                  ;
					}

#line default
#line hidden
            BeginContext(796, 32, true);
            WriteLiteral("\t\t\t\t</td>\r\n\t\t\t\t\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(829, 58, false);
#line 36 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Index.cshtml"
               Write(Html.ActionLink("Remover","RemovePost", new { ID = @p.ID}));

#line default
#line hidden
            EndContext();
            BeginContext(887, 26, true);
            WriteLiteral("\t\t\t\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n");
            EndContext();
#line 39 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Index.cshtml"
                     if(!@p.Publicado){
						

#line default
#line hidden
            BeginContext(946, 56, false);
#line 40 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Index.cshtml"
                   Write(Html.ActionLink("Publicar","Publica", new { ID = @p.ID}));

#line default
#line hidden
            EndContext();
#line 40 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Index.cshtml"
                                                                                 
					}

#line default
#line hidden
            BeginContext(1012, 22, true);
            WriteLiteral("\t\t\t\t</td>\r\n\t\t\t</tr>\t\r\n");
            EndContext();
#line 44 "C:\Users\aspnet7892\Documents\LC\Blog\Areas\Admin\Views\Post\Index.cshtml"
		}

#line default
#line hidden
            BeginContext(1039, 19, true);
            WriteLiteral("\t</tbody>\r\n</table>");
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