using System;

namespace Cajero.Elements
{
    public class Activo : Persona, IUsuario
    {
        public Activo(string Nombre, string DNI) : base(Nombre, DNI)
        {

        }

        public Activo(string Nombre, string DNI, decimal Dinero) : base(Nombre, DNI, Dinero)
        {

        }

        public bool PedirAdelanto(decimal Dinero, IDCaj ID)
        {
            //¿Credito?
            if (Credito.Puedo(Registros))
            {
                ConsoleKeyInfo resp;

                Console.WriteLine("\n\n***AVISO***\n\n");
                Console.WriteLine("\n\n***Usted dispone de la posibilidad de solicitar un credito por $80000***\n\n");
                Console.WriteLine("\n\nPresione A para Aceptar el credito");
                Console.WriteLine("\n\nPresione cualquier otra tecla para Rechazar el credito");

                resp = Console.ReadKey();

                if (resp.Key == ConsoleKey.A)
                {
                    //Dar Credito

                    this.Deuda += 80000;
                    this.Dinero += 80000;

                    return false;
                }
                else
                {
                    if (Dinero + Deuda <= 20000)
                    {
                        //Dar adelanto
                        this.Deuda += Dinero;
                        this.Dinero += Dinero;

                        //Generar Registro
                        Registros.Add(new RegOP(ID, DateTime.Now, "Adelanto de Sueldo", Dinero, this.Dinero, this.Deuda));

                        return false;
                    }
                    else
                    {
                        Console.WriteLine("\n\n***Usted No puede contraer tanta deuda\n\n***");
                        return true;
                    }

                }

            }
            else
            {
                Console.WriteLine("\n\n***Adelanto de Sueldo***\n\n");
                Console.WriteLine($"Usted actualmente debe ${Deuda}");
                Console.WriteLine($"Usted como Activo puede solicitar adelantos por un maximo de $20000");

                if (Dinero + Deuda <= 20000)
                {
                    //Dar adelanto
                    this.Deuda += Dinero;
                    this.Dinero += Dinero;

                    //Generar Registro
                    Registros.Add(new RegOP(ID, DateTime.Now, "Adelanto de Sueldo", Dinero, this.Dinero, this.Deuda));

                    return false;
                }
                else
                {
                    Console.WriteLine("\n\n***Usted No puede contraer tanta deuda***\n\n");
                    return true;
                }

            }

        }

    }
}
