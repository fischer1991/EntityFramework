using System.Collections.Generic;
using Blog.DAO;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Areas.Api.Controllers
{
    [Area("Api")]
    [ApiController]
    [Route("/api/post")]
    public class PostApiController : ControllerBase
    {
       private readonly PostDAO dao;
       public PostApiController (PostDAO dao) 
       {
           this.dao = dao;
       }
        [HttpGet]
        [Route("lista")]
        public IActionResult BuscaTodosPosts(){
            IList <Post> posts = dao.Lista();
            return Ok(posts);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult BuscaPostPorId (int id){
            return Ok(dao.BuscaPorID(id));
        }
    
    }

}