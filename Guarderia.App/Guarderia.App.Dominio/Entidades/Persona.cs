using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Guarderia.App.Dominio.Entidades
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Numero_telefono { get; set; }
        public string Correo { get; set; }
        
        public int? IdGrado { get; set; }
        [ForeignKey("IdGrado")]
        public Grado Grado { get; set; }
        public virtual ICollection<Guarderia> Guarderias { get; set; }
    }
}
