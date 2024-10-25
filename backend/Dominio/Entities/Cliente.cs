﻿namespace Dominio.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public ICollection<Direccion> Direcciones { get; set; }
    }
}
