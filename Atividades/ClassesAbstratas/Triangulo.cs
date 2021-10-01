using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratas
{
    class Triangulo : Forma
    {
        private double altura;
        private double base_;

        public Triangulo(double altura, double base_)
        {
            this.altura = altura;
            this.base_ = base_;
            Console.WriteLine("Área triangulo: " + this.calcularArea());
        }

        public Triangulo(double altura, double base_, string cor)
        {
            base.setCor(cor);
            this.altura = altura;
            this.base_ = base_;
            Console.WriteLine("Area do triangulo: " + this.calcularArea());
        }

        public override double calcularArea()
        {
            return (base_ * altura)/2;
        }
    }
}
