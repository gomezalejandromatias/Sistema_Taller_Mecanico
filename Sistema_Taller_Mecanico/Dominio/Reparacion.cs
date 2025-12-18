using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Reparacion
    {


        public int IdReparacion { get; set; }
        public int IdAuto { get; set; }

        public DateTime FechaIngreso { get; set; }
        public DateTime? FechaEgreso { get; set; }

        public string Descripcion { get; set; }     // "No arranca", "Hace ruido", etc.
        public string Estado { get; set; }          // Pendiente / En proceso / Terminado

        public decimal ManoDeObra { get; set; }
        public decimal PrecioFinal { get; set; }

        // Lo que se usó de stock en esta reparación
        public List<RepuestoUsado> RepuestosUsados { get; set; } = new List<RepuestoUsado>();

        // Trabajos específicos del motor (si aplica)
        public List<DetalleMotor> TrabajosMotor { get; set; } = new List<DetalleMotor>();



    }
}
