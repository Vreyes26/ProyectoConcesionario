using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoConcesionario
{
    class Estanque : VehiculoComponentes
    {
        private readonly double _capacidad;
        private readonly double _litros;

        public double Capacidad => _capacidad;
        public double Litros => _litros;

        public Estanque(double capacidad, double litros)
        {
            this._litros = litros;
            this._capacidad = capacidad;
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
