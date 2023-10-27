using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Arquitectura.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ValuesController : ControllerBase
    {
        public static Connection_Mysql connectio = new Connection_Mysql();

        // GET: api/<ValuesController>
        [HttpGet]
        public string Getpersona()
        {
            string Queryable = "select * from Persona";




            return "";
        }

    }
}
