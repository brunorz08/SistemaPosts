using System.Security.Cryptography.X509Certificates;
using SistemaPosts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SistemaPosts.Pages
{
    public class BorrarModel : PageModel
    {

        ListadoPosts listado = new ListadoPosts();

        public BorrarModel(ListadoPosts lista)
        {
            listado = lista;
        }
        public void OnGet()
        {

            

            listado.borrarPost(Convert.ToInt32(Request.Query["id"]));
            Response.Redirect("/"); ;
        }
    }
}
