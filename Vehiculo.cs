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

        public Vehiculo(string marca, int año, int kilometraje, int idMotor, TipoMotor tipoMotor, int cilindrada,
                        int numRuedas, TipoRecubrimiento tipoRecubrimiento,
                        int minDurometro, int maxDurometro, 
                        TipoMezclador tipoMezclador, double capacidad)
        {
            _motor = new Motor(idMotor, tipoMotor, cilindrada);
            _ruedas = new Rueda[numRuedas];
            _estanque = new Estanque(capacidad);
            _mezclador = new Mezclador(tipoMezclador);

            for (int i = 0; i < numRuedas; i++)
            {
                Ruedas[i] = new Rueda(tipoRecubrimiento, minDurometro, maxDurometro);
            }
        }

        internal Motor Motor { get => _motor; set => _motor = value; }
        internal Estanque Estanque { get => _estanque; set => _estanque = value; }
        internal Rueda[] Ruedas { get => _ruedas; set => _ruedas = value; }
        internal Mezclador Mezclador { get => _mezclador; set => _mezclador = value; }
    }
}
