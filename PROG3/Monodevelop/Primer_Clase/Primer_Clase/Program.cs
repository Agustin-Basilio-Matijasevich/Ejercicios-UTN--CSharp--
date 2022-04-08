using System;

namespace Primer_Clase
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double n1, n2; //Con Punto flotante soporta dividir por 0

            Console.WriteLine("Ingrese un Numero ENTERO");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro Numero ENTERO");
            n2 = int.Parse(Console.ReadLine()); //Probar Tryparse

            Console.WriteLine("Las cuatro Operaciones Basicas son:\n\n");
            Console.WriteLine($"Suma: {n1 + n2}"); //Al usar el signo peso se identifican las salidas de variables, sirve para calculo simple(Interpolacion de Strings)
            Console.WriteLine("Resta: {0}", n1 - n2);
            Console.WriteLine("Multiplicacion: " + n1 * n2); //Tambien se puede concatenar como en java
            Console.WriteLine("DIvision: {0}", n1 / n2);

        }
    }
}
