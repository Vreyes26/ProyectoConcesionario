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

            do
            {
                Console.WriteLine("Usuario: ");
                user = Console.ReadLine();
                Console.WriteLine("Contraseña: ");
                password = Console.ReadLine();

                if (user != "admin" && password != "abc123")
                {
                    Console.WriteLine("Error, usuario o contraseña incorrecto");
                }
            } while (user != "admin" && password != "abc123");

            do
            {
                Console.WriteLine("Ingrese: \n" +
                    "1: Agregar vehiculo \n" +
                    "2: Ver datos vehiculo\n" +
                    "0: Salir");
                menu = int.Parse(Console.ReadLine());

            } while (menu != 0);
        }
    }
}
