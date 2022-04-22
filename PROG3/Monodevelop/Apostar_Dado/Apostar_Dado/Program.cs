using System;
using Apostar_Dado.Tools;

namespace Apostar_Dado
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool Princ = true;

            do
            {
                int Num = 0, Dado;
                bool Band1, Band2;

                Console.WriteLine("Apueste un numero entre el 1 y el 6");

                do
                {
                    Band1 = int.TryParse(Console.ReadLine(), out Num);

                    if (Num > 0 && Num < 7)
                    {
                        Band2 = true;
                    }
                    else
                    {
                        Band2 = false;
                    }

                    if (Band1 == false || Band2 == false)
                    {
                        Console.WriteLine("Caracter Invalido, Reintente");
                    }

                } while (Band1 == false || Band2 == false);

                Dado = Tools.Dado.NumAleatorio();

                Console.WriteLine($"Usted Ingreso: {Num}.\nEl Dado salio: {Dado}.");

                if (Dado == Num)
                {
                    Console.WriteLine("Usted Gano!!");
                }
                else
                {
                    Console.WriteLine("Usted Perdio!!");
                }

                Console.WriteLine("\n¿Quiere jugar de nuevo?\nPresione S para SI o Presione otra tecla para NO");

                if (ConsoleKey.S != Console.ReadKey().Key)
                {
                    Princ = false;
                }
                else
                {
                    Console.Clear();
                }

            } while (Princ);
        }
    }
}
