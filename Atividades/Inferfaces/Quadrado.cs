using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inferfaces
{
    class Quadrado : IForma
    {
        private double lado;

        public Quadrado(double lado)
        {
            this.lado = lado;
            Console.WriteLine("Área quadrado: " + this.calcularArea());
        }


        public double calcularArea()
        {
            return lado * lado;
        }

    }
}
