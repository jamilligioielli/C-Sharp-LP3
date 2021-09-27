using System;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um número inteiro entre 1 e 7: ");
            int dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Este dia é: ");

            if (dia>=1 && dia <=7)
            switch (dia)
            {
                case 1: 
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda-Feira");
                    break;
                case 3:
                    Console.WriteLine("Terça-Feira");
                    break;
                case 4:
                    Console.WriteLine("Quarta-Feira");
                    break;
                case 5:
                    Console.WriteLine("Quinta-Feira");
                    break;
                case 6:
                    Console.WriteLine("Sexta-Feira");
                    break;
                case 7:
                    Console.WriteLine("Sábado");
                    break;
            }
        }
    }
}
