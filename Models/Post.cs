using System;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class Post
    {
        [Display(Name="Título")]
        [Required(ErrorMessage="O campo título é obrigatório")]
        [StringLength(50, ErrorMessage="O campo título possui tamanho máximo de 50 caracteres")]
        public String Titulo { get; set; }
        [Required(ErrorMessage="O campo resumo é obrigatório")]
        public string Resumo { get; set; }
        public string Categoria { get; set; }
        public int ID { get;set;}

        public DateTime? DataPublicacao {get; set;}
        public bool Publicado{get; set;}
    }
}
