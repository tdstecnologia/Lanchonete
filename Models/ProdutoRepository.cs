using System;
using System.Collections.Generic;
using System.Text;

namespace Lanchonete.Models
{
    public class ProdutoRepository
    {
        public List<Produto> Produtos { get; set; }
        public ProdutoRepository()
        {
            InicializarListaDeProdutos();
        }

        private void InicializarListaDeProdutos()
        {
            if (this.Produtos == null)
            {
                this.Produtos = new List<Produto>();
            }
            this.Produtos.Add(new Produto("Refrigerante", 3.95));
            this.Produtos.Add(new Produto("Sanduíche", 14.90));
            this.Produtos.Add(new Produto("Sorvete",2.50));
        }
        
    }
}
