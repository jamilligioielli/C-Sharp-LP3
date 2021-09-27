using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hierarquia do Cachorro: ");
            Cachorro cachorro = new Cachorro();
            Console.WriteLine("------------------------");
            Console.WriteLine("Hierarquia do Gato: ");
            Gato gato = new Gato();
            Console.WriteLine("------------------------");
            Console.WriteLine("Hierarquia do Jacaré: ");
            Jacare jacare = new Jacare();
            Console.WriteLine("------------------------");
            Console.WriteLine("Hierarquia do Sapo: ");
            Sapo sapo = new Sapo();
        }
    }
}
