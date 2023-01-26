using SistemaPosts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SistemaPosts.Pages
{
    public class NuevoModel : PageModel

    {
        public ListadoPosts listado = new ListadoPosts();

        public NuevoModel(ListadoPosts lista)
        {
            listado = lista;
        }

       
        public void OnGet()
        {
        }

        public void OnPost()
        {
            listado.agregarPost(new Post()
            {

                
                titulo = Request.Form["titulo"],
                contenido = Request.Form["contenido"],
                usuario = Request.Form["usuario"]

            });

            Response.Redirect("/");
        }
    }
}
