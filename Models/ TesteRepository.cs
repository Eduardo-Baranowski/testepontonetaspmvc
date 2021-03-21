using System;

using System.Linq;

namespace projeto.Models
{
    public class TesteRepository : IRepository
    {
        private static Produto[] Dados = new Produto[] {
            new Produto {ProdutoId=10, Nome="Caneta", Categoria="Escolar", Preco=100},
        };
        public IQueryable<Produto> Produtos => Dados.AsQueryable();
    }

    
}