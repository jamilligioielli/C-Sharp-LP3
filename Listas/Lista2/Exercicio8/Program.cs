using System;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua altura (em metros): ");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu sexo (H para Homem ou M para Mulher): ");
            string sexo = Console.ReadLine().ToLower();
            double pesoIdeal = 0;
            if (sexo.Equals("h") || sexo.Equals("homem"))
            {
                pesoIdeal = Math.Abs((72.7 * altura) - 58);
                Console.WriteLine(Math.Round(pesoIdeal,2) + " é seu peso ideal. ");

            } else if(sexo.Equals("m") || sexo.Equals("mulher"))
            {
                pesoIdeal = Math.Abs((62.1 * altura)- 44.7);
                Console.WriteLine(Math.Round(pesoIdeal,2) + " é seu peso ideal. ");
            }
            else
            {
                Console.WriteLine("Operação inválida.");
            }
        }
    }
}
