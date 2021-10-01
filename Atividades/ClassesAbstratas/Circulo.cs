using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratas
{
    class Circulo : Forma
    {
        private double pi = 3.1415;
        private double raio;

        public Circulo(double raio)
        {
            this.raio = raio;
            Console.WriteLine("Área circulo: " + this.calcularArea());
        }

        public Circulo(double raio, string cor)
        {
            base.setCor(cor);
            this.raio = raio;
            Console.WriteLine("Área circulo: " + this.calcularArea());
        }

        public override double calcularArea()
        {
            return pi * Math.Pow(raio, 2);
        }
    }
}
