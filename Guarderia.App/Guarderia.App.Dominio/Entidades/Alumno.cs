using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using System.Text;

namespace Guarderia.App.Dominio.Entidades
{
    public class Alumno
    {
        [Key]
        public int Id { get; set; }
        public string Fecha_nacimiento { get; set; }
        public string Hora_entrada { get; set; }
        public string Hora_salida { get; set; }
        public string Padre { get; set; }
        public string Madre { get; set; }
        public string Acudiente { get; set; }

        public int? IdGrado { get; set; }
        [ForeignKey("IdGrado")]
        public Grado Grado { get; set; }
        public virtual ICollection<Guarderia> Guarderias { get; set; }

    }
}
