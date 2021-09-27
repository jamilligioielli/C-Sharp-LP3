using System;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperatura em Kelvin: ");

            float k = float.Parse(Console.ReadLine());

            float ce = k - 273.15;

            Console.WriteLine("A temperatura em Celsuis será: " + ce);
        }
    }
}
