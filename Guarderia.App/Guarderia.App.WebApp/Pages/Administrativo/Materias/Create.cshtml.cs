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
    public class CreateModel : PageModel
    {

        private readonly MatriculasDbContext _db;
        private static IRepositorioMateria _repoMateria;
        [BindProperty]
        public Materia Model { get; set; }
        public IEnumerable<Grado> Grados { get; set; }
        public IEnumerable<Profesor> Profesores { get; set; }

        public CreateModel(MatriculasDbContext db)
        {
            _db = db;
            _repoMateria = new RepositorioMateria(_db);

        }
        public async Task OnGet()
        {
            Grados = await _db.Grados.ToListAsync();
            Profesores = await _db.Profesores.ToListAsync();
        }

        public IActionResult OnPost()
        {
            var profesor = Request.Form["profesor"];
            var grado = Request.Form["grado"];
            int intProfesor = int.Parse(profesor);
            int intGrado = int.Parse(grado);
            Model.IdGrado = intGrado;
            Model.IdProfesor = intProfesor;
            var result = _repoMateria.AddMateria(Model);
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
