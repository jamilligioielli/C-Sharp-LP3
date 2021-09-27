using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com dois números: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if (x == y)
            {
                Console.WriteLine("São números iguais");
            }
            else if (x > y)
            {
                Console.WriteLine("O primeiro (" + x + ") é maior que o segundo ( " + y + " )");
            }
            else
            {
                Console.WriteLine("O segundo (" + y + ") é maior que o primeiro (" + x + ")");
            }

        }
    }
}