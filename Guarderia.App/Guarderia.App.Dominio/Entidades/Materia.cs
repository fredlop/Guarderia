using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MatriculaOnline.App.Dominio.Entidades
{
    public class Materia
    {
        [Key]
        public int IdMateria { get; set; }

        public string NombreMateria { get; set; }

        public int? IdGrado { get; set; }
        [ForeignKey("IdGrado")]
        public virtual Grado Grado { get; set; }

        public int? IdProfesor { get; set; }
        [ForeignKey("IdProfesor")]
        public virtual Profesor Profesor { get; set; }
    }
}
