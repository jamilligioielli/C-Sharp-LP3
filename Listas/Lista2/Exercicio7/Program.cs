using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o salário do trabalhador: ");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor da prestação do empréstimo: ");
            double prestacao = double.Parse(Console.ReadLine());

            double limite = 0.2 * salario;
            if (prestacao > limite)
            {
                Console.WriteLine("Empréstimo não concedio. ");
            } else
            {
                Console.WriteLine("Empréstimo concedio. ");
            }
        }
    }
}
