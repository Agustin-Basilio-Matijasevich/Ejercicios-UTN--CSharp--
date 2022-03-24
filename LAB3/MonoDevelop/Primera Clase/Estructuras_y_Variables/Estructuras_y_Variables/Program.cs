using System;

namespace Estructuras_y_Variables
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 2, b = 3, c = 5;
            Boolean esMucho = false;

            esMucho = (10 < a + b + c) ? true : false;  //Operador ternario, cumple la funcion de un if sencillo

            if (10 < a+b+c)
            {
                //esMucho = true;
                Console.WriteLine("La suma de las variables es: {0}", a + b + c);
            }
            else
            {
                Console.WriteLine("La suma de las variables es menor o igual a 10: {0}", a + b + c);
            }

            Console.WriteLine("{1} La suma de las variables es: {0}", a + b + c, c); //Los corchetes ordenan la salida de variables

            int opcion = 0;

            Console.WriteLine("1- Sume las variables");
            Console.WriteLine("2- Reste las variables");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: 
                    Console.WriteLine("La suma de las variables es: {0}", a + b + c);
                    break;

                case 2:
                    Console.WriteLine("La resta de las variables es: {0}", a - b - c);
                    break;

                default:
                    break;
            }

            //float f = 2.35f;
            //double d = 2.0035;

            //Carga vector e imprime tabla indexada

            int[] vector = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese Valor: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            int contador = 0;

            foreach (var numero in vector)
            {
                contador++;
                Console.WriteLine("El Numero {1} es: {0}", numero, contador);
            }

            //Imprime tabla del numero

            int n;

            Console.WriteLine("Ingrese un numero entero");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("La tabla del {0} es:\n", n);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} es: {2}", n, i, n*i);
            }

            //Indicas dia que arranca el mes y una fecha de ese mes y te dice que dia cae
            int fecha;
            String[] dias = {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo"};

            Console.WriteLine("Indique el primer dia del mes");
            Console.WriteLine("Ingrese 1 para Lunes, 2 para Martes, 3 para Miercoles, 4 Para jueves, 5 Para viernes, 6 Para Sabado, 7 Para Domingo");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Fecha (Del 1 al 31");
            fecha = int.Parse(Console.ReadLine());
            Console.WriteLine("Su Fecha cae dia: {0}", dias[(((fecha % 7)+(n-1))-1)]);

        }
    }
}
