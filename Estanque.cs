using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoConcesionario
{
    class Estanque
    {
        public double _capacidad;
        public double _litros;
        public bool _estadoCombustible;

        public void SetCombustible( double _litros, double _capacidad)
        {
            if(_litros > (0.105 * _capacidad) && _litros < (0.5 * _capacidad))
            {
                _estadoCombustible = true; //MITAD_COMBUSTIBLE
            }else if(_litros <= (0.105 * _capacidad))
            {
                _estadoCombustible = false; //BAJO_COMBUSTIBLE
            }
        }

        public bool GetCombustible()
        {
            return _estadoCombustible;
        }
    }
}
