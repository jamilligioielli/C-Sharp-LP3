using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a temperatura em graus Celsius? ");

            double ce = double.Parse(Console.ReadLine());

            double fa = ce * (9.0 / 5.0) + 32.0;

            Console.WriteLine("A temperatura em Fahrenheit será: " + fa);
        }
    }
}
