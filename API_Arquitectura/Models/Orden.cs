namespace API_Arquitectura.Models
{
    public class Orden
    {
        public int Id { get; set; }
        public string plato { get; set; }
        public string descripcion{ get; set; }
        public int mesa { get; set; }
        public Estado estado { get; set; }

        public Orden()
        {
            this.Id = new int();
            plato = string.Empty;
            descripcion = string.Empty;
            this.mesa = new int();
            this.estado = Estado.Creado;
        }
    }


}
