using System;
using Libreria_Fechas;

namespace Manejo_Fechas
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DateTime Fecha1 = new DateTime(2022, 03, 21);
            DateTime Fecha2 = new DateTime(2022, 03, 27);

            Console.WriteLine($"La cantidad de dias entre las fechas son: {Utilidades.ObtenerDiasCalendario(Fecha1, Fecha2)}");
            Console.WriteLine($"La cantidad de dias laborales son: {Utilidades.ObtenerDiasLaborables(Fecha2, Fecha1)}");
            Console.WriteLine($"Si empiezo en Fecha1 un trabajo que me toma 5 dias termino: {Utilidades.SumarDiasLaborables(Fecha1, 5)}");

        }
    }
}
