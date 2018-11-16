

using System.ComponentModel.DataAnnotations;

namespace Blog.Models{
    public class LoginViewModel{
        [Display(Name="Usuário")]
        [Required(ErrorMessage="O campo usuário é obrigatório")]
        public string LoginName {get; set;}

        [Display(Name="Senha")]
        [Required(ErrorMessage="O campo senha é obrigatório")][DataType(DataType.Password)]
        public string Password {get; set;} 
    }
}