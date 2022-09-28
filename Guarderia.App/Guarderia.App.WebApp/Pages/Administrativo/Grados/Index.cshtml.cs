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

namespace Matriculas.App.WebApp.Pages.Administrativo.Grados
{
    [Authorize(Roles = "Administrador,Administrativo")]
    public class GradoModel : PageModel
    {
        private readonly MatriculasDbContext _db;
        private static IRepositorioGrado _repoGrado;
        public Registro Model { get; set; }
        public IEnumerable<Grado> Grados { get; set; }

        public GradoModel(MatriculasDbContext db)
        {
            _db = db;
            _repoGrado = new RepositorioGrado(_db);
        }
        public async Task OnGet()
        {
            Grados = await _db.Grados.ToListAsync();

        }
    }
}
