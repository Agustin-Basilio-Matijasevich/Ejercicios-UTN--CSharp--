using System;

namespace Cajero.Elements
{
    public class RegOP
    {
        private readonly IDCaj IDCajero;
        private readonly DateTime FechaOP;
        private readonly decimal MontoOP;
        private readonly decimal Dinero;
        private readonly decimal Deuda;

        public RegOP(IDCaj ID, DateTime Fecha, decimal Monto, decimal Dinero, decimal Deuda)
        {
            this.IDCajero = ID;
            this.FechaOP = Fecha;
            this.MontoOP = Monto;
            this.Dinero = Dinero;
            this.Deuda = Deuda;
        }

        public DateTime GetFecha()
        {
            return FechaOP;
        }

        public decimal GetDinero()
        {
            return Dinero;
        }

        public decimal GetDeuda()
        {
            return Deuda;
        }

        public override string ToString()
        {
            return ($"Cajero: {IDCajero.ToString()} / Fecha: {FechaOP.ToString()} / Monto: {MontoOP.ToString("0.###")}");
        }

    }
}
