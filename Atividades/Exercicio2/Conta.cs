using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Conta
    {
        private string agencia;
        private int numero;
        private float saldo;

        public Conta()
        {
            this.agencia = "";
            this.numero = 0;
            this.saldo = 0;
        }

        public Conta(string agencia, int numero, float saldo)
        {
            this.agencia = agencia;
            this.numero = numero;
            this.saldo = saldo;
        }

        public string Agencia { get => agencia; set => agencia = value; }
        public int Numero { get => numero; set => numero = value; }
        public float Saldo { get => saldo; set => saldo = value; }
    }

    //Jamilli Vitória Gioielli - 24/08/2021
}
