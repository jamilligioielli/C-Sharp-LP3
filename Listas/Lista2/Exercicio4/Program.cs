using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com dois números inteiros: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int diferenca = Math.Abs(x-y);

            if (x == y)
            {
                Console.WriteLine("São números iguais");
            }
            else if (x > y)
            {
                Console.WriteLine( x + " é o maior número");
                Console.WriteLine("A diferença entre eles é igual a " + diferenca);
            }
            else
            {
                Console.WriteLine(y + " é o maior número");
                Console.WriteLine("A diferença entre eles  é igual a " + diferenca);
            }

        }
    }
}
