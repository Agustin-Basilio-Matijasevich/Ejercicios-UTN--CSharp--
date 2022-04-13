using System;

namespace Cajero.Elements
{
    public class Jubilado : Persona, IUsuario
    {
        public Jubilado(string Nombre, string DNI) : base (Nombre, DNI)
        {
            
        }

        public Jubilado(string Nombre, string DNI, decimal Dinero) : base (Nombre, DNI, Dinero)
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



                    return false;
                }
                else
                {
                    if (Dinero + Deuda <= 10000)
                    {
                        //Dar adelanto
                        this.Deuda += Dinero;

                        //Generar Registro
                        Registros.Add(new RegOP(ID, DateTime.Now, Dinero, this.Dinero, this.Deuda));

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
                Console.WriteLine($"Usted como Jubilado puede solicitar adelantos por un maximo de $10000");

                if (Dinero + Deuda <= 10000)
                {
                    //Dar adelanto
                    this.Deuda += Dinero;

                    //Generar Registro
                    Registros.Add(new RegOP(ID, DateTime.Now, Dinero, this.Dinero, this.Deuda));

                    return false;
                }
                else
                {
                    Console.WriteLine("\n\n***Usted No puede contraer tanta deuda\n\n***");
                    return true;
                }

            }
            
        }

    }
}
