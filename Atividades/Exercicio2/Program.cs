using System;
using System.Collections.Generic;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta cont1 = new Conta("5555", 123456, 971);
            Conta cont2 = new Conta("6666", 654321, 9050);
            Conta cont3 = new Conta("7777", 789456, 650);

            Cliente cl1 = new Cliente("Jamilli", "Gioielli", "12345678910", cont1);
            Cliente cl2 = new Cliente("Kaiky", "Silva", "10987654321", cont3);
            Cliente cl3 = new Cliente("Ivonete", "Gomes", "12789456321", cont2);


            List<Cliente> listaClientes = new List<Cliente>();
            listaClientes.Add(cl1); listaClientes.Add(cl2); listaClientes.Add(cl3);

            foreach(Cliente x in listaClientes)
            {
                Console.WriteLine("Dados do cliente: ");
                Console.WriteLine("Nome: " + x.Nome + " " +  x.Sobrenome + " - CPF: "+ x.Cpf);
                Console.WriteLine("   ");
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine("Agencia " + x.Conta.Agencia + " - Numero: " + x.Conta.Numero + " - Saldo: R$" + x.Conta.Saldo);
                Console.WriteLine("--------------------------------------------------------------------");
            }


        }
    }
    //Jamilli Vitória Gioielli - 24/08/2021
}
