using System;

namespace Apostar_Dado.Tools
{
    public static class Dado
    {
        public static int NumAleatorio()
        {
            Random random = new Random();
            int num = random.Next(1, 7);
            return num;
        }
    }
}
