namespace SistemaPosts.Models
{
    public class ListadoPosts
    {
        public List<Post> lista = new List<Post>()
        {
            new Post()
            {
                
                titulo = "Inca y Dash",
                contenido = "Inca y Dash son los perros de Bruno.",
                usuario = "Bruno"
            }
        };

        public List<Post> obtenerTodos()
        {
            return lista;
        }

        public Post obtenerUno(int id)
        {
            return lista[id];
        }
        public void agregarPost(Post post)
        {

            lista.Add(post);
            Refresh();
        }

        public void borrarPost(int id)
        {
            Post postaborrar = lista[id];
            lista.Remove(postaborrar);
            Refresh();

        }

        public void Refresh()
        {
            foreach(var item in lista)
            {
               
                item.id = lista.IndexOf(item);
            }
        }
    }
}
