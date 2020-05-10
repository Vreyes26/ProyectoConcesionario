using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoConcesionario
{
    public class Automovil : Vehiculo
    {
        private string _marca;
        private int _año;
        private int _kilometraje;

        public string Marca { get => _marca; set => _marca = value; }
        public int Año { get => _año; set => _año = value; }
        public int Kilometraje { get => _kilometraje; set => _kilometraje = value; }
    }
}
