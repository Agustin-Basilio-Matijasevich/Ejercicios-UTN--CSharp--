using System;

namespace Interfaces
{
    public class Libro : IComparable, IColeccionable
    {
        //Campos
        private string autor, titulo;

        //Propiedades
        public String Autor
        {
            get
            {
                return this.autor;
            }
            set
            {
                if (value.Length > 0)
                {
                    this.autor = value;
                }
                else
                {
                    this.autor = "NO NAME";
                }
            }
        }
        public String Titulo { get; set; }

        //Metodos
        public Libro(String Autor, String Titulo)
        {
            this.Autor = Autor;
            this.Titulo = Titulo;
        }

        public void CompareTo()
        {

        }

        public void Describir()
        {

        }

    }
}
