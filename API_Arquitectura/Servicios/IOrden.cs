using API_Arquitectura.Models;

namespace API_Arquitectura.Servicios
{
    public interface IOrden
    {
        public void Create(Orden obj);
        public Orden Read(int id);
        public IList<Orden> Listar();
        public void Update(int id, Orden obj);
        public void Delete(int id);
    }
}
