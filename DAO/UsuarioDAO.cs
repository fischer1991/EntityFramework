using System.Linq;
using Blog.Infra;
using Blog.Models;

namespace Blog.DAO{
    public class UsuarioDAO{
        public BlogContext contexto;

        public UsuarioDAO(BlogContext context){
            this.contexto = context;
        }

        public Usuario Busca(string Login, string Senha){
            return contexto.usuarios.Where( u => u.Nome.Equals(Login) && u.Senha.Equals(Senha)).
                                        FirstOrDefault<Usuario>();
        }
        public void Adiciona(Usuario usuario)
        {
            contexto.usuarios.Add(usuario);
            contexto.SaveChanges();
        }
    }
}