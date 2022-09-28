using MatriculaOnline.App.Dominio.Entidades;
using MatriculaOnline.App.Persistencia.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MatriculaOnline.App.Persistencia.AppRepositorios
{
    public class RepositorioMateria : IRepositorioMateria
    {
        private readonly MatriculasDbContext _matriculasContext;

        public RepositorioMateria(MatriculasDbContext matriculasContext)
        {
            _matriculasContext = matriculasContext;
        }

        Materia IRepositorioMateria.AddMateria(Materia materium)
        {
            var materiaAdicionada = _matriculasContext.Add(materium);
            _matriculasContext.SaveChanges();
            return materiaAdicionada.Entity;
        }

        void IRepositorioMateria.DeleteMateria(int idMateria)
        {
            var materiaEncontrada = _matriculasContext.Materias.FirstOrDefault(m => m.IdMateria == idMateria);
            if (materiaEncontrada == null)
                return;
            _matriculasContext.Materias.Remove(materiaEncontrada);
            _matriculasContext.SaveChanges();
        }

        IEnumerable<Materia> IRepositorioMateria.GetAllMaterias()
        {
            return _matriculasContext.Materias;
        }

        Materia IRepositorioMateria.GetMateria(int idMateria)
        {
            return _matriculasContext.Materias.FirstOrDefault(m => m.IdMateria == idMateria);
        }

        Materia IRepositorioMateria.UpdateMateria(Materia materia)
        {
            var materiaEncontrada = _matriculasContext.Materias.FirstOrDefault(m => m.IdMateria == materia.IdMateria);
            if (materiaEncontrada != null)
            {
                materiaEncontrada.NombreMateria = materia.NombreMateria;
                materiaEncontrada.IdProfesor = materia.IdProfesor;
                materiaEncontrada.IdGrado = materia.IdGrado;
                _matriculasContext.SaveChanges();
            }
            return materiaEncontrada;
        }
    }
}
