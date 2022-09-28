using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Guarderia.App.Dominio.Entidades;
using Guarderia.App.Persistencia.Model;

namespace Guarderia.App.Persistencia.AppRepositorios
{
    public class RepositorioEstudiante : IRepositorioEstudiante
    {
        private readonly GuarderiaDbContext _guarderiaContext;

        public RepositorioEstudiante(GuarderiaDbContext guarderiaContext)
        {
            _matriculasContext = matriculasContext;
        }

        Estudiante IRepositorioEstudiante.AddEstudiante(Estudiante estudiante)
        {
            var estudianteAdicionado = _matriculasContext.Estudiantes.Add(estudiante);
            _matriculasContext.SaveChanges();
            return estudianteAdicionado.Entity;
        }

        bool IRepositorioEstudiante.DeleteEstudiante(int idEstudiante)
        {
            bool result = false;
            try
            {
                var estudianteEncontrado = _matriculasContext.Estudiantes.FirstOrDefault(g => g.IdEstudiante == idEstudiante);
                if (estudianteEncontrado == null)
                    return result;
                _matriculasContext.Estudiantes.Remove(estudianteEncontrado);
                _matriculasContext.SaveChanges();

                result = true;
            }
            catch
            {
                result = false;
            }
            return result;
        }

        IEnumerable<Estudiante> IRepositorioEstudiante.GetAllEstudiantes()
        {
            return _matriculasContext.Estudiantes;
        }

        Estudiante IRepositorioEstudiante.GetEstudiante(int idEstudiante)
        {
            return _matriculasContext.Estudiantes.FirstOrDefault(e => e.IdEstudiante == idEstudiante);
        }

        Estudiante IRepositorioEstudiante.GetEstudianteByIdUsuario(string IdUsuario)
        {
            var estudiante = _matriculasContext.Estudiantes.FirstOrDefault(p => p.IdUsuario == IdUsuario);
            estudiante.TiposIdentificacion = _matriculasContext.TiposDeIdentificacion.FirstOrDefault(p => p.IdIdentificacion == estudiante.IdTipoIdeIdentificacion);
            estudiante.Genero = _matriculasContext.Generos.FirstOrDefault(p => p.IdGenero == estudiante.IdGenero);
            var listMAtriculas = _matriculasContext.Matriculas.Where(p => p.IdEstudiante == estudiante.IdEstudiante).ToList();
            List<Matricula> matriculaList = new List<Matricula>();  
            foreach (var item in listMAtriculas)
            {
                Matricula newMatricula = new Matricula();
                newMatricula = item;
                newMatricula.Grado = _matriculasContext.Grados.FirstOrDefault(p => p.IdGrado == item.IdGrado);
                newMatricula.Year = _matriculasContext.Years.FirstOrDefault(p => p.IdYear == item.IdYear);
                matriculaList.Add(newMatricula);
            }

            estudiante.Matriculas = matriculaList;
            return estudiante;
        }

        Estudiante IRepositorioEstudiante.UpdateEstudiante(Estudiante estudiante)
        {
            var estudianteEncontrado = _matriculasContext.Estudiantes.FirstOrDefault(e => e.IdEstudiante == estudiante.IdEstudiante);
            if (estudianteEncontrado != null)
            {
                estudianteEncontrado.Nombre = estudiante.Nombre;
                estudianteEncontrado.Apellido = estudiante.Apellido;
                estudianteEncontrado.IdTipoIdeIdentificacion = estudiante.IdTipoIdeIdentificacion;
                estudianteEncontrado.NumeroDeIdentificacion = estudiante.NumeroDeIdentificacion;
                estudianteEncontrado.IdGenero = estudiante.IdGenero;
                estudianteEncontrado.Codigo = estudiante.Codigo;
                _matriculasContext.SaveChanges();
            }
            return estudianteEncontrado;
        }
    }
}
