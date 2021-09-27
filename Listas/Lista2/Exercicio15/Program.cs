using System;

namespace Exercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com seu tempo de serviço: ");
            int tmpServ = int.Parse(Console.ReadLine());

            if ((idade >= 65 || tmpServ >=30) || (idade>=60 && tmpServ>=25))
            {
                Console.WriteLine("Você já pode se aposentar.");
            }
            else
            {
                Console.WriteLine("Você ainda não pode se aposentar.");
            }
        }
    }
}
