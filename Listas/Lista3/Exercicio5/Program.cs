using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i < num; i++)
            {
                if (i % 11 == 0 && i != 11)
                {
                    Console.WriteLine(i + " é o primeiro múltiplo de 11");
                    break;
                } 
            }
            for (int i = 1; i < num; i++)
            {
                if (i % 13 == 0 && i!= 13)
                {
                    Console.WriteLine(i + " é o primeiro múltiplo de 13");
                    break;
                }
            }
            for (int i = 1; i < num; i++)
            {
                if (i % 17 == 0 && i != 17)
                {
                    Console.WriteLine(i + " é o primeiro múltiplo de 17");
                    break;
                }
            }
        }
    }
}
