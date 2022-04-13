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

                do //Validacion del DNI
                {
                    bool Bandera1, Bandera2;

                    Console.Write("Ingrese su DNI: ");
                    DNI = Console.ReadLine();

                    Bandera1 = int.TryParse(DNI, out int aux);

                    Bandera2 = (DNI.Length >= 8);

                    if (Bandera1 && Bandera2)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("DNI no Valido\n\n");
                    }

                } while (true);

                //Buscador
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
                        Console.WriteLine("\n\nSi es usted Activo Presione A\nSi es usted Jubilado Presione J\nPresione cualquier otra tecla para CANCELAR");
                        opcion = Console.ReadKey();

                        if (opcion.Key == ConsoleKey.A)
                        {
                            AddActivo(DNI, Personas);

                            Console.WriteLine("\n\n***Usuario Activo creado CORRECTAMENTE***\n\n");
                            Console.Write("Presione una tecla Para continuar...");
                            Console.ReadKey();
                        }
                        else if (opcion.Key == ConsoleKey.J)
                        {
                            AddJubilado(DNI, Personas);

                            Console.WriteLine("\n\n***Usuario Jubilado creado CORRECTAMENTE***\n\n");
                            Console.Write("Presione una tecla Para continuar...");
                            Console.ReadKey();
                        }

                    }

                }
                else //Esto ejecuta cuando te encuentra en base de datos. Menu Principal.
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

                    MenuPUsuario(Personas, ID, int.Parse(index), UsuarioActual);

                    Console.WriteLine("\n\n***Gracias, Vuelva Prontos***\n\n");
                    Console.Write("Presione una tecla Para continuar...");
                    Console.ReadKey();

                }

                Console.Clear();

            } while (true);

        }

        private static void AddActivo(string DNI, List<Persona> Personas)
        {
            string Nombre;

            do
            {
                Console.WriteLine("\n\nIngrese su nombre completo: ");
                Nombre = Console.ReadLine();

                if (!(Nombre.Length < 1))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("El Nombre no puede estar vacio\n\n");
                }

            } while (true);

            Console.WriteLine("\n\n¿Desea realizar un Deposito incial?\nPresione S para SI\nPresione cualquier otra tecla para NO");

            if (Console.ReadKey().Key == ConsoleKey.S)
            {
                decimal Deposito;
                bool Bandera;


                Console.WriteLine("\nIngrese el Deposito: ");

                do
                {
                    Bandera = decimal.TryParse(Console.ReadLine(), out Deposito);

                    if (Bandera && !(Deposito == 0))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Deposito Invalido, reintente\n\n");
                    }

                } while (true);


                Personas.Add(new Activo(Nombre, DNI, Deposito));

            }
            else
            {
                Personas.Add(new Activo(Nombre, DNI));
            }

        }

        private static void AddJubilado(string DNI, List<Persona> Personas)
        {
            string Nombre;

            do
            {
                Console.WriteLine("\n\nIngrese su nombre completo: ");
                Nombre = Console.ReadLine();

                if (!(Nombre.Length < 1))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("El Nombre no puede estar vacio\n\n");
                }

            } while (true);

            Console.WriteLine("\n\n¿Desea realizar un Deposito incial?\nPresione S para SI\nPresione cualquier otra tecla para NO");

            if (Console.ReadKey().Key == ConsoleKey.S)
            {
                decimal Deposito;
                bool Bandera;


                Console.WriteLine("\nIngrese el Deposito: ");

                do
                {
                    Bandera = decimal.TryParse(Console.ReadLine(), out Deposito);

                    if (Bandera && !(Deposito == 0))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Deposito Invalido, reintente\n\n");
                    }

                } while (true);


                Personas.Add(new Jubilado(Nombre, DNI, Deposito));

            }
            else
            {
                Personas.Add(new Jubilado(Nombre, DNI));
            }

        }

        private static void MenuPUsuario(List<Persona> Personas, IDCaj ID, int index, dynamic UsuarioActual)
        {
            bool Bandera = true;

            do
            {
                Console.Clear();
                Console.WriteLine("***Bienvenido a Banco Basilio***\n\n");

                //Bienvenida
                Console.WriteLine($"Es un placer verlo nuevamente señor: {UsuarioActual.GetNombre()}");
                Console.WriteLine($"Saldo: ${UsuarioActual.GetDinero()}");
                Console.WriteLine($"Deudas: ${UsuarioActual.GetDeuda()}");
                if (UsuarioActual is Activo)
                {
                    Console.WriteLine("***Cuenta de Activo***");
                }
                else if (UsuarioActual is Jubilado)
                {
                    Console.WriteLine("***Cuenta de Jubilado***");
                }

                //Menu
                Console.Write("\n\n***Menu Principal***\n\n");
                Console.WriteLine("Presione 1 para Depositar dinero");
                Console.WriteLine("Presione 2 para Retirar dinero");
                Console.WriteLine("Presione 3 para Solicitar un adelanto de sueldo");
                Console.WriteLine("Presione 4 para Saldar todas sus Deudas");
                Console.WriteLine("Presione 5 para Solicitar TODOS los registros de transaccion");
                Console.WriteLine("Presione S para SALIR");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        {
                            break;
                        }

                    case ConsoleKey.NumPad1:
                        {
                            break;
                        }

                    case ConsoleKey.D2:
                        {
                            break;
                        }

                    case ConsoleKey.NumPad2:
                        {
                            break;
                        }

                    case ConsoleKey.D3:
                        {
                            break;
                        }

                    case ConsoleKey.NumPad3:
                        {
                            break;
                        }

                    case ConsoleKey.D4:
                        {
                            break;
                        }

                    case ConsoleKey.NumPad4:
                        {
                            break;
                        }

                    case ConsoleKey.D5:
                        {
                            break;
                        }

                    case ConsoleKey.NumPad5:
                        {
                            break;
                        }

                    case ConsoleKey.S:
                        {
                            Bandera = false;
                            break;
                        }

                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n***Opcion Invalida.\nPresione una tecla para continuar...***\n\n");
                            Console.ReadKey();
                            break;
                        }

                }

            } while (Bandera);
        }

    }
}
