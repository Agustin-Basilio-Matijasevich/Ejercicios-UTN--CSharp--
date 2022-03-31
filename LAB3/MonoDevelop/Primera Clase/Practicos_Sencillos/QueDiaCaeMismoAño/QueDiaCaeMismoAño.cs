using System;

namespace QueDiaCaeMismoAño
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            String[] dias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
            int[] pDias = new int[12];
            String ano;
            int mes, dia;

            Console.WriteLine("Ingrese el año de la fecha que busca.");
            ano = Console.ReadLine();

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("\n\nIngrese que dia cae el primero de el mes {0} del año {1}\n\n", i+1, ano);
                Console.WriteLine("Ingrese 1 para Lunes, 2 para Martes, 3 para Miercoles, 4 Para jueves, 5 Para viernes, 6 Para Sabado, 7 Para Domingo");
                pDias[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("\nIngrese un mes (Del 1 al 12)");
            mes = int.Parse(Console.ReadLine());

            Console.WriteLine("\nIngrese un dia (Del 1 al 31)\n");
            dia = int.Parse(Console.ReadLine());
            dia = (dia % 7) - 1;

            Console.WriteLine("{0}", (pDias[mes - 1] - 1));

            for (int i = (pDias[mes-1] - 1); i > 0; i--)
            {
                if (dia == 6)
                {
                    dia = 0;
                }
                else
                {
                    dia++;
                }
            }

            Console.WriteLine("\nEl dia seleccionado cae {0}\n", (dias[dia]));

            Console.WriteLine("Los dias que caen fin de semana del mes {0} son:\n\n", mes);

            int pPartida = ((pDias[mes - 1]) - 1);

            for (int i = 1; i <= 31; i++)
            {
                if (pPartida > 4)
                {
                    Console.WriteLine("Dia: {0}. Cae: {1}", i, dias[pPartida]);
                }

                if (pPartida == 6)
                {
                    pPartida = 0;
                }
                else
                {
                    pPartida++;
                }

            }

        }
    }
}
