using System;

namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0, alg;
            Console.WriteLine("Entre com um número inteiro maior que 0: ");
            int num = int.Parse(Console.ReadLine());
            if (num <=0)
            {
                Console.WriteLine("Número Inválido");
            }
            else { 
            while (num > 0)
            {
                alg = num % 10;
                soma = soma + alg;
                num = num / 10;
                
            }
            Console.WriteLine("A soma dos algarismos deste número é igual a " + soma);
            }
        }
    }
}
