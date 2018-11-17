using System;
using System.Collections.Generic;
using Blog.DAO;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using Blog.Filters;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace Blog.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AutorizacaoFilter]
    public class PostController : Controller
    {
        private IList<Post> lista;
        public PostDAO dao;
       // [HttpPost]
        // public IActionResult Adiciona(Post post)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         string usuarioJson = HttpContext.Session.GetString("usuario");
        //         Usuario logado = JsonConvert.DeserializeObject<Usuario>(usuarioJson);
        //         dao.Adiciona(post, logado);
        //         return RedirectToAction("Index");
        //     }
        //     else
        //     {
        //       return View("Novo", post);      
        //     }
        // }

        public PostController( PostDAO dao) {
            lista = new List<Post>();
            this.dao = dao;
        }

        public IActionResult Index()
        {      
            lista = dao.Lista(); 
            Console.WriteLine("Testes");
            return View(lista);
        }

        public IActionResult Novo() {
            return View(new Post());
        }

        [HttpPost]
        public IActionResult Adiciona(Post p) {
            if (ModelState.IsValid){
                dao.Adiciona(p);
                return RedirectToAction("Index");
            }else{
                return View("Novo", p);                
            }
        }

        public IActionResult Categoria([Bind(Prefix = "id")] string categoria){
            var listaFiltrada = dao.Categoria(categoria);
            return View("Index", listaFiltrada);
        }

        public IActionResult Categoria([Bind(Prefix = "id")] string categoria, string asdf){
            var listaFiltrada = dao.Categoria(categoria);
            return View("Index", listaFiltrada);
        }

        public IActionResult RemovePost(int id){
            dao.Remove(id);
            return RedirectToAction("Index");
        }

        public IActionResult Visualiza(int id){
            var post = dao.BuscaPorID(id);
            return View(post);
        }
        
        [HttpPost]
        public IActionResult EditaPost(Post p){
            if (ModelState.IsValid){
                dao.Atualiza(p);
                return RedirectToAction("Index");
            } else {
                return View("Visualiza", p);
            }
        }

        public IActionResult Publica(int id){
            dao.Publica(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult CategoriaAutocomplete(string termoDigitado){
            var model = dao.ListaCategoriaTermo(termoDigitado);
            return Json(model);
        }

        
    }
}