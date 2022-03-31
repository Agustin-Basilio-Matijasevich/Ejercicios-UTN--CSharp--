using System;

namespace Presupuesto
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int HD = 3000; //Pesos
            int TD = 4; //Horas
            int tiempo = 10; //Dias habiles
            int dia = 8, mes = 4, ano = 2022; //Fecha de inicio

            //Calculo costo

            Console.WriteLine("El costo estimado para el trabajo es de: ${0}", ((HD*TD)*tiempo));

            //Calcular dia finalizacion
            int diaC;

            do
            {
                diaC = (dia % 7) - 1;

                for (int i = 4; i > 0; i--)
                {
                    if (diaC == 6)
                    {
                        diaC = 0;
                    }
                    else
                    {
                        diaC++;
                    }
                }


                if (diaC > 4)
                {
                    dia++;
                }
                else
                {
                    dia++;
                    tiempo--;
                }

            } while (tiempo > 1);

            Console.WriteLine("El trabajo se estima sera terminado el: {0}/{1}/{2}", dia, mes, ano);

        }
    }
}
