using MatriculaOnline.App.Dominio.Entidades;
using MatriculaOnline.App.Persistencia.AppRepositorios;
using MatriculaOnline.App.Persistencia.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Matriculas.App.WebApp.Pages.Administrativo.Materias
{
    [Authorize(Roles = "Administrador,Administrativo")]
    public class EditModel : PageModel
    {
        private readonly MatriculasDbContext _db;
        private static IRepositorioMateria _repoMaterias;

        [BindProperty]
        public Materia dataMateria { get; set; }
        public IEnumerable<Grado> Grados { get; set; }
        public IEnumerable<Profesor> Profesores { get; set; }

        public EditModel(MatriculasDbContext db)
        {
            _db = db;
            _repoMaterias = new RepositorioMateria(_db);
        }

        public async Task OnGet(int id)
        {
            Grados = await _db.Grados.ToListAsync();
            Profesores = await _db.Profesores.ToListAsync();
            dataMateria = _repoMaterias.GetMateria(id);
        }

        public IActionResult OnPost()
        {
            var profesor = Request.Form["profesor"];
            var grado = Request.Form["grado"];
            int intProfesor = int.Parse(profesor);
            int intGrado = int.Parse(grado);
            dataMateria.IdGrado = intGrado;
            dataMateria.IdProfesor = intProfesor;

            var newMateria = new Materia()
            {
                IdMateria = dataMateria.IdMateria,
                NombreMateria = dataMateria.NombreMateria,
                IdGrado = intGrado,
                IdProfesor = intProfesor
            };

            var result = _repoMaterias.UpdateMateria(newMateria);
            if (result != null)
            {
                return RedirectToPage("Index");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Ocurrio un error al insertar el registro");
            }

            return Page();

        }

    }
}
