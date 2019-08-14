using System;
using System.Collections.Generic;
using System.Text;

namespace Lanchonete.Models
{
    public class PedidoService
    {

        private readonly ProdutoService produtoService;

        public PedidoService()
        {
            this.produtoService = new ProdutoService();
        }

        public void RegistrarItensDoPedido(Pedido pedido)
        {
            List<Produto> produtos = produtoService.ListarProdutos();

            string opcao = "";

            do
            {
                ItemPedido item = new ItemPedido();
                item.Produto = LerProduto(produtos);
                item.Quantidade = LerQuantidade();
                pedido.Itens.Add(item);

                Console.Write("Continuar: ");
                opcao = Console.ReadLine();
            } while (opcao.Equals("sim"));
        }

        public double CalcularTotalPedido(Pedido pedido)
        {
            double total = 0.0;
            foreach (ItemPedido item in pedido.Itens)
            {
                total += (item.Produto.Preco * item.Quantidade);
            }
            return total;
        }


        public static Produto LerProduto(List<Produto> produtos)
        {
            Produto produto = null;
            do
            {
                try
                {
                    Console.Write("Código do produto: ");
                    int codigo = Convert.ToInt16(Console.ReadLine());
                    produto = produtos[codigo];
                }
                catch (Exception e)
                {
                    Console.WriteLine("Código inválido...");
                }

            } while (produto == null);

            return produto;
        }

        public static int LerQuantidade()
        {
            int Quantidade = -1;
            do
            {
                try
                {
                    Console.Write("Quantidade: ");
                    Quantidade = Convert.ToInt16(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Quantidade inválida...");
                    Quantidade = -1;
                }
            } while (Quantidade <= 0);
            return Quantidade;
        }
    }
}
