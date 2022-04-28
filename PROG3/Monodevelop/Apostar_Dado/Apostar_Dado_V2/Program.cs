using System;
using Apostar_Dado_V2.Elements;

namespace Apostar_Dado_V2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Bienvenida
            Saludo();

            //Creado de Jugadores
            Console.Write("Ingrese Nombre del Jugador 1: ");
            Jugador Jr1 = new Jugador(Console.ReadLine());
            Console.Write("Ingrese Nombre del Jugador 2: ");
            Jugador Jr2 = new Jugador(Console.ReadLine());



        }

        public static void Saludo()
        {
            Console.WriteLine("***Bienvenido a la casa de Apuestas***\n\n");
            Console.WriteLine("A continuacion se muestran las reglas:\n");
            Console.WriteLine("Son dos jugadores.");
            Console.WriteLine("El pozo es de $10000 y cada jugador cuenta con $100 para empezar.");
            Console.WriteLine("Cada vez que se apueste hay 3 opciones, Conservador, Arriesgado y Desesperado");
            Console.WriteLine("El Juego termina cuando algun Jugador quiere, se queda sin dinero o el Pozo llega a 0\n\n");

            Console.WriteLine("Si entiende las Reglas...");
            Console.WriteLine("Presione Cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
