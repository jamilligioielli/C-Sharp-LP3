using System;

namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o primeiro valor: ");
            int a = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine("Entre com o segundo valor: ");
            int b = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine("Entre com o terceiro valor: ");
            int c = Math.Abs(int.Parse(Console.ReadLine()));

            if (a < (b+c) && b < (c+a) && c < (a + b))
            {
                if (a==b && b == c)
                {
                    Console.WriteLine("É um triângulo equilátero.");
                }

                if ( ((a==b || a == c) && b!=c)  || (b == c && c!=a))
                {
                    Console.WriteLine("É um triângulo isósceles.");
                }
                if (a!=b && a!=c && b != c)
                {
                    Console.WriteLine("É um triângulo escaleno.");
                }
            }
            else
            {
                Console.WriteLine("Não é um triângulo.");
            }


        }
    }
}
