using Lanchonete.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lanchonete.Views
{
    public class MenuView
    {
        private readonly ProdutoService produtoService;

        public MenuView()
        {
            this.produtoService = new ProdutoService();
        }

        public  void ExibirMenu()
        {
            List<Produto> produtos = produtoService.ListarProdutos();

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("|                        CARDAPIO                     |");
            Console.WriteLine("------------------------------------------------------");
            for (int i = 0; i < produtos.Count; i++) {
                Produto p = produtos[i];
                Console.WriteLine("| {0} - {1} - {2}" , i, p.Descricao, p.Preco.ToString("c"));
            }
            Console.WriteLine("------------------------------------------------------");
        }
    }
}
