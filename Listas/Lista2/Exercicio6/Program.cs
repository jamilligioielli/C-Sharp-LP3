using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as duas notas: ");
            double nota1 = double.Parse(Console.ReadLine());
            double nota2 = double.Parse(Console.ReadLine());
            double media = Math.Round(((nota1 + nota2) / 2), 2); 
            if ((nota1 >= 0.0 && nota1 <= 10.0) && (nota2 >= 0.0 && nota2 <= 10.0))
            {
                Console.WriteLine("A média do aluno é: " + media);
            }
            else
            {
                Console.WriteLine("Notas inválidas.");
            }
        }
    }
}
