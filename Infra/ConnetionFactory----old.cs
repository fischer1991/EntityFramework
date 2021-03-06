using System.Data.SqlClient;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Blog.Infra{
    public class ConnectionFactory{
        public static SqlConnection CriaConexaoAberta(){
            var builder = new ConfigurationBuilder()
                             .SetBasePath(Directory.GetCurrentDirectory())
                             .AddJsonFile("appsettings.json", optional:false,reloadOnChange:true)
                             .AddEnvironmentVariables();
            IConfiguration configuration = builder.Build();
            string  stringconexao = configuration.GetConnectionString("Blog");
            SqlConnection conexao = new SqlConnection(stringconexao);
            conexao.Open();

            return conexao;
        }
    }
}