using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class RepuestoUsado
    {

        public int IdRepuestoUsado { get; set; }

        public int IdRepuesto { get; set; }
        public Repuesto Repuesto { get; set; }    // referencia al repuesto original

        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }


    }
}
