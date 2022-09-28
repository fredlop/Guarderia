using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MatriculaOnline.App.Dominio.Entidades
{
    public class Registro
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage ="El password no coincide")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }

        [Required]
        public int IdGenero { get; set; }

        [Required]
        public int IdTipoIdeIdentificacion { get; set; }

        [Required]
        public string NumeroDeIdentificacion{ get; set; }

        [Required]
        public string Codigo { get; set; }
    }
}
