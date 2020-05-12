using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ProyectoConcesionario
{
    abstract class VehiculoComponentes
    {
        private double _estadoComponentes;

        public double EstadoComponentes
        {
            get => _estadoComponentes;
            set => double.TryParse(value.ToString(), out _estadoComponentes);
        }

        protected VehiculoComponentes()
        {
            _estadoComponentes = 0.0;
        }
    }
}
