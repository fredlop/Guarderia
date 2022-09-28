using MatriculaOnline.App.Dominio.Entidades;
using MatriculaOnline.App.Persistencia.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MatriculaOnline.App.Persistencia.AppRepositorios
{
    public class RepositorioGrado : IRepositorioGrado
    {
        private readonly MatriculasDbContext _matriculaContext;

        public RepositorioGrado(MatriculasDbContext matriculaContext)
        {
            _matriculaContext = matriculaContext;
        }

        Grado IRepositorioGrado.AddGrado(Grado grado)
        {
            var gradoAdicionado = _matriculaContext.Grados.Add(grado);
            _matriculaContext.SaveChanges();
            return gradoAdicionado.Entity;
        }

        bool IRepositorioGrado.DeleteGrado(int idGrado)
        {
            bool result = false;
            try
            {
                var gradoEncontrado = _matriculaContext.Grados.FirstOrDefault(g => g.IdGrado == idGrado);
                if (gradoEncontrado == null)
                    return result;
                _matriculaContext.Grados.Remove(gradoEncontrado);
                _matriculaContext.SaveChanges();

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
            return _matriculaContext.Grados;
        }

        Grado IRepositorioGrado.GetGrado(int idGrado)
        {
            return _matriculaContext.Grados.FirstOrDefault(g => g.IdGrado == idGrado);
        }

        Grado IRepositorioGrado.UpdateGrado(Grado grado)
        {
            var gradoEncontrado = _matriculaContext.Grados.FirstOrDefault(g => g.IdGrado == grado.IdGrado);
            if (gradoEncontrado != null)
            {
                gradoEncontrado.NombreGrado = grado.NombreGrado;
                _matriculaContext.SaveChanges();
            }
            return gradoEncontrado;
        }
    }
}
