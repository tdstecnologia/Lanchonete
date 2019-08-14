using System;
using System.Collections.Generic;
using System.Text;

namespace Lanchonete.Models
{
    public class ItemPedido
    {
        public Produto Produto { get; set; }

        public int Quantidade { get; set; }
    }
}
