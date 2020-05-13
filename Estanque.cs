using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoConcesionario
{
    class Estanque
    {
        public double _capacidad;
        public double _litros;

        public Estanque(double capacidad)
        {
            _capacidad = capacidad;
        }

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
