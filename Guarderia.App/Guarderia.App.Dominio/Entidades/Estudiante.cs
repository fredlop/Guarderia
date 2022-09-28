using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using System.Text;

namespace MatriculaOnline.App.Dominio.Entidades
{
    public class Estudiante
    {
        [Key]
        public int IdEstudiante { get; set; }
        public string IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public int? IdTipoIdeIdentificacion { get; set; }
        [ForeignKey("IdTipoIdeIdentificacion")]
        public TiposIdentificacion TiposIdentificacion { get; set; }
        public string NumeroDeIdentificacion { get; set; }
        public int? IdGenero { get; set; }

        [ForeignKey("IdGenero")]
        public Genero Genero { get; set; }
        public string Codigo { get; set; }
        public virtual ICollection<Matricula> Matriculas { get; set; }

    }
}
