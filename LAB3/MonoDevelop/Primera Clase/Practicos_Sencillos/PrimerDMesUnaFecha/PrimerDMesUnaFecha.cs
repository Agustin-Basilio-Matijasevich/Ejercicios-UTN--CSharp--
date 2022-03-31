using System;

namespace PrimerDMesUnaFecha
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int fecha, n;
            String[] dias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

            Console.WriteLine("Indique el primer dia del mes");
            Console.WriteLine("Ingrese 1 para Lunes, 2 para Martes, 3 para Miercoles, 4 Para jueves, 5 Para viernes, 6 Para Sabado, 7 Para Domingo");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Fecha del mes (Del 1 al 31");
            fecha = int.Parse(Console.ReadLine());
            fecha = (fecha % 7) -1;

            for (int i = (n-1); i > 0; i--)
            {
                if (fecha == 6)
                {
                    fecha = 0;
                }
                else
                {
                    fecha++;
                }
            }

            Console.WriteLine("Su Fecha cae dia: {0}", dias[fecha]);

        }
    }
}
