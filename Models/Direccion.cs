namespace WebAPIPersona.Models
{
    public class Direccion
    {
        public int ID { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public required int IdPersona { get; set; }

    }
}
