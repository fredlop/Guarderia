using MatriculaOnline.App.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace MatriculaOnline.App.Persistencia.AppRepositorios
{
    public interface IRepositorioMateria
    {
        IEnumerable<Materia> GetAllMaterias();
        Materia AddMateria(Materia materium);
        Materia UpdateMateria(Materia materia);

        Materia GetMateria(int idMateria);

        void DeleteMateria(int idMateria);
    }
}
