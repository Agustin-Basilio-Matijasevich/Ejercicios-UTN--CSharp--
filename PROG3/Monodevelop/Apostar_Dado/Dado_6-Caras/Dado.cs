using System;

namespace Dado_6Caras
{
    public static class Dado
    {
        public static int NumAleatorio()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            int num = random.Next(1, 7);
            return num;
        }
    }
}