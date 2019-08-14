using Lanchonete.Models;
using Lanchonete.Views;
using System;

namespace Lanchonete
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuView menu = new MenuView();
            menu.ExibirMenu();

            Pedido pedido = new Pedido();

            ClienteService clienteService = new ClienteService();
            clienteService.RegistrarCliente(pedido);

            PedidoService pedidoService = new PedidoService();
            pedidoService.RegistrarItensDoPedido(pedido);

            double total = pedidoService.CalcularTotalPedido(pedido);

            Console.WriteLine("Total: " + total);

            PedidoView.ResumoPedido(pedido);

        }
    }
}
