using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spmedicalgroup_webapi.ViewModels
{
    /// <summary>
    /// Classe responsável pelo modelo de Login
    /// </summary>
    public class LoginViewModels
    {
        //Define que o email é obrigatorio
        [Required(ErrorMessage ="Informe o E-mail do Usuário")]
        public string Email { get; set; }
        //Define que a senha é obrigatoria
        [Required(ErrorMessage ="Informe a Senha do Usuário")]
        public string  Senha { get; set; }
    }
}
