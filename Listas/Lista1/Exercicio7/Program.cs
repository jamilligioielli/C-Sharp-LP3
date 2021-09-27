using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a temperatura em graus Fahrenheit? ");

            double fa = double.Parse(Console.ReadLine());

            double ce = 5.0 * (fa - 32.0) / 9.0;

            Console.WriteLine("A temperatura em Celcius será: " + ce);
        }
    }
}
