using MatriculaOnline.App.Dominio.Entidades;
using MatriculaOnline.App.Persistencia.AppRepositorios;
using MatriculaOnline.App.Persistencia.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Matriculas.App.WebApp.Pages.Administrativo.Materias
{
    [Authorize(Roles = "Administrador,Administrativo")]
    public class IndexModel : PageModel
    { 

        private readonly MatriculasDbContext _db;
        public Materia Model { get; set; }
        public IEnumerable<Grado> Grados { get; set; }
        public IEnumerable<Profesor> Profesores { get; set; }
        public IEnumerable<Materia> Materias { get; set; }

        public IndexModel(MatriculasDbContext db)
        {
            _db = db;
        }
        public async Task OnGet()
        {
            Grados = await _db.Grados.ToListAsync();
            Profesores = await _db.Profesores.ToListAsync();
            Materias = await _db.Materias.ToListAsync();
        }
    }
}
