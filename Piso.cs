using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria
{
   public class Piso : Inmueble
    {
        private int NumeroPiso;

        public int NumeroPiso1 { get => NumeroPiso; set => NumeroPiso = value; }

        override public double CalcularPrecio
        {
            get
            {
                double PrecioFinal = 0;
                if (Antiguedad1 < 15)
                {
                    PrecioFinal = PrecioFinal + PrecioBase1 - PrecioBase1 * 0.01;
                }

                if (Antiguedad1 > 15)
                {
                    PrecioFinal = PrecioFinal + PrecioBase1 - PrecioBase1 * 0.02;
                }

                if (NumeroPiso1 >= 3)
                {
                    PrecioFinal = PrecioFinal + PrecioBase1 + PrecioBase1 * 0.01;
                }

                return PrecioFinal;
            }
        }
    }

}