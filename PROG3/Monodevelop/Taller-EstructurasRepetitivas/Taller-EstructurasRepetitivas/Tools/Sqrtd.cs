using System;

namespace TallerEstructurasRepetitivas.Tools
{
    public static class Sqrtd
    {
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
    }
}
