using System;

namespace Cajero
{
    public class Activo : Persona, IUsuario
    {
        public Activo(string Nombre, string DNI) : base(Nombre, DNI)
        {

        }

        public Activo(string Nombre, string DNI, double Dinero) : base(Nombre, DNI, Dinero)
        {

        }

        public bool RetirarDinero()
        {

        }

        public bool DepositarDinero()
        {

        }

    }
}
