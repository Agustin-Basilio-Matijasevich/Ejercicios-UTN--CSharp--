using System;

namespace Cajero
{
    public abstract class Persona : IPersona
    {
        protected readonly String Nombre;
        protected readonly String DNI;
        protected Double Dinero;

        protected Persona(string Nombre, string DNI)
        {
            this.Nombre = Nombre;
            this.DNI = DNI;
            Dinero = 100;
        }

        protected Persona (string Nombre, string DNI, double Dinero)
        {
            this.Nombre = Nombre;
            this.DNI = DNI;
            this.Dinero = Dinero;
        }

        public string getNombre()
        {
            return Nombre;
        }

        public string getDNI()
        {
            return DNI;
        }

        public double getDinero()
        {
            return Dinero;
        }

    }
}
