using MatriculaOnline.App.Dominio.Entidades;
using MatriculaOnline.App.Persistencia.AppRepositorios;
using MatriculaOnline.App.Persistencia.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Matriculas.App.WebApp.Pages.Profesores
{
    [Authorize(Roles = "Profesor")]
    public class IndexModel : PageModel
    {
        private readonly MatriculasDbContext _db;
        public Profesor Model { get; set; }
        public IEnumerable<Grado> Grados { get; set; }
        public string Email { get; set; }
        private static IRepositorioProfesor _repoProfesor;
        public UserManager<IdentityUser> userManager;
        public IndexModel(UserManager<IdentityUser> userManager, MatriculasDbContext db)
        {
            _db = db;
            _repoProfesor = new RepositorioProfesor(_db);
            this.userManager = userManager;
        }
        public async Task OnGet()
        {
            var usr = await userManager.GetUserAsync(User);
            Grados = await _db.Grados.ToListAsync();            
            Email = usr.Email;
            Model = _repoProfesor.GetProfesorByIdUsuario(usr.Id);
        }
    }
}
