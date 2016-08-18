using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            ProdutoAplicacao app = new ProdutoAplicacao();


            //salvar
           // Produto produto01 = new Produto();
           // produto01.Nome = "Feijão";
           // app.salvar(produto01);


            //alterar
           // Produto produto01 = new Produto();
          //  produto01.id = 2;
           // produto01.Nome = "Feijão Preto";
           // app.alterar(produto01);


            //excluir
           // Produto produto01 = new Produto();
           // produto01.id = 2;
            //produto01.Nome = "Feijão Preto";
           // app.excluir(2);



            foreach (var produtoNalista in app.Listar())
            {
                Console.WriteLine("{0} - {1}" , produtoNalista.id, produtoNalista.Nome);
            }


            Console.ReadKey();

        }
    }
}
