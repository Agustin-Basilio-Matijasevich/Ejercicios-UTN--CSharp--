using System;
using Librerias_Cesar;

namespace Descifrado
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Variables
            String Frase;
            int Clave;

            //Conseguir una frase Valida
            while (true)
            {
                Console.Clear();
                Console.WriteLine("***Bienvenido al Descifrador Cesar***\n\n");

                Console.WriteLine("Ingrese la frase que desea descifrar y luego presione ENTER.\n");
                Console.Write("Frase: ");
                Frase = Console.ReadLine();

                if (Frase.Length == 0)
                {
                    Console.Write("Usted no ingreso texto, reintente...");
                    Console.ReadKey();
                }
                else
                {
                    break;
                }

            }

            //Conseguir una Clave Valida
            do
            {
                Console.Clear();
                Console.WriteLine("***Bienvenido al Descifrador Cesar***\n\n");

                Console.WriteLine("Ingrese la clave de cifrado y luego presione ENTER.(UN NUMERO ENTERO y POSITIVO)\n");
                Console.Write("Clave: ");

            } while ((!int.TryParse(Console.ReadLine(), out Clave)) || (Clave < 0));

            //Aviso con info sobre el descifrador
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***Aviso***\n\n");
            Console.WriteLine($"La base para el Descifrador es la siguiente:\n\n{Constantes.CaracteresCifrar}\n");
            Console.WriteLine("Su Frase sera convertida a Minuscula (NO KEYSENSITIVE)\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Presione una Tecla para Continuar...");
            Console.ReadKey();

            //Salida del descifrador
            Console.Clear();
            Console.WriteLine("***Bienvenido al Descifrador Cesar***\n\n");

            Console.WriteLine($"Usted Ingreso: {Frase}\n\n");
            Console.WriteLine("Descifrando...\n");
            Frase = Cesar.Descifrar(Frase, Clave);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Frase Descifrada: {Frase}\n\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Fin.\nPresione una Tecla para Continuar...");
            Console.ReadKey();

        }

    }
}
