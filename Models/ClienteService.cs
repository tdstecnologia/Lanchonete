using System;
using System.Collections.Generic;
using System.Text;

namespace Lanchonete.Models
{
    public class ClienteService
    {
        public void RegistrarCliente(Pedido pedido)
        {
            Console.Write("Nome Cliente: ");
            Cliente c = new Cliente();
            c.Nome = Console.ReadLine();
            pedido.Cliente = c;
        }
    }
}
