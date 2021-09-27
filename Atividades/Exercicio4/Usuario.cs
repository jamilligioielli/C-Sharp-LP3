using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Usuario
    {
        private string nome, sobrenome, senha;
        private Postagem[] postagens = new Postagem[3];

        public Usuario()
        {
            this.nome = "";
            this.sobrenome = "";
            this.senha = "";
            this.postagens = new Postagem[3];
        }


        public string Nome { get => nome; set => nome = value; }
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }

        public string Senha { get => senha; set => senha = value; }

        public Postagem[] Postagens { get => postagens; set=> postagens = value;  }

    }

    //Jamilli Vitória Gioielli - 24/08/2021
}

