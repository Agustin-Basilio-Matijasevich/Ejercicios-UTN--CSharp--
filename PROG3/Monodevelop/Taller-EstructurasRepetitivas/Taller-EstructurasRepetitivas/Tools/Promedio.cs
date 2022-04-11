using System;

namespace TallerEstructurasRepetitivas.Tools
{
    public static class Promedio
    {
        public static decimal Prom(Decimal[] ArrayO)
        {
            decimal Media = 0;

            foreach (decimal Elemento in ArrayO)
            {
                Media += Elemento;
            }

            Media = Media / ArrayO.Length;

            return Media;
        }
    }
}
