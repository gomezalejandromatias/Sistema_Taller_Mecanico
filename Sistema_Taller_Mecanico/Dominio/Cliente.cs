using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        // Un cliente puede tener varios autos
        public List<Auto> Autos { get; set; } = new List<Auto>();




    }
}
