using System;
using System.Collections.Generic;
using System.Text;

namespace Lanchonete.Models
{
    public class Pedido
    {
        public Cliente Cliente { get; set; }
        public List<ItemPedido> Itens { get; set; }
        public Pedido()
        {
            if (this.Itens == null)
            {
                this.Itens = new List<ItemPedido>();
            }
        }
    }
}
