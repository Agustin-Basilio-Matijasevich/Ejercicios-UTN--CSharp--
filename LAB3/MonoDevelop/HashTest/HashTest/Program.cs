using System;
using System.Security.Cryptography;
using System.Text;

namespace HashTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un texto");
            String T1 = Console.ReadLine();
            Console.Write("El HASH del Texto es: ");
            String H1 = BitConverter.ToString(SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(T1))).Replace("-", string.Empty);
            Console.WriteLine(H1);

            Console.WriteLine("Ingrese un texto");
            String T2 = Console.ReadLine();
            Console.Write("El HASH del Texto es: ");
            String H2 = BitConverter.ToString(SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(T2))).Replace("-", string.Empty);
            Console.WriteLine(H2);

            Console.WriteLine($"\n\n¿Los HASH son iguales?: {H1.Equals(H2)}");

        }
    }
}
