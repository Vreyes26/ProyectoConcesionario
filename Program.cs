using System;
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
            Automovil automovil = new Automovil();


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
                        Console.WriteLine("------Ingresar datos de vehiculo------\n");
                        Console.Write("Marca: ");
                        automovil.Marca = Console.ReadLine();
                        Console.Write("Año del vehiculo: ");
                        automovil.Año = int.Parse(Console.ReadLine());
                        Console.Write("Kilometraje: ");
                        automovil.Kilometraje = int.Parse(Console.ReadLine());

                        Console.Write("Capacidad de combustible: ");
                        _capacidad = double.Parse(Console.ReadLine());

                        Console.Write("Combustible actual del vehiculo: ");
                        _litros = double.Parse(Console.ReadLine());

                        estanque.SetCombustible(_litros, _capacidad);

                        Console.WriteLine("-----------Terminar-----------");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("----------Ver datos----------\n");

                        Console.WriteLine("Marca: " + automovil.Marca);
                        Console.WriteLine("Año: " + automovil.Año);
                        Console.WriteLine("Kilometraje: " + automovil.Kilometraje);
                        bool Litros = estanque.GetCombustible();
                        if (Litros == true)
                        {
                            Console.WriteLine("Mitad de combustible");
                        }
                        else if (Litros == false)
                        {
                            Console.WriteLine("Bajo combustible");
                        }

                        Console.ReadKey();
                        break;
                }

            } while (menu != 0);
        }
    }
}
