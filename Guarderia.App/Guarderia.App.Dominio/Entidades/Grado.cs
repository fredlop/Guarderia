using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Guarderia.App.Dominio.Entidades
{
    public class Grado
    {
        [Key]
        public int Id { get; set; }
        public string Profesor { get; set; }
        public string Alumnos { get; set; }
        public virtual ICollection<Alumno> Alumnos { get; set; }
         public virtual ICollection<Persona> Personas { get; set; }
    }
}
