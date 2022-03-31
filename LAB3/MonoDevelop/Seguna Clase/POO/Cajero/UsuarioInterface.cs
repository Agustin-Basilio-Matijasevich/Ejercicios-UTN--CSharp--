using System;

namespace Cajero
{
    public interface IUsuario
    {
        bool RetirarDinero(double dinero);
        bool DepositarDinero(double dinero);
    }
}
