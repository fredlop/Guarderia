using MatriculaOnline.App.Dominio.Entidades;
using MatriculaOnline.App.Persistencia.AppRepositorios;
using MatriculaOnline.App.Persistencia.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Matriculas.App.WebApp.Pages.Administrativo.GestionDeMatriculas
{
    public class IndexModel : PageModel
    {
        private readonly MatriculasDbContext _db;
        public Matricula Model { get; set; }
        public string NombreABuscar { get; set; }
        private static IRepositorioMatricula _repoMatricula;
        public IEnumerable<Matricula> matriculasList { get; set; }

        public IndexModel(MatriculasDbContext db)
        {
            _db = db;
            _repoMatricula = new RepositorioMatricula(_db);
        }
        public void OnGet()
        {
            matriculasList = new List<Matricula>();
        }

        public IActionResult OnPost(string NombreABuscar)
        {
            if (ModelState.IsValid)
            {
                var result = _repoMatricula.GetMatriculaByEstudianteName(NombreABuscar);
                matriculasList = result;
            }

            return Page();
        }
    }
}
