using MatriculaOnline.App.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace MatriculaOnline.App.Persistencia.AppRepositorios
{
    public interface IRepositorioProfesor
    {
        IEnumerable<Profesor> GetAllProfesores();

        Profesor AddProfesor(Profesor profesor);

        Profesor UpdateProfesor(Profesor profesor);

        Profesor GetProfesor(int idProfesor);

        Profesor GetProfesorByIdUsuario(string IdUsuario);

        bool DeleteProfesor(int idProfesor);
    }
}
