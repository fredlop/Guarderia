using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MatriculaOnline.App.Dominio.Entidades
{
    public partial class Matricula
    {
        [Key]
        public int IdMatricula { get; set; }

        [ForeignKey("Estudiante")]
        public int IdEstudiante { get; set; }
        public Estudiante Estudiante { get; set; }

        [ForeignKey("Grado")]
        public int IdGrado { get; set; }
        public Grado Grado { get; set; }

        [ForeignKey("Year")]
        public int IdYear { get; set; }
        public Year Year { get; set; }
    }
}
