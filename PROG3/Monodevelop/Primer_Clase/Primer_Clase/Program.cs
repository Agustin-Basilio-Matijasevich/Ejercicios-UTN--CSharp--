using System;

namespace Primer_Clase
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Ingrese un Numero ENTERO");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro Numero ENTERO");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Las cuatro Operaciones Basicas son:\n\n");
            Console.WriteLine("Suma: {0}", n1 + n2);
            Console.WriteLine("Resta: {0}", n1 - n2);
            Console.WriteLine("Multiplicacion: {0}", n1 * n2);
            Console.WriteLine("DIvision: {0}", n1 / n2);

        }
    }
}
