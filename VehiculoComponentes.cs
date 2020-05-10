using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ProyectoConcesionario
{
    abstract class VehiculoComponentes
    {
        private int _estadoComponentes;

        public int EstadoComponentes
        {
            get { return _estadoComponentes; }
            set { _estadoComponentes = value; }
        }
    }
}
