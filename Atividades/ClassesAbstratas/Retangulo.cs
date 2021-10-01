using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratas
{
    class Retangulo : Forma
    {
        private double altura;
        private double largura;

        public Retangulo(double altura, double largura)
        {
            this.altura = altura;
            this.largura = largura;
            Console.WriteLine("Área retangulo: " + this.calcularArea());
        }

        public Retangulo(double altura, double largura, string cor)
        {
            base.setCor(cor);
            this.altura = altura;
            this.largura = largura;
            Console.WriteLine("Area do quadrado: " + this.calcularArea());
        }

        public override double calcularArea()
        {
            return altura * largura;
        }
    }
}
