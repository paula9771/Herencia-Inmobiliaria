using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria
{
    public class Local : Inmueble
    {
        private int CantVentanas;

        public int CantVentanas1 { get => CantVentanas; set => CantVentanas = value; }
        override public double CalcularPrecio
        {
            get
            {
                double PrecioFinal = 0;
                if (Superficie1 > 50)
                {
                    PrecioFinal = PrecioFinal + PrecioBase1 * 1.01;
                }

                if (CantVentanas1 <= 1)
                {
                    PrecioFinal = PrecioFinal + PrecioBase1 - PrecioBase1 * 0.02;
                }

                if (CantVentanas1 > 4)
                {
                    PrecioFinal = PrecioFinal + PrecioBase1 * 1.02;
                }
                return PrecioFinal;
            }
        }
    }
}
