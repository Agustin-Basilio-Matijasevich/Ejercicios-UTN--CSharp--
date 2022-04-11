using System;

namespace TallerEstructurasRepetitivas.Tools
{
    public static class ADecimalPrinter
    {
        /// <summary>
        /// Recibe un array de decimales y lo imprime por consola
        /// </summary>
        /// <param name="Array">Arreglo de decimales</param>
        public static void Printer(Decimal[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                //Texto de impresion modificable
                Console.WriteLine($"Persona {i + 1} mide: {Array[i].ToString("0.###")} cm");

            }

        }
    }
}
