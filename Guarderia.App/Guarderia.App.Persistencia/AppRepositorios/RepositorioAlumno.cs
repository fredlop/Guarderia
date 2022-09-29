using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Guarderia.App.Dominio.Entidades;
using Guarderia.App.Persistencia.Model;

namespace Guarderia.App.Persistencia.AppRepositorios
{
    public class RepositorioAlumno : IRepositorioAlumno
    {
        private readonly GuarderiaDbContext _guarderiaContext;

        public RepositorioAlumno(GuarderiaDbContext guarderiaContext)
        {
            _guarderiaContext = guarderiaContext;
        }

        Alumno IRepositorioAlumno.AddAlumno(Alumno alumno)
        {
            var alumnoAdicionado = _guarderiaContext.Alumnos.Add(alumno);
            _guarderiaContext.SaveChanges();
            return alumnoAdicionado.Entity;
        }

        bool IRepositorioAlumno.DeleteAlumno(int id)
        {
            bool result = false;
            try
            {
                var alumnoEncontrado = _guarderiaContext.Alumnos.FirstOrDefault(g => g.Id == id);
                if (alumnoEncontrado == null)
                    return result;
                _guarderiasContext.Alumnos.Remove(alumnoEncontrado);
                _guarderiasContext.SaveChanges();

                result = true;
            }
            catch
            {
                result = false;
            }
            return result;
        }

        IEnumerable<Alumno> IRepositorioAlumno.GetAllAlumnos()
        {
            return _guarderiasContext.Alumnos;
        }

        Alumno IRepositorioAlumno.GetAlumno(int id)
        {
            return _guarderiasContext.Estudiantes.FirstOrDefault(e => e.IdAlumno == id);
        }

        Alumno IRepositorioAlumno.GetAlumnoById(string Id)
        {
            var alumno = _guaredriasContext.Alumnos.FirstOrDefault(p => p.Id == Id);
            alumno.TiposIdentificacion = _guarderiasContext.Grado.FirstOrDefault(p => p.Id == alumno.IdGrado);
            var listGuarderias = _guarderiasContext.Guarderias.Where(p => p.Id == alumno.Id).ToList();
            List<Guarderia> guarderiaList = new List<Guarderia>();  
            foreach (var item in listGuarderias)
            {
                Guarderia newGuarderia = new Guarderia();
                newGuarderia = item;
                newGuarderia.Grado = _guarderiasContext.Grados.FirstOrDefault(p => p.Id == item.Id);
                guarderiaList.Add(newGuarderia);
            }

            alumno.Guarderias = guarderiaList;
            return alumno;
        }

        Alumno IRepositorioAlumno.UpdateAlumno(Alumno alumno)
        {
            var alumnoEncontrado = _guarderiasContext.Alumnos.FirstOrDefault(e => e.Id == alumno.Id);
            if (alumnoEncontrado != null)
            {
                alumnoEncontrado.Fecha_nacimiento = alumno.Fecha_nacimiento;
                alumnoEncontrado.Hora_entrada = alumno.Hora_entrada;
                alumnoEncontrado.Hora_salida = alumno.Hora_salida;
                alumnoEncontrado.Padre = alumno.Padre;
                alumnoEncontrado.Madre = alumno.Madre;
                alumnoEncontrado.Acudiente = alumno.Acudiente;
                alumnoEncontrado.Id_grado = estudiante.Id_grado;
                _guarderiasContext.SaveChanges();
            }
            return alumnoEncontrado;
        }
    }
}
