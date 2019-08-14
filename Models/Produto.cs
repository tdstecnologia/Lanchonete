using System;
using System.Collections.Generic;
using System.Text;

namespace Lanchonete.Models
{
    public class Produto
    {
        public string Descricao { get; set; }

        public double Preco { get; set; }

        public Produto()
        {
        }

        public Produto(string descricao, double preco)
        {
            Descricao = descricao;
            Preco = preco;
        }
    }
}
