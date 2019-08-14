using System;
using System.Collections.Generic;
using System.Text;

namespace Lanchonete.Models
{
    public class ProdutoService
    {
        private readonly ProdutoRepository repository;

        public ProdutoService()
        {
            this.repository = new ProdutoRepository();
        }

        public List<Produto> ListarProdutos()
        {
            return this.repository.Produtos;
        }
    }
}
