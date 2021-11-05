using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria
{
    public class Inmueble
    {
        //Atributos
        private string Direccion;
        private double Superficie;
        private int Antiguedad;
        private double PrecioBase;

        //Encapsulamiento de atributos

        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public double Superficie1 { get => Superficie; set => Superficie = value; }
        public int Antiguedad1 { get => Antiguedad; set => Antiguedad = value; }
        public double PrecioBase1 { get => PrecioBase; set => PrecioBase = value; }

        //Métodos
       
        public virtual double CalcularPrecio { get; }
    }
}
