using api_proyecto_web.DBConText;
using System.Data;

namespace API_Arquitectura.Models
{
    public class ModelDataService
    {
        public static Connection connection = new Connection();


        public string getnombre()
        {
            string query = "select * from Persona";

            DataTable dt = connection.Execute(query);

            dt.Rows

            return "";
        }

    }
}
