using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inferfaces
{
    class Triangulo : IForma
    {
        private double altura;
        private double base_;

        public Triangulo(double altura, double base_)
        {
            this.altura = altura;
            this.base_ = base_;
            Console.WriteLine("Área triangulo: " + this.calcularArea());
        }

        public double calcularArea()
        {
            return (base_ * altura) / 2;
        }
    }
}