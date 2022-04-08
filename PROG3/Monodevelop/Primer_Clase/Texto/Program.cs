using System;

namespace Texto
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            String Texto;
            ConsoleKeyInfo opcion;
            bool flag = true;

            do
            {
                Console.WriteLine("\n\nIngrese Un texto cualquiera, Se ingresa al presionar ENTER\n\n");
                Texto = Console.ReadLine();
            } while (Texto.Length == 0);

            do
            {
                Console.WriteLine("\n\nSeleccione una opcion.");
                Console.WriteLine("Ingrese A para: Mostrar Texto en Mayusculas");
                Console.WriteLine("Ingrese B para: Mostrar Texto en Minusculas");
                Console.WriteLine("Ingrese C para: Mostrar Texto Original");

                opcion = Console.ReadKey();

                switch (opcion.Key)
                {
                    case ConsoleKey.A:
                        {
                            Console.WriteLine("\n\n" + Texto.ToUpper());

                            flag = false;
                            break;
                        }

                    case ConsoleKey.B:
                        {
                            Console.WriteLine("\n\n" + Texto.ToLower());

                            flag = false;
                            break;
                        }

                    case ConsoleKey.C:
                        {
                            Console.WriteLine("\n\n" + Texto);

                            flag = false;
                            break;
                        }

                    default:
                        {
                            break;
                        }
                }

            } while (flag);

        }
    }
}
