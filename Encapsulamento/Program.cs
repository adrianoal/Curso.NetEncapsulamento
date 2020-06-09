using System;
using System.Globalization;

namespace ConstruturesAula51
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            //Exemplo negativo

            //p.Quantidade = - 10; // Sem encapsular o programador pode fazer isso aqui. Erro!

            /*Um programa seguro, so permite q isso aconteca atraves de uma operacao de adicionar 
               e remover produto   
            */


            // Alterar o nome atraves do método SetNome:

            p.SetNome("TV 4K");
            Console.WriteLine(p.GetNome());
            Console.WriteLine();

            Console.WriteLine(p.GetPreco());
            Console.WriteLine();

            Console.WriteLine(p.GetQuantidade());
            Console.WriteLine();



        }
    }
}