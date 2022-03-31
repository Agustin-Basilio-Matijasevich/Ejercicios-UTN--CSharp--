using System;

/*Realizar una aplicacion de tipo consola en c# que según la opción escogida en un menú, permita mostrar la tabla de multiplicar de un número ingresado
 * por el usuario, o solicitar que se ingresen dos números "a" y "b" para mostrar las operaciones suma "a+b", resta "a-b", multiplicación "a*b", divicion
 * "a/b" y resto de "a%b"*/

namespace Aplicacion_matematica
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n,a,b;

            Console.WriteLine("--Tabla de Multiplicar--");

            Console.WriteLine("Ingrese un numero entero");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("La tabla del {0} es:\n", n);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} es: {2}", n, i, n * i);
            }


            Console.WriteLine("\n\n--Operaciones--");

            Console.WriteLine("Ingrese un numero entero a");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un numero entero b");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Suma ==> {0}", a + b);
            Console.WriteLine("Resta ==> {0}", a - b);
            Console.WriteLine("Multiplicacion ==> {0}", a * b);
            Console.WriteLine("Division ==> {0}", a / b);
            Console.WriteLine("Resto ==> {0}", a % b);

        }
    }
}
