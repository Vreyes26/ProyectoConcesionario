using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoConcesionario
{
    class Estanque
    {
        public double _capacidad;
        public double _litros;
        public bool _estado;

        public void MitadCombustible(double _litros, double _capacidad)
        {
            if(_litros > (0.105 * _capacidad) && _litros < (0.5 * _capacidad))
            {
                Console.WriteLine("Mitad de combustible");
            }else if(_litros <= (0.105 * _capacidad))
            {
                Console.WriteLine("Bajo combustible");
            }
        }

        public double Capacidad { get => _capacidad; set => _capacidad = value; }
        public double Litros { get => _litros; set => _litros = value; }
        public bool Estado { get => _estado; set => _estado = value; }
    }
}
