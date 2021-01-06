using System.Collections.Generic;
using MVC_Console.Models;
using MVC_Console.Views;

namespace MVC_Console.Controller
{
    public class ProdutoController
    {
        // Models
        Produto produto = new Produto();

        // Views

        ProdutoView produtoView = new ProdutoView();

        public void ListarProdutos(){


            List<Produto> produtos = produto.Ler();


            produtoView.Listar(produtos);

        }
    }
}