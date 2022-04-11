using System;

namespace TallerEstructurasRepetitivas.Tools
{
    /// <summary>
    /// Impresora de Arrays de decimales.
    /// </summary>
    public static class ADecimalPrinter
    {
        /// <summary>
        /// Recibe un array de decimales y lo imprime por consola.
        /// Salida modificable en codigo.
        /// </summary>
        /// <param name="Array">Arreglo de decimales</param>
        public static void Printer(Decimal[] Array)
        {
            //Variables para usar Modificables
            decimal Media = Tools.Math.Promedio(Array);
            decimal DE = Tools.Math.DesviacionEstandar(Array);

            for (int i = 0; i < Array.Length; i++)
            {
                //Texto de impresion modificable
                if ((Array[i] > Media) && ((System.Math.Abs(Array[i] - Media)) < DE)) //Mayor y en rango
                {
                    Console.WriteLine($"Persona {i + 1} mide: {Array[i].ToString("0.###")} cm / ''Mayor a Media'' ''En Rango''");
                }
                else if ((Array[i] < Media) && ((System.Math.Abs(Array[i] - Media)) < DE)) //Mayor y en rango
                {
                    Console.WriteLine($"Persona {i + 1} mide: {Array[i].ToString("0.###")} cm / ''Menor a Media'' ''En Rango''");
                }
                else if ((Array[i] > Media) && ((System.Math.Abs(Array[i] - Media)) > DE)) //Mayor y en rango
                {
                    Console.WriteLine($"Persona {i + 1} mide: {Array[i].ToString("0.###")} cm / ''Mayor a Media'' ''Fuera de Rango''");
                }
                else if ((Array[i] < Media) && ((System.Math.Abs(Array[i] - Media)) > DE)) //Mayor y en rango
                {
                    Console.WriteLine($"Persona {i + 1} mide: {Array[i].ToString("0.###")} cm / ''Menor a Media'' ''Fuera de Rango''");
                }

            }

        }
    }
}
