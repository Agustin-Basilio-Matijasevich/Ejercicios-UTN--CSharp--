using System;
using TallerEstructurasRepetitivas.Tools;

namespace TallerEstructurasRepetitivas
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--Desviacion Estandar Prog3 Por Agustin Basilio--\n\n");

            Decimal[] Personas = new decimal[5];
            decimal DesviacionE, Media;

            //Carga del array
            for (int i = 0; i < Personas.Length; i++)
            {
                bool bandera;

                do
                {
                    Console.Write($"Ingrese la altura en centimetros de la Presona {i + 1}: ");
                    bandera = decimal.TryParse(Console.ReadLine(), out Personas[i]);
                    Console.Write("\n\n");
                } while (!bandera);

            }

            //Calculo de la Media
            Media = Promedio.Prom(Personas);

            //Calculo Desviacion Estandar
            DesviacionE = DesviacionEstandarDecimal.DesviacionEstandar(Personas);

            //Presentacion de Resultados
            Console.WriteLine("--Alturas Obtenidas--\n\n");
            ADecimalPrinter.Printer(Personas);
            Console.Write("\n\n");

            Console.WriteLine("--Resultados de los Calculos--\n\n");
            Console.WriteLine($"La Media de altura de las personas es: {Media.ToString("0.###")}");
            Console.WriteLine($"La Desviacion Estandar de altura de las personas es: {DesviacionE.ToString("0.###")}\n");

        }
    }
}
