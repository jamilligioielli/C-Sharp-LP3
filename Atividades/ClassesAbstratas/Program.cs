using System;

namespace ClassesAbstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado quad1 = new Quadrado(15.0);
            Quadrado quad2 = new Quadrado(10.0, "vermelho");
            Triangulo trig = new Triangulo(3, 5);
            Circulo circ = new Circulo(5);
            Retangulo ret = new Retangulo(9, 6);
            Console.WriteLine(ret);
        }
    }
}
