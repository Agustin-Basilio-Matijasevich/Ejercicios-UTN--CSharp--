using System;
using System.Collections.Generic;

namespace Cajero.Elements
{
    public abstract class Persona : IPersona
    {
        protected readonly string Nombre;
        protected readonly string DNI;
        protected decimal Dinero;
        protected decimal Deuda;
        protected List<RegOP> Registros;

        protected Persona(string Nombre, string DNI)
        {
            this.Nombre = Nombre;
            this.DNI = DNI;
            Dinero = 0;
            Deuda = 0;
            Registros = new List<RegOP>();
        }

        protected Persona (string Nombre, string DNI, decimal Dinero)
        {
            this.Nombre = Nombre;
            this.DNI = DNI;
            this.Dinero = Dinero;
            Deuda = 0;
            Registros = new List<RegOP>();
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public string GetDNI()
        {
            return DNI;
        }

        public decimal GetDinero()
        {
            return Dinero;
        }

        public decimal GetDeuda()
        {
            return Deuda;
        }

        public void GetRegistros()
        {
            foreach (RegOP reg in Registros)
            {
                Console.WriteLine($"\n\n{reg.ToString()}\n\n");
            }
        }

        public bool RetirarDinero(decimal Dinero, IDCaj ID)
        {
            if (Dinero <= this.Dinero) //Puedo retirar
            {
                this.Dinero -= Dinero;

                //Generar Registro
                Registros.Add(new RegOP(ID, DateTime.Now, Dinero * -1, this.Dinero, this.Deuda));

                return false;
            }
            else
            {
                Console.WriteLine("\n\n***Saldo Insuficiente***\n\n");
                return true;
            }
        }

        public bool DepositarDinero(decimal Dinero, IDCaj ID)
        {
            this.Dinero += Dinero;

            //Generar Registro
            Registros.Add(new RegOP(ID, DateTime.Now, Dinero, this.Dinero, this.Deuda));

            return false;
        }

        public bool SaldarDeuda(decimal Dinero, IDCaj ID)
        {
            Console.WriteLine("\n\n***Saldar Deuda***\n\n");
            Console.WriteLine($"Usted actualmente debe ${Deuda}");

            if (Dinero <= this.Dinero)
            {
                if (Dinero <= this.Deuda)
                {
                    this.Deuda -= Dinero;
                    this.Dinero -= Dinero;

                    //Generar Registro
                    Registros.Add(new RegOP(ID, DateTime.Now, Dinero, this.Dinero, this.Deuda));

                    return false;
                }
                else
                {
                    Console.WriteLine("\n\n***Su deuda no es tan grande, intente un importe menor***\n\n");
                    return true;
                }
            }
            else
            {
                Console.WriteLine("\n\n***Saldo Insuficiente***\n\n");
                return true;
            }

        }

    }
}
