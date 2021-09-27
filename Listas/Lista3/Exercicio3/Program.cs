using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, soma=0;
            Console.WriteLine("Entre com 10 números: ");

            for (int i=0; i<10;i++)
            {
                x = int.Parse(Console.ReadLine());
                soma = soma + x;
            }
            Console.WriteLine("A soma de todos os números digitados é igual a "+ soma);
        }
    }
}
