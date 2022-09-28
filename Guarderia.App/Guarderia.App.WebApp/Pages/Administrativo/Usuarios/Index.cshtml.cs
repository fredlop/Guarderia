using MatriculaOnline.App.Dominio.Entidades;
using MatriculaOnline.App.Persistencia.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Matriculas.App.WebApp.Pages.Administrativo.Usuarios
{
    [Authorize(Roles = "Administrador,Administrativo")]
    public class IndexModel : PageModel
    {
        private readonly MatriculasDbContext _db;
        public Registro Model { get; set; }

        public IEnumerable<Estudiante> Estudiantes { get; set; }

        public IEnumerable<Profesor> Profesores { get; set; } 

        public IndexModel(MatriculasDbContext db)
        {
            _db = db;
        }
        public async Task OnGet()
        {
            Estudiantes = await _db.Estudiantes.Include("Genero").Include("TiposIdentificacion").ToListAsync();
            Profesores = await _db.Profesores.Include("Genero").Include("TiposIdentificacion").ToListAsync();
        }
    }
}
