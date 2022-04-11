using System;

namespace TallerEstructurasRepetitivas.Tools
{
    public static class DesviacionEstandarDecimal
    {
        /// <summary>
        /// Recibe un array de decimales y devuelve su desviacion estandar
        /// </summary>
        /// <returns>Decimal igual a desviacion</returns>
        /// <param name="Array">Arreglo de decimales</param>
        public static decimal DesviacionEstandar(Decimal[] Array)
        {
            return Sqrtd.Sqrt(VarianzaDecimal.Varianza(Array));
        }
    }
}
