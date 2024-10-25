namespace Dominio.Entities
{
    public class Direccion
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public string Provincia { get; set; }
        public string Casa { get; set; }
        public Cliente Cliente { get; set; }
    }
}
