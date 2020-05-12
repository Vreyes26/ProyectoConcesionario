using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ProyectoConcesionario
{
    abstract class Vehiculo
    {
        private Motor _motor;
        private Rueda[] _ruedas;
        private Estanque _estanque;
        private Mezclador _mezclador;

        public Vehiculo(int idMotor, TipoMotor tipoMotor, int cilindrada,
                        int numRuedas, TipoRecubrimiento tipoRecubrimiento, int minDurometro, int maxDurometro, 
                        TipoMezclador tipoMezclador, double litros, double capacidad)
        {
            _motor = new Motor(idMotor, tipoMotor, cilindrada);
            _ruedas = new Rueda[numRuedas];
            for (int i = 0; i < numRuedas; i++)
            {
                Ruedas[i] = new Rueda(tipoRecubrimiento, minDurometro, maxDurometro);
            }

            _estanque = new Estanque(capacidad);
            _mezclador = new Mezclador(tipoMezclador);
        }
        


    }
}
