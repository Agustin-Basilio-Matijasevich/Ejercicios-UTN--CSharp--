namespace Cajero.Elements
{
    public interface IPersona
    {
        string GetNombre();
        string GetDNI();
        decimal GetDinero();
        decimal GetDeuda();
        void GetRegistros();
        bool RetirarDinero(decimal Dinero, IDCaj ID);
        bool DepositarDinero(decimal Dinero, IDCaj ID);
        bool SaldarDeuda(decimal Dinero, IDCaj ID);

    }

}