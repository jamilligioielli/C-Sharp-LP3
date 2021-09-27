using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Postagem
    {
       private string titulo, data, conteudo;
       private int visitas;

        public Postagem()
        {
            this.titulo = "";
            this.data = "";
            this.conteudo = "";
            this.visitas = 0;
        }

        public Postagem(string titulo, string data, string conteudo, int visitas)
        {
            this.titulo = titulo;
            this.data = data;
            this.conteudo = conteudo;
            this.visitas = visitas;
        }


        public string Titulo { get => titulo; set => titulo = value; }
        public string Data { get => data; set => data = value; }

        public string Conteudo { get => conteudo; set => conteudo = value; }

        public int Visitas { get => visitas; set => visitas = value; }

        
    }
    //Jamilli Vitória Gioielli - 24/08/2021
}
