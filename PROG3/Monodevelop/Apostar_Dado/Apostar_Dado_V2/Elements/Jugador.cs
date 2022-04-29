using System;

namespace Apostar_Dado_V2.Elements
{
    public class Jugador
    {
        private readonly String Nombre;
        private double Saldo;
        private int NumAp, TipAp;

        public Jugador(String Nombre)
        {
            if (Nombre.Length != 0)
            {
                this.Nombre = Nombre;
            }
            else
            {
                this.Nombre = "Jugador sin Nombre";
            }

            Saldo = 100;

        }

        public int GetNumAp()
        {
            return NumAp; 
        }

        public int GetTipAp()
        {
            return TipAp;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public double GetSaldo()
        {
            return Saldo;
        }

        public void SetSaldo(double Saldo)
        {
            if (Saldo < 0)
            {
                this.Saldo = 0;
            }
            else
            {
                this.Saldo = Saldo;
            }

        }

        public bool SetNumAp(int Numero)
        {
            if (Numero >= 1 && Numero <= 6)
            {
                NumAp = Numero;
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool SetTipAp(int Numero)
        {
            if (Numero >= 1 && Numero <= 3)
            {
                TipAp = Numero;
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
