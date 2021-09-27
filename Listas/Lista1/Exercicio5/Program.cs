using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número real: ");

            double j = double.Parse(Console.ReadLine());

            double qtapart = j * 1 / 5;

            Console.WriteLine("A quinta parte de " + j + " é: " + qtapart);
        }
    }
}
