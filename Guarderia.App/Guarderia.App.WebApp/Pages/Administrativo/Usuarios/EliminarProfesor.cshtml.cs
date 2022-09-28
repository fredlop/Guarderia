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
    public class EliminarProfesorModel : PageModel
    {
        private readonly MatriculasDbContext _db;
        private static IRepositorioProfesor _repoProfesor;
        //Linkea la entidad con el html
        [BindProperty]
        public Profesor dataProfesor { get; set; }

        public EliminarProfesorModel(MatriculasDbContext db)
        {
            _db = db;
            _repoProfesor = new RepositorioProfesor(_db);
        }

        public void OnGet(int id)
        {
            dataProfesor = _repoProfesor.GetProfesor(id);
        }

        public IActionResult OnPostDelete(string returnUrl = null)
        {
            bool result = _repoProfesor.DeleteProfesor(dataProfesor.IdProfesor);
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
