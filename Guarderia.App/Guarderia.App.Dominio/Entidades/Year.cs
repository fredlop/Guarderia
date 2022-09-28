using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MatriculaOnline.App.Dominio.Entidades
{
    public class Year
    {
        [Key]
        public int IdYear { get; set; }
        public string NombreYear { get; set; }
    }
}
