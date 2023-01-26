using System.Reflection;
using SistemaPosts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SistemaPosts.Pages
{
    public class IndexModel : PageModel
    {

        public ListadoPosts lista = new ListadoPosts();


        public IndexModel(ListadoPosts list)
        {
            lista = list;

        }

        public void OnGet()
        {
            
        }
    }
}
