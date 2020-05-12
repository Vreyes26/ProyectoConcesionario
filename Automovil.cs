using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoConcesionario
{
    class Automovil : Vehiculo
    {
        public Automovil(int idmotor, TipoMotor tipoMotor, int cilindrada,
            int numRuedas, TipoRecubrimiento tipoRecubrimiento, int minDurometro,
            int maxDurometro, TipoMezclador tipoMezclador, double litros, double capacidad): 
            base(idmotor, tipoMotor, cilindrada, numRuedas, tipoRecubrimiento,
            minDurometro, maxDurometro, tipoMezclador, capacidad)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
