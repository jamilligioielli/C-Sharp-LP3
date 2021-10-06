using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inferfaces
{
    class Retangulo : IForma
    {
        private double altura;
        private double largura;

        public Retangulo(double altura, double largura)
        {
            this.altura = altura;
            this.largura = largura;
            Console.WriteLine("Área retangulo: " + this.calcularArea());
        }


        public double calcularArea()
        {
            return altura * largura;
        }
    }
}
