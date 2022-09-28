using MatriculaOnline.App.Dominio.Entidades;
using MatriculaOnline.App.Persistencia.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;
using Microsoft.EntityFrameworkCore.Storage;

namespace MatriculaOnline.App.Persistencia.AppRepositorios
{
    public class RepositorioMatricula : IRepositorioMatricula
    {
        private readonly MatriculasDbContext _matriculasContext;

        public RepositorioMatricula(MatriculasDbContext matriculasContext)
        {
            _matriculasContext = matriculasContext;
        }

        Matricula IRepositorioMatricula.AddMatricula(Matricula matricula)
        {
            var matriculaAdicionada = _matriculasContext.Matriculas.Add(matricula);
            _matriculasContext.SaveChanges();
            return matriculaAdicionada.Entity;
        }

        void IRepositorioMatricula.DeleteMatricula(int idMatricula)
        {
            var matriculaEncontrada = _matriculasContext.Matriculas.FirstOrDefault(m => m.IdMatricula == idMatricula);
            if (matriculaEncontrada == null)
                return;
            _matriculasContext.Matriculas.Remove(matriculaEncontrada);
            _matriculasContext.SaveChanges();
        }

        IEnumerable<Matricula> IRepositorioMatricula.GetAllMatriculas()
        {
            return _matriculasContext.Matriculas;
        }

        Matricula IRepositorioMatricula.GetMatricula(int idMatricula)
        {
            var matricula = _matriculasContext.Matriculas.FirstOrDefault(m => m.IdMatricula == idMatricula);
            matricula.Grado = _matriculasContext.Grados.First(g => g.IdGrado == matricula.IdGrado);
            matricula.Year = _matriculasContext.Years.First(g => g.IdYear == matricula.IdYear);
            matricula.Estudiante = _matriculasContext.Estudiantes.First(g => g.IdEstudiante == matricula.IdEstudiante);
            return matricula;
        }

        IEnumerable<Matricula> IRepositorioMatricula.GetMatriculaByEstudianteName(String  NombreEstudiante)
        {
            var estudiantes = _matriculasContext.Estudiantes.Where(e => e.Nombre.Contains(NombreEstudiante) || e.Apellido.Contains(NombreEstudiante)).ToList();
            List<int> estudiantesIDs = estudiantes.Select(i => i.IdEstudiante).ToList();
            var matriculas = _matriculasContext.Matriculas.Where(m => estudiantesIDs.Contains(m.IdEstudiante));
            var grados = _matriculasContext.Grados.ToList();
            var years = _matriculasContext.Years.ToList();

            List<Matricula> resultMatriculas = new List<Matricula>();
            foreach (var matricula in matriculas) 
            {
                Matricula newMatricula = new Matricula();
                newMatricula = matricula;
                newMatricula.Grado = grados.First(g => g.IdGrado == matricula.IdGrado);
                newMatricula.Year = years.First(g => g.IdYear == matricula.IdYear);
                newMatricula.Estudiante = estudiantes.First(g => g.IdEstudiante == matricula.IdEstudiante);
                resultMatriculas.Add(newMatricula);
            }
           
            return resultMatriculas;
        }

        Matricula IRepositorioMatricula.UpdateMatricula(Matricula matricula)
        {
            var matriculaEncontrada = _matriculasContext.Matriculas.FirstOrDefault(m => m.IdMatricula == matricula.IdMatricula);
            if (matriculaEncontrada != null)
            {
                matriculaEncontrada = matricula;
                _matriculasContext.SaveChanges();
            }
            return matriculaEncontrada;
        }
    }
}
