using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace Matriculas.App.WebApp.Pages
{

    [Authorize(Roles = "Administrador,Administrativo")]
    public class AdministracionModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
