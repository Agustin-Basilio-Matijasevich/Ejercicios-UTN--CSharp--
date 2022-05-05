using System;

namespace Libreria_Fechas
{
    public class Feriados
    {
        private readonly DateTime[] DiasFeriado;

        public Feriados()
        {
            DiasFeriado = new DateTime[]  //Aca se cargan los feriados
            {
                new DateTime(2022, 01, 01),
                new DateTime(2022, 02, 28),
                new DateTime(2022, 03, 01),
                new DateTime(2022, 03, 24),
                new DateTime(2022, 04, 02),
                new DateTime(2022, 04, 15),
                new DateTime(2022, 05, 01),
                new DateTime(2022, 05, 18),
                new DateTime(2022, 05, 25),
                new DateTime(2022, 06, 20),
                new DateTime(2022, 07, 09),
                new DateTime(2022, 12, 08),
                new DateTime(2022, 12, 25),

            };
        }

        public DateTime[] GetFeriados()
        {
            return DiasFeriado;
        }

        public bool Contains(DateTime Fecha)
        {
            for (int i = 0; i < DiasFeriado.Length; i++)
            {
                if (Fecha.Equals(DiasFeriado[i]))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
