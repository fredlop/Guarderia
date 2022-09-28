using MatriculaOnline.App.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace MatriculaOnline.App.Persistencia.AppRepositorios
{
    public interface IRepositorioEstudiante
    {
        IEnumerable<Estudiante> GetAllEstudiantes();

        Estudiante AddEstudiante(Estudiante estudiante);

        Estudiante UpdateEstudiante(Estudiante estudiante);

        Estudiante GetEstudiante(int idEstudiante);

        Estudiante GetEstudianteByIdUsuario(string IdUsuario);

        bool DeleteEstudiante(int idEstudiante);
    }
}
