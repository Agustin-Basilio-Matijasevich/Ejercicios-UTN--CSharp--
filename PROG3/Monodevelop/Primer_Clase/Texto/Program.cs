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
                Console.WriteLine("Ingrese a para: Mostrar Texto en Mayusculas");
                Console.WriteLine("Ingrese b para: Mostrar Texto en Minusculas");
                Console.WriteLine("Ingrese c para: Mostrar Texto Original");

                opcion = Console.ReadKey();

                switch (opcion.Key)
                {
                    case ConsoleKey.A:
                        {
                            Console.WriteLine(Texto.ToUpper());

                            flag = false;
                            break;
                        }

                    case ConsoleKey.B:
                        {
                            Console.WriteLine(Texto.ToLower());

                            flag = false;
                            break;
                        }

                    case ConsoleKey.C:
                        {
                            Console.WriteLine(Texto);

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
