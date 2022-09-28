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
    public class EditarEstudianteModel : PageModel
    {
        private readonly MatriculasDbContext _db;
        private static IRepositorioEstudiante _repoEstudiante;

        //Linkea la entidad con el html
        [BindProperty]
        public Estudiante dataEstudiante { get; set; }

        public IEnumerable<Genero> Generos { get; set; }
        public IEnumerable<TiposIdentificacion> TiposDeIdentificacion { get; set; }

        public UserManager<IdentityUser> userManager;

        public string Email { get; set; }

        public EditarEstudianteModel(UserManager<IdentityUser> userManager, MatriculasDbContext db)
        {
            _db = db;
            _repoEstudiante = new RepositorioEstudiante(_db);
            this.userManager = userManager;
        }
        public async Task OnGet(int id)
        {
            Generos = await _db.Generos.ToListAsync();
            TiposDeIdentificacion = await _db.TiposDeIdentificacion.ToListAsync();
            dataEstudiante = _repoEstudiante.GetEstudiante(id);
            var user = await userManager.FindByIdAsync(dataEstudiante.IdUsuario);
            Email = user.Email;
        }

        public IActionResult OnPost()
        {

            var tipoDocumento = Request.Form["tipoid"];
            var genero = Request.Form["genero"];
            int intGenero = int.Parse(genero);
            int intTipoDocumento = int.Parse(tipoDocumento);

            var newEstudiante = new Estudiante()
            {
                IdEstudiante = dataEstudiante.IdEstudiante,
                Nombre = dataEstudiante.Nombre,
                Apellido = dataEstudiante.Apellido,
                NumeroDeIdentificacion = dataEstudiante.NumeroDeIdentificacion,
                Codigo = dataEstudiante.Codigo,
                IdGenero = intGenero,
                IdTipoIdeIdentificacion = intTipoDocumento               
            };

            var result = _repoEstudiante.UpdateEstudiante(newEstudiante);
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
