using System;

namespace TallerEstructurasRepetitivas.Tools
{
    public static class VarianzaDecimal
    {
        /// <summary>
        /// Recibe un array de decimales y devuelve su desviacion estandar
        /// </summary>
        /// <returns>Varianza en decimal</returns>
        /// <param name="ArrayO">Arreglo de decimales</param>
        public static decimal Varianza(Decimal[] ArrayO)
        {
            Decimal[] Array = new decimal[ArrayO.Length];
            decimal Media;

            //Calculo de la Media
            Media = Promedio.Prom(ArrayO);

            //Calculo de la diferencia contra la media
            for (int i = 0; i < ArrayO.Length; i++)
            {
                decimal aux = (ArrayO[i] - Media);
                Array[i] = (aux * aux); //Elevacion al cuadrado
            }

            //Calculo de la Varianza
            Media = Promedio.Prom(Array);

            return Media;

        }
    }
}
