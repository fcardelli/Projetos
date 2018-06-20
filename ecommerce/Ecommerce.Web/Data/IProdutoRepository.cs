using System.Collections.Generic;
using Ecommerce.Web.Models;

namespace Ecommerce.Web.Data
{
    public interface IProdutoRepository
    {
        List<Produto> ListarProdutos();
    }
}