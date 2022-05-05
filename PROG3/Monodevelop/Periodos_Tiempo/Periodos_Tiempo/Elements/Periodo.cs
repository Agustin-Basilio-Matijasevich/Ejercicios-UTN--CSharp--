using System;

namespace Periodos_Tiempo.Elements
{
    public class Periodo
    {
        private readonly DateTime[] Fechas;
        private readonly String ID;

        public Periodo()
        {

        }

        public Periodo(DateTime Fecha1, DateTime Fecha2, String ID)  //Este constructor carga en la posicion 0 la fecha de inicio y en la posicion 1 la de fin
        {
            if (DateTime.Compare(Fecha1, Fecha2) < 0)
            {
                Fechas = new DateTime[2] { Fecha1, Fecha2 };
            }
            else
            {
                Fechas = new DateTime[2] { Fecha2, Fecha1 };
            }

            this.ID = ID;

        }

        public DateTime GetInicio()
        {
            return Fechas[0];
        }

        public DateTime GetFinal()
        {
            return Fechas[1];
        }

        public TimeSpan GetDuracion()
        {
            return Fechas[1].Subtract(Fechas[0]);
        }

        public String GetID()
        {
            return ID;
        }

        public static bool SeSolapan(Periodo P1, Periodo P2)
        {
            if ((DateTime.Compare(P1.GetFinal(), P2.GetInicio()) < 0) || (DateTime.Compare(P1.GetInicio(), P2.GetFinal()) > 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool Unir_Periodos(Periodo P1, Periodo P2, out Periodo Union)
        {
            if (Periodo.SeSolapan(P1, P2))  //Primero controla si se solapan a ver si se puede unir, si se solapan los une y retorna la union y true
            {
                DateTime aux1, aux2;  //Para guardar las fechas correctas del nuevo periodo union

                if (DateTime.Compare(P1.GetInicio(), P2.GetInicio()) < 0)  //Consigue la fecha de inicio mas vieja y la carga en aux1
                {
                    aux1 = P1.GetInicio();
                }
                else
                {
                    aux1 = P2.GetInicio();
                }

                if (DateTime.Compare(P1.GetFinal(), P2.GetFinal()) < 0)  //Consigue la fecha de fin mas nueva y la carga en aux2
                {
                    aux2 = P2.GetFinal();
                }
                else
                {
                    aux2 = P1.GetFinal();
                }

                Union = new Periodo(aux1, aux2, P1.GetID() + P2.GetID());
                return true;
            }
            else  //Si no se solapan devuelve falso y un periodo vacio
            {
                Union = new Periodo();
                return false;
            }
        }

        public override string ToString()
        {
            if (Fechas == null)
            {
                return "Periodo Vacio";
            }
            else
            {
                return ($"Inicio: {Fechas[0]}, Fin: {Fechas[1]}");
            }

        }

    }
}
