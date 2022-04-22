using System;

namespace Apostar_Dado
{
    class MainClass
    {
        public static void Main(string[] args)
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

            Dado = Apostar_Dado.Dado.NumAleatorio();

            Console.WriteLine($"Usted Ingreso: {Num}.\nEl Dado salio: {Dado}.");

            if(Dado == Num)
            {
                Console.WriteLine("Usted Gano!!");
            }
            else
            {
                Console.WriteLine("Usted Perdio!!");
            }

        }
    }
}
