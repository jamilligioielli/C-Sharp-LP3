using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            //utilizando for
            Console.WriteLine("Utilizando for");
            for (i=1; i<=100; i++)
            {
                Console.Write("  " + i);
            }

            //utilizando o while
            Console.WriteLine("  ");
            Console.WriteLine("Utilizando while");
            i = 1;
            while (i <= 100)
            {
                Console.Write("  " + i);
                i++;
            }

            //utilizando do while
            Console.WriteLine("  ");
            Console.WriteLine("Utilizando do while");
            i = 1;
            do
            {
                Console.Write("  "+ i);
                i++;
            } while (i <= 100);
            
        }
    }
}
