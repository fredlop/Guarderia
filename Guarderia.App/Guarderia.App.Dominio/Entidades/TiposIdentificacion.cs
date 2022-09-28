using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MatriculaOnline.App.Dominio.Entidades
{
    public class TiposIdentificacion
    {
        [Key]
        public int IdIdentificacion { get; set; }
        public string NombreIdentificacion { get; set; }
    }
}
