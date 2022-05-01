using System;
using Apostar_Dado_V2.Elements;

namespace Apostar_Dado_V2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Variables
            Double Pozo = 10000;
            Jugador Jr1, Jr2;
            bool Flag = true;

            //Bienvenida
            Saludo();

            //Creado de Jugadores
            Console.WriteLine("***Bienvenido a la casa de Apuestas***\n\n");
            Console.Write("Ingrese Nombre del Jugador 1: ");
            Jr1 = new Jugador(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("***Bienvenido a la casa de Apuestas***\n\n");
            Console.Write("Ingrese Nombre del Jugador 2: ");
            Jr2 = new Jugador(Console.ReadLine());

            //Ciclo Principal del Juego
            while (Flag)
            {
                Console.Clear();
                Console.WriteLine("***Bienvenido a la casa de Apuestas***\n\n");

                Console.WriteLine($"Jugador {Jr1.GetNombre()}. ¿Desea continuar Jugando?\n");
                Console.WriteLine("Presione S para SI, o cualquier otra tecla para NO");

                if (ConsoleKey.S == Console.ReadKey().Key)
                {
                    //Carga Datos
                    CargaDatos(ref Jr1);
                }
                else
                {
                    break;
                }

                Console.Clear();
                Console.WriteLine("***Bienvenido a la casa de Apuestas***\n\n");

                Console.WriteLine($"Jugador {Jr2.GetNombre()}. ¿Desea continuar Jugando?\n");
                Console.WriteLine("Presione S para SI, o cualquier otra tecla para NO");

                if (ConsoleKey.S == Console.ReadKey().Key)
                {
                    //Carga Datos
                    CargaDatos(ref Jr2);
                }
                else
                {
                    break;
                }

                //Juego
                Flag = Juego.EjecutarJ(ref Pozo, ref Jr1, ref Jr2);

            }

            //Despedida
            Console.Clear();
            Console.WriteLine("***Resultados de la Partida***\n\n");

            Console.WriteLine($"Jugador {Jr1.GetNombre()}, Saldo Final: ${Jr1.GetSaldo()}\n");
            Console.WriteLine($"Jugador {Jr2.GetNombre()}, Saldo Final: ${Jr2.GetSaldo()}\n");
            Console.WriteLine($"Pozo Final: ${Pozo}\n\n");

            if (Jr1.GetSaldo() > Jr2.GetSaldo())
            {
                Console.WriteLine($"***GANADOR: {Jr1.GetNombre()}***");
            }
            else if (Jr1.GetSaldo() < Jr2.GetSaldo())
            {
                Console.WriteLine($"***GANADOR: {Jr2.GetNombre()}***");
            }
            else
            {
                Console.WriteLine("***EMPATE***");
            }

            Console.WriteLine("\n\nPresione una tecla para continuar...");
            Console.ReadKey();

        }

        private static void CargaDatos(ref Jugador jugador)
        {

            bool Aux;

            while(true)
            {
                Console.Clear();
                Console.WriteLine("***Bienvenido a la casa de Apuestas***\n\n");

                Console.WriteLine($"Jugador {jugador.GetNombre()}.\n");
                Console.WriteLine("Ingrese su apuesta. (Numero entre 1 y 6).\n");

                Aux = int.TryParse(Console.ReadLine(), out int Valor);

                if (Aux && jugador.SetNumAp(Valor))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Valor Invalido, Presione una tecla para reintentar");
                    Console.ReadKey();
                }

            }

            while(true)
            {
                string Ingreso; Ingreso = null;
                double Iparse;

                Console.Clear();
                Console.WriteLine("***Bienvenido a la casa de Apuestas***\n\n");

                Console.WriteLine($"Jugador {jugador.GetNombre()}.\n");
                Console.WriteLine($"Usted tiene un saldo de: ${jugador.GetSaldo()}.\n");
                Console.WriteLine("Ingrese ''todo'' para apostar todo su dinero.");
                Console.WriteLine("Caso contrario ingrese la cantidad que quiere apostar.");

                Ingreso = Console.ReadLine();

                if (Ingreso.Equals("todo"))
                {
                    Console.WriteLine("Usted esta a punto de apostarlo todo.");
                    Console.WriteLine("Presione S para Confirmar o cualquier otra tecla para Cancelar");

                    if (ConsoleKey.S == Console.ReadKey().Key)
                    {
                        jugador.SetPlatAP(jugador.GetSaldo());
                        break;
                    }

                }
                else if (double.TryParse(Ingreso, out Iparse))
                {
                    if (Iparse < jugador.GetSaldo())
                    {
                        Console.WriteLine($"Usted esta a punto de apostar: ${Iparse}.");
                        Console.WriteLine("Presione S para Confirmar o cualquier otra tecla para Cancelar");

                        if (ConsoleKey.S == Console.ReadKey().Key)
                        {
                            jugador.SetPlatAP(Iparse);
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ingreso Invalido. Presione una tecla para continuar...");
                        Console.ReadKey();
                    }

                }
                else
                {
                    Console.WriteLine("Ingreso Invalido. Presione una tecla para continuar...");
                    Console.ReadKey();
                }

            }

            while (true)
            {
                bool Flag = false;

                Console.Clear();
                Console.WriteLine("***Bienvenido a la casa de Apuestas***\n\n");

                Console.WriteLine($"Jugador {jugador.GetNombre()}.\n");
                Console.WriteLine("Ingrese su tipo de apuesta.\n");
                Console.WriteLine("Ingrese A para Conservador. (-1/2)");
                Console.WriteLine("Ingrese B para Arriesgado. (-2/5)");
                Console.WriteLine("Ingrese C para Desesperado. (-4/15)");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.A:
                        {
                            jugador.SetTipAp(1);
                            Flag = true;
                            break;
                        }
                    case ConsoleKey.B:
                        {
                            jugador.SetTipAp(2);
                            Flag = true;
                            break;
                        }
                    case ConsoleKey.C:
                        {
                            jugador.SetTipAp(3);
                            Flag = true;
                            break;
                        }
                }

                if (Flag)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Valor Invalido, Presione una tecla para reintentar");
                    Console.ReadKey();
                }

            }

        }

        private static void Saludo()
        {
            Console.WriteLine("***Bienvenido a la casa de Apuestas***\n\n");
            Console.WriteLine("A continuacion se muestran las reglas:\n");
            Console.WriteLine("Son dos jugadores.");
            Console.WriteLine("El pozo es de $10000 y cada jugador cuenta con $100 para empezar.");
            Console.WriteLine("Cada vez que se apueste hay 3 opciones, Conservador, Arriesgado y Desesperado");
            Console.WriteLine("El Juego termina si un Jugador quiere, se queda sin dinero o el Pozo llega a 0\n\n");

            Console.WriteLine("Si entiende las Reglas...");
            Console.WriteLine("Presione Cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
