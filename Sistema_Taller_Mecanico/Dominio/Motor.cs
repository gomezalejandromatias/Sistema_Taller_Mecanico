using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Motor
    {


        public int IdMotor { get; set; }
        public string Tipo { get; set; }          // nafta / diesel / etc
        public string CodigoMotor { get; set; }   // si querés
        public int Cilindrada { get; set; }       // ej 1600
        public string Observaciones { get; set; }

        // Piezas del motor (catálogo o info)
        public List<PiezaMotor> Piezas { get; set; } = new List<PiezaMotor>();



    }
}
