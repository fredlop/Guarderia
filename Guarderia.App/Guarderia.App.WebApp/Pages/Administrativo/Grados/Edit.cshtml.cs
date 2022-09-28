using MatriculaOnline.App.Dominio.Entidades;
using MatriculaOnline.App.Persistencia.AppRepositorios;
using MatriculaOnline.App.Persistencia.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Matriculas.App.WebApp.Pages.Administrativo.Grados
{
    [Authorize(Roles = "Administrador,Administrativo")]
    public class EditModel : PageModel
    {
        private readonly MatriculasDbContext _db;
        private static IRepositorioGrado _repoGrado;
        [BindProperty]
        public Grado Model { get; set; }

        public EditModel(MatriculasDbContext db)
        {
            _db = db;
            _repoGrado = new RepositorioGrado(_db);
        }
        public void OnGet(int id)
        {
            Model = _repoGrado.GetGrado(id);
        }

        public IActionResult OnPost()
        {
            var result = _repoGrado.UpdateGrado(Model);
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
