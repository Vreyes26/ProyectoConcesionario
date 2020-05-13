using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoConcesionario
{
    enum TipoMotor
    {
        DOS_TIEMPOS, CUATRO_TIEMPOS
    }

    class Motor : VehiculoComponentes
    {
        private readonly int _id;
        private readonly TipoMotor _tipo;
        private double _cilindrada;
   
        public Motor(int id, TipoMotor tipo, double cilindrada)
        {
            _id = id;
            _tipo = tipo;
            _cilindrada = cilindrada;
        }

        public int ID => _id;

        public TipoMotor tipo 

        public double Cilindrada
        {
            get => _cilindrada;
            set => double.TryParse(value.ToString(), out _cilindrada);
        }

    }
}
