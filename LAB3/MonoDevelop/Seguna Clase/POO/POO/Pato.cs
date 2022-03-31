using System;

namespace POO
{
    public class Pato : SerVivo
    {
        private readonly string Color;
        private readonly string Peso;
        private readonly string Nombre;
        private string telefono;

        public Pato(string color, string peso, string nombre)
        {
            this.Color = color;
            this.Peso = peso;
            this.Nombre = nombre;

        }

        public string Telefono   //Esto es una propiedad y sirve para implementar geters y seters mas facilmente, tambien se puede usar como atributo
        {
            set
            {
                telefono = value;
            }

            get
            {
                return telefono;
            }

        }

        public void Mostrar()
        {
            Console.WriteLine("El pato es {0}, se llama {1} y tiene {2}KG", Color, Nombre, Peso);
        }

    }

}
