namespace Cajero.Elements
{
    public class IDCaj
    {
        private readonly string Direccion;
        private readonly string Numero;

        public IDCaj(string Direccion, string Numero)
        {
            this.Direccion = Direccion;
            this.Numero = Numero;
        }

        public override string ToString()
        {
            return ($"Numero de Cajero: {Numero} / Direccion de Cajero: {Direccion}");
        }

    }
}
