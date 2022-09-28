using MatriculaOnline.App.Dominio.Entidades;
using MatriculaOnline.App.Persistencia.AppRepositorios;
using MatriculaOnline.App.Persistencia.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace Matriculas.App.WebApp.Pages.Administrativo.Usuarios
{
    [Authorize(Roles = "Administrador,Administrativo")]


    public class EliminarEstudianteModel : PageModel
    {
        private readonly MatriculasDbContext _db;
        private static IRepositorioEstudiante _repoEstudiante;

        //Linkea la entidad con el html
        [BindProperty]
        public Estudiante dataEstudiante { get; set; }

        public EliminarEstudianteModel(MatriculasDbContext db)
        {
            _db = db;
            _repoEstudiante = new RepositorioEstudiante(_db);
        }

        public void OnGet(int id)
        {
            dataEstudiante = _repoEstudiante.GetEstudiante(id);
        }

        public IActionResult OnPostDelete(string returnUrl = null)
        {
            bool result = _repoEstudiante.DeleteEstudiante(dataEstudiante.IdEstudiante);
            if (result == true)
            {
                return RedirectToPage("Index");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Ocurrio un error al eliminar un registro");
            }
            return Page();
        }

        public IActionResult OnPostNoDelete(string returnUrl = null)
        {
            return RedirectToPage("Index");
        }

    }
}
