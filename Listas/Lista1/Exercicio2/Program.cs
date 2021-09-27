using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um número real: ");
            float dec = float.Parse(Console.ReadLine());

            Console.WriteLine("Você digitou este número-> " + dec);
        }
    }
}
