using System;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da base maior: ");
            int bMa = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da base menor: ");
            int bMe = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura: ");
            int h = int.Parse(Console.ReadLine());

            if (bMa > 0 && bMe > 0)
            {

                int area = ((bMe + bMa) * h) / 2;
                Console.WriteLine("A área do trapézio é igual a " +  area);
            }
            else
            {
                Console.WriteLine("Inválido.");
            }
        }
    }
}
