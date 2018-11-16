using Microsoft.EntityFrameworkCore;
using Blog.Models;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Blog.Infra{

    public class BlogContext: DbContext{
        
        public DbSet<Post> posts {get; set;}
        public DbSet<Usuario> usuarios {get; set;}
        public BlogContext(DbContextOptions<BlogContext> options):base(options){

        }
    }
}