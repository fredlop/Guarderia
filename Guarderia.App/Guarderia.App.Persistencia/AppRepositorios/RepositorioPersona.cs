using Guarderia.App.Dominio.Entidades;
using Guarderia.App.Persistencia.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Guarderia.App.Persistencia.AppRepositorios
{
    public class RepositorioPersona : IRepositorioPersona
    {
        private readonly GuarderiasDbContext _guarderiasContext;

        public RepositorioProfesor(GuarderiasDbContext guarderiasContext)
        {
            _guarderiasContext = guarderiasContext;
        }

        Persona IRepositorioPersona.AddPersona(Persona persona)
        {
            var personaAdicionado = _guarderiasContext.Persona.Add(persona);
            _guarderiasContext.SaveChanges();
            return personaAdicionado.Entity;
        }

        bool IRepositorioPersona.DeletePersona(int idPersona)
        {
            bool result = false;
            try
            {
                var personaEncontrado = _guarderiasContext.Personas.FirstOrDefault(g => g.idPersona == idPersona);
                if (personaEncontrado == null)
                    return result;
                _guarderiasContext.Personas.Remove(personaEncontrado);
                _guarderiasContext.SaveChanges();

                result = true;
            }
            catch
            {
                result = false;
            }
            return result;
        }

        IEnumerable<Persona> IRepositorioPersona.GetAllPersonas()
        {
            return _guarderiasContext.Personas;
        }

        Persona IRepositorioPersona.GetPersona(int id)
        {
            return _guarderiasContext.Personas.FirstOrDefault(p => p.Id == id);
        }

        Persona IRepositorioPersona.GetPersonaById(string Id)
        {
            var persona = _guarderiasContext.Personas.FirstOrDefault(p => p.Id == Id);
            persona.Grado = _guarderiasContext.Grado.FirstOrDefault(p => p.Id == persona.Id);
            persona.Grados = _guarderiasContext.Grados.Where(p => p.Id == persona.Id).ToList();
            return persona;
        }

        Persona IRepositorioPersona.UpdatePersona(Persona persona)
        {
            var personaEncontrado = _guarderiasContext.Personas.FirstOrDefault(p => p.Id == persona.Id);
      
            if (personaEncontrado != null)
            {
                personaEncontrado.Nombre = persona.Nombre;
                personaEncontrado.Apellido = persona.Apellido;
                personaEncontrado.Cedula = persona.Cedula;
                personaEncontrado.Numero_telefono = persona.Numero_telefono;
                personaEncontrado.Correo = persona.Correo;
                personaEncontrado.Id_grado = persona.Id_grado;
                _guarderiasContext.SaveChanges();
            }
    
            return personaEncontrado;
        }
    }
}
