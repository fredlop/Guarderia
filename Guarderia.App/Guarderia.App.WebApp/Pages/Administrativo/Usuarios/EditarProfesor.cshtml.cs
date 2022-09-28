using MatriculaOnline.App.Dominio.Entidades;
using MatriculaOnline.App.Persistencia.AppRepositorios;
using MatriculaOnline.App.Persistencia.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Matriculas.App.WebApp.Pages.Administrativo.Usuarios
{
    public class EditarProfesorModel : PageModel
    {
        private readonly MatriculasDbContext _db;
        private static IRepositorioProfesor _repoProfesor;

        //Linkea la entidad con el html
        [BindProperty]
        public Profesor dataProfesor { get; set; }

        public IEnumerable<Genero> Generos { get; set; }
        public IEnumerable<TiposIdentificacion> TiposDeIdentificacion { get; set; }

        public UserManager<IdentityUser> userManager;

        public string Email { get; set; }

        public EditarProfesorModel(UserManager<IdentityUser> userManager, MatriculasDbContext db)
        {
            _db = db;
            _repoProfesor = new RepositorioProfesor(_db);
            this.userManager = userManager;
        }
        public async Task OnGet(int id)
        {
            Generos = await _db.Generos.ToListAsync();
            TiposDeIdentificacion = await _db.TiposDeIdentificacion.ToListAsync();
            dataProfesor = _repoProfesor.GetProfesor(id);
            var user = await userManager.FindByIdAsync(dataProfesor.IdUsuario);
            Email = user.Email;
        }


        public IActionResult OnPost()
        {

            var tipoDocumento = Request.Form["tipoid"];
            var genero  = Request.Form["genero"];
            int intGenero = int.Parse(genero);
            int intTipoDocumento = int.Parse(tipoDocumento);

            var newProfesor = new Profesor()
            {
                IdProfesor = dataProfesor.IdProfesor,
                Nombre = dataProfesor.Nombre,
                Apellido = dataProfesor.Apellido,
                NumeroDeIdentificacion = dataProfesor.NumeroDeIdentificacion,
                IdGenero = intGenero,
                IdTipoIdeIdentificacion = intTipoDocumento
            };

            var result = _repoProfesor.UpdateProfesor(newProfesor);
            if (result != null)
            {
                return RedirectToPage("Index");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Ocurrio un error al actualizar un registro");
            }

            return Page();

        }
    }
}
