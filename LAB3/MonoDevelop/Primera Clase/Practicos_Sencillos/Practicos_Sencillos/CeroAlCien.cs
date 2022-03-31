using System;

namespace CeroAlCien
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--A continuacion se muestran los numeros del 1 al 100--");

            for (int i = 1; i <= 100; i++)
            {
                if (i==100)
                {
                    Console.Write("{0}.", i);

                }
                else
                {

                    Console.Write("{0}, ", i);

                }

            }

        }

    }

}
