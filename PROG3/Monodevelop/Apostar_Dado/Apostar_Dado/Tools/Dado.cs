using System;

namespace Apostar_Dado
{
    public static class Dado
    {
        public static int NumAleatorio()
        {
            Random random = new Random();
            int num = random.Next(1, 6);
            return num;
        }
    }
}
