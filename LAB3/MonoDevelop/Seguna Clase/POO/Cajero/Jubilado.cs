using System;

namespace Cajero
{
    public class Jubilado : Persona, IUsuario
    {
        public Jubilado(string Nombre, string DNI) : base (Nombre, DNI)
        {
            
        }

        public Jubilado(string Nombre, string DNI, double Dinero) : base (Nombre, DNI, Dinero)
        {

        }

        public bool RetirarDinero(double dinero)
        {
            if (dinero < this.Dinero) //Puedo retirar
            {
                Dinero = Dinero - dinero;
                return false;
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente");
                return true;
            }
        }

        public bool DepositarDinero(double dinero)
        {
            Console.WriteLine("Usted es Jubilado y no puede depositar dinero.");
            return true;
        }

    }
}
