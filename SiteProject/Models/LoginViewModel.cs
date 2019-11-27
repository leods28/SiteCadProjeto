using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SiteProject.Models
{
    public class LoginViewModel
    {   
        [Required(ErrorMessage = "Informe um nome de usuário válido")]
        [Display(Name = "Usuário:")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "Informe uma senha válida")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha:")]
        public string Senha { get; set; }

        [Display(Name = "Lembrar-me:")]
        public bool LembrarMe { get; set; }

    }
}