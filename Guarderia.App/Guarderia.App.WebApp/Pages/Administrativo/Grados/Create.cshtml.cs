using MatriculaOnline.App.Dominio.Entidades;
using MatriculaOnline.App.Persistencia.AppRepositorios;
using MatriculaOnline.App.Persistencia.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace Matriculas.App.WebApp.Pages.Administrativo.Grados
{
    [Authorize(Roles = "Administrador,Administrativo")]
    public class CreateModel : PageModel
    {
        private readonly MatriculasDbContext _db;
        private static IRepositorioGrado _repoGrado;
        [BindProperty]
        public Grado Model { get; set; }

        public CreateModel(MatriculasDbContext db)
        {
            _db = db;
            _repoGrado = new RepositorioGrado(_db);
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            var result = _repoGrado.AddGrado(Model);
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
