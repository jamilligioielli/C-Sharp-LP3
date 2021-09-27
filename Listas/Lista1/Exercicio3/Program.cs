using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Digite 3 números inteiros: ");

			int x = int.Parse(Console.ReadLine());
			int y = int.Parse(Console.ReadLine());
			int z = int.Parse(Console.ReadLine());

			int total = x + y + z;

			Console.WriteLine("A soma dos números: " + total);
		}
    }
}
