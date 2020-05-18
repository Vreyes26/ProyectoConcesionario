using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoConcesionario
{
    enum TipoRecubrimiento
    {
        FENOL, HULE, POLIUTERANO
    }

    class Rueda : VehiculoComponentes
    {
        private TipoRecubrimiento _tipo;
        private readonly int[] _durometro;

        public Rueda(TipoRecubrimiento tipo, int minDurometro, int maxDurometro)
        {
            _tipo = tipo;
            _durometro = new int[] { minDurometro, maxDurometro };
        }

        public TipoRecubrimiento Tipo
        {
            get => _tipo;
            set => Enum.TryParse(value.ToString(), out _tipo);
        }

        public int[] Durometro1 => _durometro;
    }
}
