using System;

namespace Inferfaces
{
    class Program
    {

        static void Main(string[] args)
        {
            IForma forma = new Quadrado(10.0);

            IForma forma2 = new Retangulo(10.0, 5.0);

            IForma forma3 = new Triangulo(20.0, 25.0);

            IForma forma4 = new Circulo(4);
            
        }
    }
}
