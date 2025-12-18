using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class DetalleMotor
    {

        public int IdDetalleMotor { get; set; }
        public string TrabajoRealizado { get; set; }   // "Cambio de junta", etc.
        public DateTime Fecha { get; set; }
        public decimal CostoManoObra { get; set; }

        // Si en ese trabajo se cambiaron piezas del motor:
        public List<PiezaMotor> PiezasCambiadas { get; set; } = new List<PiezaMotor>();



    }
}
