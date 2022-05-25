using System;

namespace Simon {
    static class Aleatorio {
        public static int metodoAl() {
            Random al = new Random(DateTime.Now.Millisecond);
            return al.Next(1, 5);
        }
    }
}
