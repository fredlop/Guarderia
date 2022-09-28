using Guarderia.App.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guarderia.App.Persistencia.AppRepositorios
{
    public interface IRepositorioGrado
    {
        IEnumerable<Grado> GetAllGrados();

        Grado AddGrado(Grado grado);

        Grado UpdateGrado(Grado grado);

        Grado GetGrado(int id);

        bool DeleteGrado(int id);
    }
}
