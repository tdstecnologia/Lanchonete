using Lanchonete.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lanchonete.Views
{
    public class PedidoView
    {
        public static void ResumoPedido(Pedido pedido)
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("|                    Resumo Pedido                   |");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("| Cliente:  {0}", pedido.Cliente.Nome);
            Console.WriteLine("------------------------------------------------------");
            ListarItensDoPedido(pedido);
            double total = new PedidoService().CalcularTotalPedido(pedido);
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("|Total compra:                             {0}", total.ToString("c"));
            Console.WriteLine("------------------------------------------------------");
        }


        private static void ListarItensDoPedido(Pedido pedido)
        {
            for (int i = 0; i < pedido.Itens.Count ; i++)
            {
                Produto p = pedido.Itens[i].Produto;
                int Quantidade = pedido.Itens[i].Quantidade;
                double subTotal = p.Preco * Quantidade;
                Console.WriteLine("| {0}  -  {1}  -  {2}  -  {3}  -  {4}", i, pedido.Itens[i].Produto.Descricao, Quantidade, p.Preco, subTotal.ToString("c"));
            }
        }

    }
}
