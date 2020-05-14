using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoConcesionario
{
    class Estanque : VehiculoComponentes
    {
        private readonly double _capacidad;
        private double _litros;

        public Estanque(double capacidad)
        {
            _capacidad = capacidad;
        }

        public double Capacidad => _capacidad;

        public bool MitadCombustible()
        {
            return _litros > (0.105 * _capacidad) && _litros <= (0.5 * _capacidad);
        }

        public bool BajoCombustible()
        {
            return _litros <= (0.105 * _capacidad);
        }
    }
}
