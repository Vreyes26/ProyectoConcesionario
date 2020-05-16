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
            int menu;
            string recub = "";
            string tipCarb = "";
            string tipMotor = "";

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
                        Console.WriteLine("------Ingresar datos de vehiculo------");
                        Console.Write("Marca: ");
                        string marca = Console.ReadLine();

                        Console.Write("Año: ");
                        int año = int.Parse(Console.ReadLine());

                        Console.Write("Kilometraje: ");
                        int kilometraje = int.Parse(Console.ReadLine());

                        Console.Write("ID Motor: ");
                        int idmotor = int.Parse(Console.ReadLine());

                        Console.Write("Tipo Motor: \n" +
                            "(1): " + TipoMotor.CUATRO_TIEMPOS + 
                            "(2): " + TipoMotor.DOS_TIEMPOS);

                        int opcionMotor = int.Parse(Console.ReadLine());
                        while (opcionMotor <= 3 && opcionMotor >= 1) //tipo Motor
                        {
                            if (opcionMotor == 1)
                            {
                                tipMotor = "CUATRO_TIEMPOS";
                            }
                            else if (opcionMotor == 2)
                            {
                                tipMotor = "DOS_TIEMPOS";
                            }
                            else
                            {
                                Console.WriteLine("----Numero ingresado invalido----");
                                opcionMotor = int.Parse(Console.ReadLine());
                            }
                        }

                        string tipoMotor = tipMotor;

                        Console.Write("Numero de ruedas: ");
                        int numRuedas = int.Parse(Console.ReadLine());

                        Console.Write("Seleccione tipo de recubrimiento:\n" +
                            "(1): " + TipoRecubrimiento.FENOL +"\n"+
                            "(2): " + TipoRecubrimiento.HULE + "\n" +
                            "(3): " + TipoRecubrimiento.POLIUTERANO);

                        int opcionRecubrimiento = int.Parse(Console.ReadLine());

                        while (opcionRecubrimiento <= 3 && opcionRecubrimiento >= 1) //tipo recubrimiento
                        {
                            if (opcionRecubrimiento == 1)
                            {
                                recub = "FENOL";
                            }
                            else if(opcionRecubrimiento == 2)
                            {
                                recub = "HULE";
                            }
                            else if (opcionRecubrimiento == 3)
                            {
                                recub = "POLIUTERANO";
                            }
                            else
                            {
                                Console.WriteLine("----Numero ingresado invalido----");
                                opcionRecubrimiento = int.Parse(Console.ReadLine());
                            }
                        }
                        string tipoRecubrimiento = recub;

                        Console.Write("Minimo durometro: ");
                        int minDurometro = int.Parse(Console.ReadLine());

                        Console.Write("Maximo durometro: ");
                        int maxDurometro = int.Parse(Console.ReadLine());

                        Console.Write("Seleccione tipo de recubrimiento:\n" +
                            "(1): CARBURADOR\n" +
                            "(2): INYECTOR");
                        int opcionMezclador = int.Parse(Console.ReadLine());

                        while (opcionMezclador <= 3 && opcionMezclador >= 1) //tipo mezclador
                        {
                            if (opcionRecubrimiento == 1)
                            {
                                tipCarb = "CARBURADOR";
                            }
                            else if (opcionRecubrimiento == 2)
                            {
                                tipCarb = "INYECTOR";
                            }
                            else
                            {
                                Console.WriteLine("----Numero ingresado invalido----");
                                opcionRecubrimiento = int.Parse(Console.ReadLine());
                            }
                        }

                        string tipoMezclador = tipCarb;

                        Console.Write("Capacidad: ");
                        double capacidad = double.Parse(Console.ReadLine());

                        double litros = double.Parse(Console.ReadLine());

                        Console.WriteLine("-----------Terminar-----------");
                        Automovil automovil = new Automovil(marca, año, kilometraje, idmotor, tipoMotor, numRuedas, 
                                                            tipoRecubrimiento, minDurometro,
                                                            maxDurometro, tipoMezclador, capacidad, litros);
                        
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("----------Ver datos----------\n");

                        
                        Console.ReadKey();
                        break;
                }

            } while (menu != 0);
        }
    }
}
