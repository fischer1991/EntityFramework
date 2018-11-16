using System.Collections.Generic;
using Blog.DAO;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
	public class HomeController: Controller
	{
		private PostDAO dao;

		public HomeController(PostDAO dao){
			this.dao = dao;
		}
		public IActionResult Index(){
			IList<Post> publicados = dao.ListaPublicados();
			return View(publicados);
		}

		public IActionResult Busca(string termo){			
			if(string.IsNullOrEmpty(termo)){
				return RedirectToAction("Index");
			}else {
				var listabuscada = dao.BuscarPor(termo);
				return View("Index",listabuscada);
			}
        }
	}
}