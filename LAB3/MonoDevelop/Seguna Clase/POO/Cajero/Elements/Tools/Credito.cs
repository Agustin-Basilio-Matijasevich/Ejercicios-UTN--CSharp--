using System;
using System.Collections.Generic;

namespace Cajero.Elements
{
    public static class Credito
    {
        public static bool Puedo(List<RegOP> Registros)
        {
            RegOP[] regs = Registros.ToArray();
            DateTime date = DateTime.Now;
            TimeSpan Referencia = new TimeSpan(62, 0, 0, 0);
            TimeSpan Diferencia;
            bool Bandera1 = false, Bandera2 = false;

            for (int i = regs.Length - 1; i >= 0; i--)
            {
                Diferencia = date - regs[i].GetFecha();

                if (Diferencia < Referencia)
                {
                    if (regs[i].GetDeuda() == 0)
                    {
                        if (regs[i].GetDinero() > 20000)
                        {
                            Bandera1 = true;
                        }
                        else
                        {
                            Bandera1 = false;
                            break;
                        }

                    }
                    else
                    {
                        Bandera1 = false;
                        break;
                    }

                }
                else if (i == regs.Length -1)
                {
                    if (regs[i].GetDeuda() == 0)
                    {
                        if (regs[i].GetDinero() > 20000)
                        {
                            Bandera1 = true;
                        }
                        else
                        {
                            Bandera1 = false;
                            break;
                        }

                    }
                    else
                    {
                        Bandera1 = false;
                        break;
                    }

                }
                else
                {
                    Bandera2 = true;
                    break;
                }

            }

            if (Bandera1 == true && Bandera2 == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
