using System;

namespace TallerEstructurasRepetitivas.Tools
{
    /// <summary>
    /// Libreria Math propietaria, contiene funciones para calcular lo necesario para el sistema en decimales.
    /// </summary>
    public static class Math
    {
        /// <summary>
        /// Recibe un Array de decimales y calcula la media de sus elementos.
        /// </summary>
        /// <returns>Promedio de Elementos</returns>
        /// <param name="ArrayO">Arreglo de elementos a calcular el promedio</param>
        public static decimal Promedio(Decimal[] ArrayO)
        {
            decimal Media = 0;

            foreach (decimal Elemento in ArrayO)
            {
                Media += Elemento;
            }

            Media = Media / ArrayO.Length;

            return Media;
        }


        /// <summary>
        /// Devuelve la raiz cuadrada de un decimal.
        /// </summary>
        /// <returns>La raiz cuadrada en tipo decimal</returns>
        /// <param name="x">El decimal a obtener Raiz Cuadrada</param>
        public static decimal Sqrt(decimal x, decimal? guess = null)
        {
            var ourGuess = guess.GetValueOrDefault(x / 2m);
            var result = x / ourGuess;
            var average = (ourGuess + result) / 2m;

            if (average == ourGuess) // This checks for the maximum precision possible with a decimal.
                return average;
            else
                return Sqrt(x, average);

        }


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
            Media = Promedio(ArrayO);

            //Calculo de la diferencia contra la media
            for (int i = 0; i < ArrayO.Length; i++)
            {
                decimal aux = (ArrayO[i] - Media);
                Array[i] = (aux * aux); //Elevacion al cuadrado
            }

            //Calculo de la Varianza
            Media = Promedio(Array);

            return Media;

        }


        /// <summary>
        /// Recibe un array de decimales y devuelve su desviacion estandar
        /// </summary>
        /// <returns>Decimal igual a desviacion</returns>
        /// <param name="Array">Arreglo de decimales</param>
        public static decimal DesviacionEstandar(Decimal[] Array)
        {
            return Sqrt(Varianza(Array));
        }

    }
}
