using System;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a nota da prova 1: ");
            double prova1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a nota da prova 2: ");
            double prova2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a nota da prova 3: ");
            double prova3 = double.Parse(Console.ReadLine());

            if ((prova1 >= 0.0 && prova1 <= 10.0) && (prova2 >= 0.0 && prova2 <= 10.0) && (prova3 >= 0.0 && prova3 <= 10.0))
            {
                double media = (((prova1 * 1) + (prova2 * 1) + (prova3 * 2)) / 4) * 10;

                if (media >= 60)
                {
                    Console.WriteLine("O aluno foi aprovado. ");
                }
                else
                {
                    Console.WriteLine("O aluno foi reprovado. ");
                }
            }
            else
            {
                Console.WriteLine("Notas inválidas.");
            }
        }
    }
}
