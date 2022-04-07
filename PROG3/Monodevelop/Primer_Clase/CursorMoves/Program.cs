using System;
using System.Threading;

namespace CursorMoves
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int i=0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.SetCursorPosition(i*2, i);
            }
            Console.ReadKey();
        }
    }
}
