﻿using System;
using System.ComponentModel.Design;

namespace ProyectoConcesionario
{
    class Program
    {
        static void Main(string[] args)
        {
            string user;
            string password;
            int menu = 0;
            double _litros;
            double _capacidad;

            do
            {
                Console.Write("Usuario: ");
                user = Console.ReadLine();
                Console.Write("Contraseña: ");
                password = Console.ReadLine();

                if (user != "admin" || password != "abc123")
                {
                    Console.Clear();
                    Console.WriteLine("Usuario o contraseña incorrectos\n");
                }
            } while (user != "admin" || password != "abc123");

            //COSNTRUCTORES
            Estanque estanque = new Estanque();

            do
            {
                Console.Clear();
                Console.WriteLine("----------BIENVENIDO----------\n");
                Console.WriteLine("Ingrese: \n" +
                    "1: Agregar vehiculo \n" +
                    "2: Ver datos vehiculo\n" +
                    "0: Salir");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ingresar datos de vehiculo");
                        _litros = double.Parse(Console.ReadLine());
                        _capacidad = double.Parse(Console.ReadLine());
                        estanque.MitadCombustible(_litros, _capacidad);
                        
                        break;

                    case 2:
                        Console.WriteLine("Ver datos");
                        break;
                }

            } while (menu != 0);
        }
    }
}
