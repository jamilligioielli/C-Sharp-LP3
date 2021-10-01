using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratas
{
    class Quadrado : Forma
    {
        private double lado;

        public Quadrado(double lado)
        {
            base.setCor("azul");
            this.lado = lado;
            Console.WriteLine("Área quadrado: " + this.calcularArea());
        }

        public Quadrado(double lado, string cor)
        {
            base.setCor(cor);
            this.lado = lado;
            Console.WriteLine("Area do quadrado: " + this.calcularArea());
        }

        public override double calcularArea()
        {
            return lado * lado;
        }

    }
}
