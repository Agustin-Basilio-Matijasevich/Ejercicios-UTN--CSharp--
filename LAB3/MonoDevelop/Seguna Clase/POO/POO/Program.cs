using System;

namespace POO
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Pato p = new Pato("negro", "5", "Lucas");

            p.Mostrar();

            p.Telefono = "43146475";
            Console.WriteLine(p.Telefono);

        }

    }

}
