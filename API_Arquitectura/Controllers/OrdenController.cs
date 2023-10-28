using API_Arquitectura.Models;
using API_Arquitectura.Servicios;
using API_Arquitectura.Servicios.Implementacion;
using Microsoft.AspNetCore.Mvc;

namespace API_Arquitectura.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdenController : ControllerBase
    {
        IOrden servicio = new OrdenServicio();
        // Get: api/Orden
        [HttpGet]
        public IList<Orden> Get()
        {
            return servicio.Listar();
        }

        [HttpGet("{Id}", Name = "Get")]
        public Orden Get(int id)
        {
            return servicio.Read(id);
        }

        [HttpPost]
        public void Post([FromBody] Orden objeto)
        {
            servicio.Create(objeto);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Orden value ) 
        {
            servicio.Update(id, value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            servicio.Delete(id);
        }
    }
}
// 1.10min