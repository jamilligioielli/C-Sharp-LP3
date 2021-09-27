using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine(num + " é um número par.");
            }
            else
            {
                Console.WriteLine(num + " é um número ímpar.");
            }
        }
    }
}
