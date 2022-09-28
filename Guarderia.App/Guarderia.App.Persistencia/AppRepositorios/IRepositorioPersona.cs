using Guarderia.App.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guarderia.App.Persistencia.AppRepositorios
{
    public interface IRepositorioPersona
    {
        IEnumerable<Persona> GetAllPersonas();

        Persona AddPersona(Persona persona);

        Persona UpdatePersona(Persona persona);

        Persona GetPersona(int id);

        Persona GetPersonaById(string Id);

        bool DeletePersona(int id);
    }
}
