using MatriculaOnline.App.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace MatriculaOnline.App.Persistencia.AppRepositorios
{
    public interface IRepositorioMatricula
    {
        IEnumerable<Matricula> GetAllMatriculas();

        Matricula AddMatricula(Matricula matricula);

        Matricula UpdateMatricula(Matricula matricula);

        Matricula GetMatricula(int idMatricula);

        IEnumerable<Matricula> GetMatriculaByEstudianteName(string NombreEstudiante);

        void DeleteMatricula(int idMatricula);

    }
}
