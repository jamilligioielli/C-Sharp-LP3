using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um número inteiro positivo: ");
            int n = Math.Abs(int.Parse(Console.ReadLine()));

            Console.WriteLine("Estes são os " + n + "  primeiros números inteiros positivos pares: ");
            for (int i = 0; i<n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    n++;
                }
            }
        }
    }
}
