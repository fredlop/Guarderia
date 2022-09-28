using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MatriculaOnline.App.Dominio.Entidades
{
    public class Genero
    {
        [Key]
        public int IdGenero { get; set; }
        public string NombreGenero { get; set; }
    }
}
