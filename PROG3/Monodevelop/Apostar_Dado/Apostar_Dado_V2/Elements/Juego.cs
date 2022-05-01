using System;
using Apostar_Dado.Tools;

namespace Apostar_Dado_V2.Elements
{
    public static class Juego
    {
        public static bool EjecutarJ(ref Double Pozo, ref Jugador Jr1, ref Jugador Jr2)
        {
            int D1, D2;

            D1 = Dado.NumAleatorio();
            D2 = Dado.NumAleatorio();

            string dados = ($"***Se Lanzan los dados y sus valores son: {D1} y {D2}***\n");

            //Calculos
            CalculoJ(ref Pozo, ref Jr1, D1, D2);
            CalculoJ(ref Pozo, ref Jr2, D1, D2);

            //Impresiones
            Console.Clear();
            Console.WriteLine("***Bienvenido a la casa de Apuestas***\n\n");

            Console.WriteLine(dados);
            Impre1(Jr1);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("***Bienvenido a la casa de Apuestas***\n\n");

            Console.WriteLine(dados);
            Impre1(Jr2);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("***Bienvenido a la casa de Apuestas***\n\n");

            Console.WriteLine($"Ahora el Pozo es de: ${Pozo}\n\n");

            if (Pozo < 0)
            {
                Console.WriteLine("El pozo quedo negativo ya que las apuestas superaban la cantidad de dinero disponible.");
                Console.WriteLine("La casa de apuestas se hace cargo de la diferencia terminando aqui el juego.");
            }

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();

            //Controles
            if (Pozo <= 0)
            {
                return false;
            }
            else if (Jr1.GetSaldo() <= 0 || Jr2.GetSaldo() <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private static void CalculoJ(ref Double Pozo, ref Jugador jugador, int D1, int D2)
        {
            double aux;

            if (jugador.GetNumAp() == D1 && jugador.GetNumAp() == D2)
            {
                switch(jugador.GetTipAp())
                {
                    case 1:
                        {
                            aux = jugador.GetPlatAP() * 4;
                            Pozo -= aux;
                            jugador.AddSaldo(aux);
                            break;
                        }
                    case 2:
                        {
                            aux = jugador.GetPlatAP() * 10;
                            Pozo -= aux;
                            jugador.AddSaldo(aux);
                            break;
                        }
                    case 3:
                        {
                            aux = jugador.GetPlatAP() * 30;
                            Pozo -= aux;
                            jugador.AddSaldo(aux);
                            break;
                        }
                }

            }
            else if (jugador.GetNumAp() == D1 || jugador.GetNumAp() == D2)
            {
                switch (jugador.GetTipAp())
                {
                    case 1:
                        {
                            aux = jugador.GetPlatAP() * 2;
                            Pozo -= aux;
                            jugador.AddSaldo(aux);
                            break;
                        }
                    case 2:
                        {
                            aux = jugador.GetPlatAP() * 5;
                            Pozo -= aux;
                            jugador.AddSaldo(aux);
                            break;
                        }
                    case 3:
                        {
                            aux = jugador.GetPlatAP() * 15;
                            Pozo -= aux;
                            jugador.AddSaldo(aux);
                            break;
                        }
                }
            }
            else
            {
                switch (jugador.GetTipAp())
                {
                    case 1:
                        {
                            aux = jugador.GetPlatAP() * 1;
                            Pozo += aux;
                            jugador.SubSaldo(aux);
                            break;
                        }
                    case 2:
                        {
                            aux = jugador.GetPlatAP() * 2;
                            Pozo += aux;
                            jugador.SubSaldo(aux);
                            break;
                        }
                    case 3:
                        {
                            aux = jugador.GetPlatAP() * 4;
                            Pozo += aux;
                            jugador.SubSaldo(aux);
                            break;
                        }
                }
            }

        }

        private static void Impre1(Jugador jugador)
        {
            Console.WriteLine($"Jugador {jugador.GetNombre()}:\n");
            Console.WriteLine($"Usted aposto: ${jugador.GetPlatAP()}");
            Console.WriteLine($"Al Numero: {jugador.GetNumAp()}");

            switch(jugador.GetTipAp())
            {
                case 1:
                    {
                        Console.WriteLine("En Modo Conservador");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("En Modo Arriesgado");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("En Modo Desesperado");
                        break;
                    }
            }

            Console.WriteLine();

            Console.WriteLine($"Su Saldo Actual es: {jugador.GetSaldo()}\n\n");

        }
    }
}
