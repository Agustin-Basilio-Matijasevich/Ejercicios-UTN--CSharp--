using System;

namespace Tabla
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n;

            Console.WriteLine("--Tabla de Multiplicar--");

            Console.WriteLine("Ingrese un numero entero");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("La tabla del {0} es:\n", n);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} es: {2}", n, i, n * i);
            }

        }
    }
}
