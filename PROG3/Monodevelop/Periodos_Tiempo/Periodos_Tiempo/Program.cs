using System;
using Periodos_Tiempo.Elements;

namespace Periodos_Tiempo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Arreglo de periodos, No importa el orden de carga
            Periodo[] periodos = new Periodo[]
            {
                new Periodo(new DateTime(2022, 03, 01), new DateTime(2022, 03, 31), "A"),  //Periodo A
                new Periodo(new DateTime(2023, 01, 01), new DateTime(2024, 04, 15), "B"),  //Periodo B
                new Periodo(new DateTime(2022, 03, 05), new DateTime(2022, 05, 15), "C"),  //Periodo C
                new Periodo(new DateTime(2023, 04, 20), new DateTime(2024, 04, 30), "D"),  //Periodo D
                new Periodo(new DateTime(2010, 04, 20), new DateTime(2010, 04, 30), "E"),  //Periodo D

            };

            for (int i = 0; i < periodos.Length; i++)
            {
                for (int j = 0; j < periodos.Length; j++)
                {
                    if (i != j)
                    {
                        if (Periodo.Unir_Periodos(periodos[i], periodos[j], out Periodo Union))
                        {
                            Periodo[] aux = new Periodo[periodos.Length - 2];

                            for (int r = 0, c = 0; r < periodos.Length; r++)
                            {
                                if (r != i && r != j)
                                {
                                    aux[c] = periodos[r];
                                    c++;
                                }
                            }

                            periodos = new Periodo[periodos.Length - 1];

                            periodos[0] = Union;

                            for (int r = 1, c = 0; r < periodos.Length; r++, c++)
                            {
                                periodos[r] = aux[c];
                            }

                            i = -1;
                            break;

                        }
                    }

                }
            }

            for (int i = 0; i < periodos.Length; i++)
            {
                Console.WriteLine($"Periodo {periodos[i].GetID()}: {periodos[i].ToString()}\n\n");
            }

        }
    }
}
