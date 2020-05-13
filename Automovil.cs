using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoConcesionario
{
    class Automovil : Vehiculo
    {

        private string _marca;
        private int _año;
        private int _kilometraje;

        public string Marca => _marca;

        public int Año => _año;

        public int Kilometraje => _kilometraje;

        public Automovil(string marca, int año, int kilometraje, int idmotor, TipoMotor tipoMotor, int cilindrada,
            int numRuedas, TipoRecubrimiento tipoRecubrimiento, int minDurometro,
            int maxDurometro, TipoMezclador tipoMezclador, double capacidad): 
            base(idmotor, tipoMotor, cilindrada, numRuedas, tipoRecubrimiento,
            minDurometro, maxDurometro, tipoMezclador, capacidad)
        {
            _marca = marca;
            _año = año;
            _kilometraje = kilometraje;
        }
    }
}
