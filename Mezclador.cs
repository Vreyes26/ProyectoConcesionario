using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoConcesionario
{
    enum TipoMezclador
    {
        CARBURADOR, INYECTOR
    }

    class Mezclador : VehiculoComponentes
    {
        private TipoMezclador _tipo;

        public Mezclador(TipoMezclador tipo)
        {
            _tipo = tipo;
        }

        public TipoMezclador Tipo
        {
            get => _tipo;
            set => Enum.TryParse(value.ToString(), out _tipo);
        }

        public string mezclador
        {
            get { return _tipo.ToString(); }
            set
            {
                bool resultado = Enum.TryParse(value, out _tipo);
                if (!resultado)
                    Console.WriteLine("Erro al convertir el tipo a un mezclador");

            }
        }
    }
}
