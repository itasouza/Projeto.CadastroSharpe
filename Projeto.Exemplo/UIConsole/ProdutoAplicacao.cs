using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIConsole
{
    public class ProdutoAplicacao
    {
        public DBProduto banco { get; set; }


        public ProdutoAplicacao()
        {
            banco = new DBProduto();
        }

        public void salvar(Produto produto)
        {
            banco.produtos.Add(produto);
            banco.SaveChanges();
        }


        public void alterar(Produto produto)
        {
            Produto produtoSelecionado = banco.produtos.Where(x => x.id == produto.id).First();
            produtoSelecionado.Nome = produto.Nome;
            banco.SaveChanges();
               
        }


        public void excluir(int id)
        {
            Produto produtoSelecionado = banco.produtos.Where(x => x.id == id).First();
            banco.Set<Produto>().Remove(produtoSelecionado);
            banco.SaveChanges();
        }


        public IEnumerable<Produto> Listar()
        {
            return banco.produtos.ToList();
        }



    }
}
