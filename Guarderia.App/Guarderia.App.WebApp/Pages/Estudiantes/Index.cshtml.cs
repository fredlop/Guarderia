using MatriculaOnline.App.Dominio.Entidades;
using MatriculaOnline.App.Persistencia.AppRepositorios;
using MatriculaOnline.App.Persistencia.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Threading.Tasks;

namespace Matriculas.App.WebApp.Pages.Estudiantes
{
    [Authorize(Roles = "Estudiante")]
    public class IndexModel : PageModel
    {
        public Estudiante Model { get; set; }
        public string Email { get; set; }
        private readonly MatriculasDbContext _db;
        public UserManager<IdentityUser> userManager;
        private static IRepositorioEstudiante _repoEstudiante;
        public IndexModel(UserManager<IdentityUser> userManager, MatriculasDbContext db)
        {
            _db = db;
            _repoEstudiante = new RepositorioEstudiante(_db);
            this.userManager = userManager;
        }
        public async Task OnGet()
        {
            var usr = await userManager.GetUserAsync(User);
            Email = usr.Email;
            Model = _repoEstudiante.GetEstudianteByIdUsuario(usr.Id);
        }
    }
}
