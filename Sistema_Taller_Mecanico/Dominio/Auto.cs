using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Auto
    {

        public int IdAuto { get; set; }
        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }

        public Cliente  cliente { get; set; }

        // Composición: el auto "tiene" un motor
        public Motor Motor { get; set; } = new Motor();

        // Historial de reparaciones del auto
        public List<Reparacion> Reparaciones { get; set; } = new List<Reparacion>();


    }
}
