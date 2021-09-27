using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double raiz = 0, exp = 0;
            Console.WriteLine("Entre com um número inteiro: ");
            int x = int.Parse(Console.ReadLine());

            if (x > 0)
            {
                exp = Math.Pow(x, 2);
                Console.WriteLine(x + " ao quadrado é igual a: " + exp);
                raiz = Math.Sqrt(x);
                Console.WriteLine("A raiz quadrada de " + x  +" é aprox. : "  + Math.Round(raiz, 2));
            }
            else
            {
                Console.WriteLine("As operações não são possíveis com números negativos :/ ");
            }
        }
    }
}
