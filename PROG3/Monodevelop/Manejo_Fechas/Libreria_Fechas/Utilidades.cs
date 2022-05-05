using System;

namespace Libreria_Fechas
{
    public static class Utilidades
    {
        public static int ObtenerDiasCalendario(DateTime Fecha1, DateTime Fecha2)
        {
            return Math.Abs((Fecha1 - Fecha2).Days) + 1;
        }

        public static int ObtenerDiasLaborables(DateTime Fecha1, DateTime Fecha2)
        {
            int cont = 0;
            Feriados feriados = new Feriados();

            if ((Fecha1 - Fecha2).Days < 0)  //Fecha1 mas Chico
            {
                DateTime aux = new DateTime(Fecha1.Year, Fecha1.Month, Fecha1.Day);

                for (int i = 0; i < ObtenerDiasCalendario(Fecha1, Fecha2); i++)
                {
                    if (aux.DayOfWeek != DayOfWeek.Saturday && aux.DayOfWeek != DayOfWeek.Sunday && !feriados.Contains(aux))
                    {
                        cont++;
                    }

                    aux = aux.AddDays(1);
                }
            }
            else if ((Fecha1 - Fecha2).Days > 0)  //Fecha2 mas Chico
            {
                DateTime aux = new DateTime(Fecha2.Year, Fecha2.Month, Fecha2.Day);

                for (int i = 0; i < ObtenerDiasCalendario(Fecha1, Fecha2); i++)
                {
                    if (aux.DayOfWeek != DayOfWeek.Saturday && aux.DayOfWeek != DayOfWeek.Sunday && !feriados.Contains(aux))
                    {
                        cont++;
                    }

                    aux = aux.AddDays(1);
                }
            }

            return cont;
        }

        public static DateTime SumarDiasLaborables(DateTime Fecha, int CantDias)
        {
            Feriados feriados = new Feriados();
            DateTime aux = new DateTime(Fecha.Year, Fecha.Month, Fecha.Day);

            while (CantDias > 0)
            {
                if (aux.DayOfWeek != DayOfWeek.Saturday && aux.DayOfWeek != DayOfWeek.Sunday && !feriados.Contains(aux))
                {
                    CantDias--;
                }

                if (CantDias > 0)
                {
                    aux = aux.AddDays(1);
                }

            }

            return aux;
        }

    }
}
