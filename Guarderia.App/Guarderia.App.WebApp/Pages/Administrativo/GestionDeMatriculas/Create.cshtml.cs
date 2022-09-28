using MatriculaOnline.App.Dominio.Entidades;
using MatriculaOnline.App.Persistencia.AppRepositorios;
using MatriculaOnline.App.Persistencia.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Matriculas.App.WebApp.Pages.Administrativo.GestionDeMatriculas
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Matricula Model { get; set; }
        private readonly MatriculasDbContext _db;
        public IEnumerable<Estudiante> Estudiantes { get; set; }
        public IEnumerable<Year> Years { get; set; }

        private static IRepositorioMatricula _repoMatricula;
        public IEnumerable<Grado> Grados { get; set; }

        public CreateModel(MatriculasDbContext db)
        {
            _db = db;
            _repoMatricula = new RepositorioMatricula(_db);
        }
        public async Task OnGet()
        {
            Estudiantes = await _db.Estudiantes.ToListAsync();
            Years = await _db.Years.ToListAsync();
            Grados = await _db.Grados.ToListAsync();
            
        }


        public IActionResult OnPost()
        {
            var estudiante = Request.Form["estudiante"];
            var year = Request.Form["year"];
            var grado = Request.Form["grado"];
            int intEstudiante = int.Parse(estudiante);
            int intYear = int.Parse(year);
            int intGrado = int.Parse(grado);

            Model.IdGrado = intGrado;
            Model.IdEstudiante = intEstudiante;
            Model.IdYear = intYear;

            var result = _repoMatricula.AddMatricula(Model);
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
