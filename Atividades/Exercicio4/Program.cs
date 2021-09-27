using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
    {

        Postagem p1 = new Postagem("postagem 1", "02/05/2021", "Olá amigo", 1);
        Postagem p2 = new Postagem("postagem 2", "06/05/2021", "Olá amigo, tudo bem?", 4);
        Postagem p3 = new Postagem("postagem 3", "07/08/2021", "Olá amigo, tudo bem? Me responda", 3);

        Usuario u = new Usuario();
        u.Nome = "Joao"; u.Sobrenome = " Da Silva"; u.Senha = "123456";
        u.Postagens[0] = p1;
        u.Postagens[1] = p2;
        u.Postagens[2] = p3;

        Console.WriteLine("Dados do usuário: ");
        Console.WriteLine("Nome: " + u.Nome + u.Sobrenome + " - Senha: " + u.Senha);
        Console.WriteLine("Postagens: ");
        for(int i =0; i<3; i++)
            Console.WriteLine("Titulo: "+ u.Postagens[i].Titulo + "- Data: "+ u.Postagens[i].Data 
                + " - Conteudo: " + u.Postagens[i].Conteudo + " - Visitas: " + u.Postagens[i].Visitas);
    }
    }

    //Jamilli Vitória Gioielli - 24/08/2021
}
