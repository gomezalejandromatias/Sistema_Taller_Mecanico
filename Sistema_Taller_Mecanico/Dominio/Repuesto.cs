using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Repuesto
    {
        public int IdRepuesto { get; set; }
        public string Nombre { get; set; }        // filtro aceite, pastillas freno, etc.
        public string Marca { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public bool Eliminado { get; set; }


    }
}
