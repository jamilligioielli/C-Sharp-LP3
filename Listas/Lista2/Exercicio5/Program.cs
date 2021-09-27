using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com dois números: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if (x == y)
            {
                Console.WriteLine("Os números são iguais.");
            }
            else if (x > y)
            {
                Console.WriteLine( x + " é o maior número");
            }
            else
            {
                Console.WriteLine(y + " é o maior número");
            }
        }
    }
}
