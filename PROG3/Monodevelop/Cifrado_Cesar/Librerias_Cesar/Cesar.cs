using System;
using System.Linq;

namespace Librerias_Cesar
{
    public static class Cesar
    {
        public static String Descifrar(String FraseIn, int Clave)
        {
            //Variables
            String FraseOut = "";  //String Vacio
            Char[] aux = FraseIn.ToLower().ToCharArray();  //Frase pasa a minuscula y a array de char

            foreach (char Caracter in aux)  //Recorro la frase caracter por caracter
            {
                if (Constantes.CaracteresCifrar.Contains(Caracter))  //Si el caracter esta dentro de la base cifrable se descifra
                {
                    FraseOut += (Move(Caracter, Clave, 1));
                }
                else  //Si no simplemente se pasa el caracter asi como esta
                {
                    FraseOut += Caracter;
                }
            }

            return FraseOut;
        }

        public static String Cifrar(String FraseIn, int Clave)
        {
            //Variables
            String FraseOut = "";  //String Vacio
            Char[] aux = FraseIn.ToLower().ToCharArray();  //Frase pasa a minuscula y a array de char

            foreach (char Caracter in aux)  //Recorro la frase caracter por caracter
            {
                if (Constantes.CaracteresCifrar.Contains(Caracter))  //Si el caracter esta dentro de la base cifrable se cifra
                {
                    FraseOut += (Move(Caracter, Clave, 2));
                }
                else  //Si no simplemente se pasa el caracter asi como esta
                {
                    FraseOut += Caracter;
                }
            }

            return FraseOut;
        }

        /*
         * Recibe un caracter, una clave y un parametro para descifrar o cifrar el caracter eligiendo el reemplazo en la base
         * El Parametro decide si cifra o descifra        
        */
        private static char Move(char Caracter, int Clave, int Param)
        {
            int index = Constantes.CaracteresCifrar.IndexOf(Caracter); //Busca el index del caracter en la base

            if (Param == 1)  //Descifra
            {
                for (int i = 0; i < Clave; i++)  //Ejecuta la cantidad de veces que la clave indique para avanzar en la base esa cantidad de veces
                {
                    if (index == Constantes.CaracteresCifrar.Length - 1)  //Si estamos en el final de la base volvemos al principio
                    {
                        index = 0;
                    }
                    else  //Si no avanzamos
                    {
                        index++;
                    }
                }
            }
            else if (Param == 2)  //Cifra
            {
                for (int i = 0; i < Clave; i++)  //Ejecuta la cantidad de veces que la clave indique para retroceder en la base esa cantidad de veces
                {
                    if (index == 0)  //Si estamos en el comienzo de la base volvemos al final
                    {
                        index = Constantes.CaracteresCifrar.Length - 1;
                    }
                    else  //Si no Retrocedemos
                    {
                        index--;
                    }
                }
            }

            return Constantes.CaracteresCifrar.ToCharArray()[index];

        }

    }
}
