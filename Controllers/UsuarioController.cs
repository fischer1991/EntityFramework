using Blog.DAO;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace Blog.Controllers{
    
    public class UsuarioController: Controller{
        public UsuarioDAO usuarioDAO;

        public  UsuarioController(UsuarioDAO dao){
            this.usuarioDAO = dao;
        }      
        public IActionResult Login(){
            
            return View(new LoginViewModel());

        }

        [HttpPost]
        public IActionResult Autentica(LoginViewModel login){
            if(!ModelState.IsValid){
                return View("Login",login);
            }else {
                Usuario usuarioAutenticado = usuarioDAO.Busca(login.LoginName, login.Password);

                if (usuarioAutenticado == null){
                    ModelState.AddModelError("login.Invalido","Login ou senha incorretos");
                    return View("Login",login);
                }else {
                    HttpContext.Session.SetString("usuario", JsonConvert.SerializeObject(usuarioAutenticado));
                    return RedirectToAction("Index","Post",new{area="Admin"});
                }
            }
        }
    }
}