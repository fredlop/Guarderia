using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MatriculaOnline.App.Dominio.Entidades
{
    public class Grado
    {
        [Key]
        public int IdGrado { get; set; }
        public string NombreGrado { get; set; }
        public virtual ICollection<Materia> Materias { get; set; }
    }
}
