using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um número natural: ");
            int n = Math.Abs(int.Parse(Console.ReadLine()));

            Console.WriteLine("Estes são os " + n + "  primeiros números naturais ímpares: ");
            for (int i = 0; n>0; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    n--;
                }
            }

        }
    }
}
