using API_Arquitectura.Models;

namespace API_Arquitectura.Servicios.Implementacion
{
    public class OrdenServicio : IOrden
    {
        static IList<Orden> lista = new List<Orden>();
        public OrdenServicio() 
        {
            if (lista.Count == 0)
            {
                lista.Add(
                    new Orden
                    {
                        Id = 1,
                        plato = "cazuela",
                        descripcion = "sin sal",
                        mesa = 1


                    }
                );
            }
        }

        public void Create(Orden obj)
        {
            lista.Add(obj);
        }

        public void Delete(int id)
        {
            lista.Remove(lista.First(x => x.Id == id));
        }

        public IList<Orden> Listar()
        {
            return lista;
        }

        public Orden Read(int id)
        {
            return lista.FirstOrDefault(x => x.Id == id);
        }

        public void Update(int id, Orden obj)
        {
            obj.Id = id;
            lista.Insert(lista.IndexOf(lista.First(x => x.Id == id)), obj);
        }
    }
}
