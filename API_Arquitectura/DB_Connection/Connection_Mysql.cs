using System.Data;
using MySql.Data.MySqlClient;

namespace api_proyecto_web.DBConText
{
    public class Connection
    {
        private string connection_str = string.Empty;

        static string Servidor = "127.0.0.1:3306";
        static string DB = "my_database";
        static string Usuario = "my_user";
        static string Contrasena = "my_password";
        static string Puerto = "3306";

        string Coneccionstring = "server=" + Servidor + ";" + "port=" + Puerto + ";" + "user id=" + Usuario + ";" + "password=" + Contrasena + ";" + "database=" + DB + ";";



        public DataTable Execute(string SQL)
        {
            using (MySqlConnection con = new MySqlConnection(Coneccionstring))
            {
                using (MySqlCommand cmd = con.CreateCommand())
                {
                    try
                    {

                        con.Open();
                        cmd.CommandText = SQL;
                        MySqlDataReader dr = cmd.ExecuteReader();
                        var dt = new DataTable();
                        dt.Load(dr);
                        con.Close();
                        Console.WriteLine("Select ejecutado");
                        return dt;

                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("No se vinculo la con la base de datos uwu");
                    }
                    return new DataTable();
                }
            }
        }






    }


}