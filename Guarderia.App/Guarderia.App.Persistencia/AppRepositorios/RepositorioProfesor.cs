using MatriculaOnline.App.Dominio.Entidades;
using MatriculaOnline.App.Persistencia.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MatriculaOnline.App.Persistencia.AppRepositorios
{
    public class RepositorioProfesor : IRepositorioProfesor
    {
        private readonly MatriculasDbContext _matriculasContext;

        public RepositorioProfesor(MatriculasDbContext matriculasContext)
        {
            _matriculasContext = matriculasContext;
        }

        Profesor IRepositorioProfesor.AddProfesor(Profesor profesor)
        {
            var profesorAdicionado = _matriculasContext.Profesores.Add(profesor);
            _matriculasContext.SaveChanges();
            return profesorAdicionado.Entity;
        }

        bool IRepositorioProfesor.DeleteProfesor(int idProfesor)
        {
            bool result = false;
            try
            {
                var profesorEncontrado = _matriculasContext.Profesores.FirstOrDefault(g => g.IdProfesor == idProfesor);
                if (profesorEncontrado == null)
                    return result;
                _matriculasContext.Profesores.Remove(profesorEncontrado);
                _matriculasContext.SaveChanges();

                result = true;
            }
            catch
            {
                result = false;
            }
            return result;
        }

        IEnumerable<Profesor> IRepositorioProfesor.GetAllProfesores()
        {
            return _matriculasContext.Profesores;
        }

        Profesor IRepositorioProfesor.GetProfesor(int idProfesor)
        {
            return _matriculasContext.Profesores.FirstOrDefault(p => p.IdProfesor == idProfesor);
        }

        Profesor IRepositorioProfesor.GetProfesorByIdUsuario(string IdUsuario)
        {
            var profesor = _matriculasContext.Profesores.FirstOrDefault(p => p.IdUsuario == IdUsuario);
            profesor.TiposIdentificacion = _matriculasContext.TiposDeIdentificacion.FirstOrDefault(p => p.IdIdentificacion == profesor.IdTipoIdeIdentificacion);
            profesor.Genero = _matriculasContext.Generos.FirstOrDefault(p => p.IdGenero == profesor.IdGenero);
            profesor.Materias = _matriculasContext.Materias.Where(p => p.IdProfesor == profesor.IdProfesor).ToList();
            return profesor;
        }

        Profesor IRepositorioProfesor.UpdateProfesor(Profesor profesor)
        {
            var profesorEncontrado = _matriculasContext.Profesores.FirstOrDefault(p => p.IdProfesor == profesor.IdProfesor);
      
            if (profesorEncontrado != null)
            {
                profesorEncontrado.Nombre = profesor.Nombre;
                profesorEncontrado.Apellido = profesor.Apellido;
                profesorEncontrado.NumeroDeIdentificacion = profesor.NumeroDeIdentificacion;
                profesorEncontrado.IdGenero = profesor.IdGenero;
                profesorEncontrado.IdTipoIdeIdentificacion = profesor.IdTipoIdeIdentificacion;
                _matriculasContext.SaveChanges();
            }
    
            return profesorEncontrado;
        }
    }
}
