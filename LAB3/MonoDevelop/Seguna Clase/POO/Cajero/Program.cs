using System;
using System.Collections.Generic;
using Cajero.Elements;

namespace Cajero
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Inicializacion de sistema
            List<Persona> Personas = new List<Persona>();
            IDCaj ID;
            string aux1, aux2;

            Console.WriteLine("---Inicializando sistema---\n\n");
            Console.Write("Ingrese el ''Numero de Cajero'': ");
            aux1 = Console.ReadLine();
            Console.Write("Ingrese ''Direccion de Cajero'': ");
            aux2 = Console.ReadLine();

            ID = new IDCaj(aux2, aux1);
            Console.Clear();
            //Fin Inicializacion de sistema

            do
            {
                Console.WriteLine("***Bienvenido a Banco Basilio***\n\n");

                //Variables
                string DNI, index = null;

                //Buscador
                Console.Write("Ingrese su DNI: ");
                DNI = Console.ReadLine();

                for (int i = 0; i < Personas.Count; i++)
                {
                    if (DNI.Equals((Personas[i].GetDNI())))
                    {
                        index = i.ToString();
                        break;
                    }
                }

                if (index == null)
                {
                    Console.WriteLine("\n\n***Usted NO es usuario de ''Banco Basilio''***\n\n");
                    Console.WriteLine("Para registrarse Presione A, de lo contrario Presione cualquier otra tecla");

                    if (Console.ReadKey().Key == ConsoleKey.A)
                    {
                        //Registro
                        ConsoleKeyInfo opcion;
                        Console.WriteLine("\n\nSi es usted Activo Presione A\nSi es usted Jubilado Presione J");
                        opcion = Console.ReadKey();

                        if (opcion.Key == ConsoleKey.A)
                        {
                            string Nombre;

                            Console.WriteLine("\n\nIngrese su nombre completo: ");
                            Nombre = Console.ReadLine();

                            Console.WriteLine("\n\n¿Desea realizar un Deposito incial? Presione S para SI");

                            if (Console.ReadKey().Key == ConsoleKey.S)
                            {
                                decimal Deposito;
                                bool Bandera;


                                Console.WriteLine("\nIngrese el Deposito: ");

                                do
                                {
                                    Bandera = decimal.TryParse(Console.ReadLine(), out Deposito);
                                } while (!Bandera);


                                Personas.Add(new Activo(Nombre, DNI, Deposito));

                            }
                            else
                            {
                                Personas.Add(new Activo(Nombre, DNI));
                            }

                            Console.WriteLine("\n\n***Usuario Activo creado CORRECTAMENTE***\n\n");
                            Console.WriteLine("\n\n***Presione una tecla para continuar***\n\n");
                            Console.ReadKey();
                        }
                        else if (opcion.Key == ConsoleKey.J)
                        {
                            string Nombre;

                            Console.WriteLine("\n\nIngrese su nombre completo: ");
                            Nombre = Console.ReadLine();

                            Console.WriteLine("\n\n¿Desea realizar un Deposito incial? Presione S para SI");

                            if (Console.ReadKey().Key == ConsoleKey.S)
                            {
                                decimal Deposito;
                                bool Bandera;


                                Console.WriteLine("\nIngrese el Deposito: ");

                                do
                                {
                                    Bandera = decimal.TryParse(Console.ReadLine(), out Deposito);
                                } while (!Bandera);


                                Personas.Add(new Activo(Nombre, DNI, Deposito));

                            }
                            else
                            {
                                Personas.Add(new Activo(Nombre, DNI));
                            }

                            Console.WriteLine("\n\n***Usuario Jubilado creado CORRECTAMENTE***\n\n");
                            Console.WriteLine("\n\n***Presione una tecla para continuar***\n\n");
                            Console.ReadKey();
                        }

                    }

                }
                else //Esto ejecuta cuando te encuentra en base de datos. Codigo Principal.
                {
                    dynamic UsuarioActual;

                    if (Personas[int.Parse(index)] is Activo)
                    {
                        UsuarioActual = (Activo)Personas[int.Parse(index)];
                    }
                    else
                    {
                        UsuarioActual = (Jubilado)Personas[int.Parse(index)];
                    }



                }

                Console.Clear();

            } while (true);

        }
    }
}
