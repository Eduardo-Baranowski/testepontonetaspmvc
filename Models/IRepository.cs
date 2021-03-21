using System.Linq;

namespace projeto.Models
{
    public interface IRepository
    {
        IQueryable<Produto> Produtos { get; }
    }
    
}