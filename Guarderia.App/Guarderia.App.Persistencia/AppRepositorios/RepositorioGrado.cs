using Guarderia.App.Dominio.Entidades;
using Guarderia.App.Persistencia.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Guarderia.App.Persistencia.AppRepositorios
{
    public class RepositorioGrado : IRepositorioGrado
    {
        private readonly GuarderiasDbContext _guarderiaContext;

        public RepositorioGrado(GuarderiasDbContext guarderiaContext)
        {
            _guarderiaContext = guaredriaContext;
        }

        Grado IRepositorioGrado.AddGrado(Grado grado)
        {
            var gradoAdicionado = _guarderiaContext.Grados.Add(grado);
            _guarderiaContext.SaveChanges();
            return gradoAdicionado.Entity;
        }

        bool IRepositorioGrado.DeleteGrado(int id)
        {
            bool result = false;
            try
            {
                var gradoEncontrado = _guarderiaContext.Grados.FirstOrDefault(g => g.Id == id);
                if (gradoEncontrado == null)
                    return result;
                _guarderiaContext.Grados.Remove(gradoEncontrado);
                _guarderiaContext.SaveChanges();

                result = true;
            }
            catch
            {
                result = false;
            }
            return result;
        }

        IEnumerable<Grado> IRepositorioGrado.GetAllGrados()
        {
            return _guarderiaContext.Grados;
        }

        Grado IRepositorioGrado.GetGrado(int idGrado)
        {
            return _guarderiaContext.Grados.FirstOrDefault(g => g.Id == id);
        }

        Grado IRepositorioGrado.UpdateGrado(Grado grado)
        {
            var gradoEncontrado = _guarderiaContext.Grados.FirstOrDefault(g => g.Id == grado.Id);
            if (gradoEncontrado != null)
            {
                gradoEncontrado.NombreGrado = grado.NombreGrado;
                _guarderiaContext.SaveChanges();
            }
            return gradoEncontrado;
        }
    }
}
