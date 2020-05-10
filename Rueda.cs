using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoConcesionario
{
    class Rueda : VehiculoComponentes
    {
        enum TipoRecubrimiento
        {
            FENOL, HULE, POLIUTERANO
        }

        public int Durometro(int durometro)
        {
            return durometro;
        }
    }
}
