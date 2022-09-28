using MatriculaOnline.App.Dominio.Entidades;
using MatriculaOnline.App.Persistencia.AppRepositorios;
using MatriculaOnline.App.Persistencia.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
using System.Threading.Tasks;

namespace Matriculas.App.WebApp.Pages.Administrativo.Grados
{
    [Authorize(Roles = "Administrador,Administrativo")]
    public class DeleteModel : PageModel
    {
        private readonly MatriculasDbContext _db;
        private static IRepositorioGrado _repoGrado;
        [BindProperty]
        public Grado Model { get; set; }

        public DeleteModel(MatriculasDbContext db)
        {
            _db = db;
            _repoGrado = new RepositorioGrado(_db);
        }
        public void OnGet(int id)
        {
            Model = _repoGrado.GetGrado(id);
        }

        public IActionResult OnPostDelete(string returnUrl = null)
        {
            bool result = _repoGrado.DeleteGrado(Model.IdGrado);
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
