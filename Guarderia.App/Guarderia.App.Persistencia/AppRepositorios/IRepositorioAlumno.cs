using Guarderia.App.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guarderia.App.Persistencia.AppRepositorios
{
    public interface IRepositorioAlumno
    {
        IEnumerable<Alumno> GetAllAlumnos();

        Alumno AddAlumno(Alumno alumno);

        Alumno UpdateAlumno(Alumno alumno);

        Alumno GetAlumno(int id);

        Alumno GetAlumnoById(string Id);

        bool DeleteAlumno(int id);
    }
}
