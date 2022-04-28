using System;

namespace Apostar_Dado_V2.Elements
{
    public class Jugador
    {
        String Nombre;
        double Saldo;

        public Jugador(String Nombre)
        {
            this.Nombre = Nombre;
            Saldo = 100;
        }
    }
}
