using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Cliente
    {
        private string nome;
        private string sobrenome;
        private string cpf;
        private Conta conta;

        public Cliente()
        {
            this.nome = "";
            this.sobrenome = "";
            this.cpf = "";
            this.conta = new Conta();
        }

        public Cliente(string nome, string sobrenome, string cpf, Conta conta)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.cpf = cpf;
            this.conta = conta;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public Conta Conta { get => conta; set => conta = value; }
    }
    //Jamilli Vitória Gioielli - 24/08/2021
}
