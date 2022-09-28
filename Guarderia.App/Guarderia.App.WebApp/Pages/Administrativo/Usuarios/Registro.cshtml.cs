using MatriculaOnline.App.Dominio.Entidades;
using MatriculaOnline.App.Persistencia.AppRepositorios;
using MatriculaOnline.App.Persistencia.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Matriculas.App.WebApp.Pages.Administrativo.Usuarios
{
    [Authorize(Roles = "Administrador,Administrativo")]
    public class RegistroModel : PageModel
    {
        [BindProperty]
        public Registro Model { get; set; }
        private readonly MatriculasDbContext _db;

        public UserManager<IdentityUser> userManager;
        public SignInManager<IdentityUser> signInManager;
        public RoleManager<IdentityRole> roleManager;

        private static IRepositorioEstudiante _repoEstudiante;
        private static IRepositorioProfesor _repoProfesor;
        public IEnumerable<IdentityRole> allRoles { get; set; }
        public IEnumerable<TiposIdentificacion> TiposIdentificacion { get; set; }
        public IEnumerable<Genero> Generos { get; set; }

        public RegistroModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager, MatriculasDbContext db)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            _db = db;
            _repoEstudiante = new RepositorioEstudiante(_db);
            _repoProfesor = new RepositorioProfesor(_db);
        }

        public async Task OnGet()
        {
            allRoles = await roleManager.Roles.ToListAsync();
            TiposIdentificacion = await _db.TiposDeIdentificacion.ToListAsync();
            Generos = await _db.Generos.ToListAsync();
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser()
                {
                    UserName = Model.Email,
                    Email = Model.Email,
                };

                string rolCurrentUser = Request.Form["rol"];
                var genero = Request.Form["genero"];
                var tipoDocumento = Request.Form["tiposidentificacion"];
                int intGenero = int.Parse(genero);
                int intTipoDocumento = int.Parse(tipoDocumento);

                var result = await userManager.CreateAsync(user, Model.Password);

                if (result.Succeeded)
                {
                    var roleResult = await userManager.AddToRoleAsync(user, rolCurrentUser);
                    if (roleResult.Succeeded)
                    {
                        //await signInManager.SignInAsync(user, false);

                        if (rolCurrentUser == "Estudiante")
                        {
                            var estudiante = new Estudiante
                            {
                                Nombre = Model.Nombre,
                                Apellido = Model.Apellido,
                                IdTipoIdeIdentificacion = intTipoDocumento,
                                NumeroDeIdentificacion = Model.NumeroDeIdentificacion,
                                IdGenero = intGenero,
                                Codigo = Model.Codigo,
                                IdUsuario = user.Id,
                            };

                            var resultEstudiante = _repoEstudiante.AddEstudiante(estudiante);
                        }


                        if (rolCurrentUser == "Profesor")
                        {
                            var profesor = new Profesor
                            {
                                Nombre = Model.Nombre,
                                Apellido = Model.Apellido,
                                IdTipoIdeIdentificacion = intTipoDocumento,
                                NumeroDeIdentificacion = Model.NumeroDeIdentificacion,
                                IdGenero = intGenero,
                                IdUsuario = user.Id,
                            };

                            var resultProfesor = _repoProfesor.AddProfesor(profesor);
                        }

                        return RedirectToPage("Index");
                    }
                    else
                    {
                        foreach (var error in roleResult.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                    }

                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }

            return Page();
        }
    }
}
