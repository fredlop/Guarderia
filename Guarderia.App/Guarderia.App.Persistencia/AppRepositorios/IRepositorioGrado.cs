using MatriculaOnline.App.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace MatriculaOnline.App.Persistencia.AppRepositorios
{
    public interface IRepositorioGrado
    {
        IEnumerable<Grado> GetAllGrados();

        Grado AddGrado(Grado grado);

        Grado UpdateGrado(Grado grado);

        Grado GetGrado(int idGrado);

        bool DeleteGrado(int idGrado);
    }
}
