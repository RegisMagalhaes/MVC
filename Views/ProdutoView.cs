using System;
using System.Collections.Generic;
using MVC_Console.Models;

namespace MVC_Console.Views
{
    public class ProdutoView
    {
        public void Listar(List<Produto> produtos)
        {

            foreach (var item in produtos)
            {
                Console.WriteLine($"Código : {item.Codigo}");
                Console.WriteLine($"Produto : {item.Nome}");
                Console.WriteLine($"Preço : {item.Preco}");
                Console.WriteLine();
                
                
            }

        }

         public Produto CadastrarProduto()
            {
                Produto produto = new Produto();

                Console.WriteLine("Digite um Código: ");
                produto.Codigo = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Digite um Nome: ");
                produto.Nome = Console.ReadLine();

                Console.WriteLine("Digite um Preço: ");
                produto.Preco = float.Parse(Console.ReadLine());

                return produto;
                
            }
    }


}