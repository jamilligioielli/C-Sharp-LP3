using System;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a nota do trabalho: ");
            double trab = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a nota da Avaliação Semestral: ");
            double provaSmtrl = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a nota do Exame Final: ");
            double provaFinal = double.Parse(Console.ReadLine());

            if ((trab >= 0.0 && trab <= 10.0) && (provaSmtrl >= 0.0 && provaSmtrl <= 10.0) && (provaFinal >= 0.0 && provaFinal <= 10.0))
            {
                double media = ((trab * 2) + (provaSmtrl * 3) + (provaFinal * 5)) / 10;
                Console.WriteLine("Media do aluno  = " + Math.Round(media,2));

                if (media >= 5.0 && media <= 10.0)
                {
                    Console.WriteLine("O aluno foi aprovado.");
                }
                else if (media >= 3.0 && media <= 4.9)
                {
                    Console.WriteLine("O aluno está de recuperação.");
                }
                else if (media >= 0.0 && media <= 2.9)
                {
                    Console.WriteLine("O aluno foi reprovado.");
                }
            }
            else
            {
                Console.WriteLine("Notas inválidas.");
            }
        }
    }
}
