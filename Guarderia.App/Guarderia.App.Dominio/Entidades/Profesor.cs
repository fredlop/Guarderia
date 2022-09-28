using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MatriculaOnline.App.Dominio.Entidades
{
    public class Profesor
    {
        [Key]
        public int IdProfesor { get; set; }
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

        public virtual ICollection<Materia> Materias { get; set; }
    }
}
