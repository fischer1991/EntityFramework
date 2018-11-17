using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Blog.Infra;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.DAO{
    public class PostDAO{
        public BlogContext contexto;

        public PostDAO(BlogContext contexto){
            this.contexto = contexto;
        }

        public IList<Post> Lista(){          
           
            var lista = contexto.posts.ToList();
            return lista;

        }

        public void Adiciona(Post post, Usuario usuario){
            contexto.usuarios.Attach(usuario);
            post.Autor = usuario;
            contexto.Add(post);
            contexto.SaveChanges();                                     
        }

        public IList<Post> Categoria(string Categoria){
                IList<Post> listaFiltrada;
                return listaFiltrada = contexto.posts.Where(p => p.Categoria.Contains(Categoria)).ToList();
        }

        public void Remove(int id){
            
                Post p = new Post();
                p.ID = id;
                contexto.Entry(p).State = EntityState.Deleted;
                contexto.SaveChanges();

        } 

        public Post BuscaPorID(int id){
                return contexto.posts.Find(id);
        }

        public void Atualiza(Post p){
                contexto.Entry(p).State = EntityState.Modified;
                contexto.SaveChanges();
        }

        public void Publica(int id){
                var p = contexto.posts.Find(id);
                p.Publicado = true;
                p.DataPublicacao = DateTime.Now;
                contexto.SaveChanges();
        }

        public IList<string> ListaCategoriaTermo(string termo){
                return contexto.posts.Where( p => p.Categoria.Contains(termo)).
                                      Select( p => p.Categoria ).Distinct().ToList();
        }

        public IList<Post> ListaPublicados(){
                return contexto.posts.Where( p => p.Publicado ).OrderByDescending(p => p.DataPublicacao).ToList();
        }

        public IList<Post> BuscarPor(string termo){
                return contexto.posts.Where( p => (p.Titulo.Contains(termo) || p.Resumo.Contains(termo)) && p.Publicado ).ToList();
        }
   }
}