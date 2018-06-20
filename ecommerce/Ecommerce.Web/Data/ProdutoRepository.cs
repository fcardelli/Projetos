using System.Collections.Generic;
using System.Linq;
using Ecommerce.Web.Models;

namespace Ecommerce.Web.Data
{
    public class ProdutoRepository
    {
        private readonly EcommerceWebContext _ecommerceWebContext;

        public ProdutoRepository(EcommerceWebContext ecommerceWebContext)
        {
            _ecommerceWebContext = ecommerceWebContext;
        }

        public List<Produto> ListarProdutos()
        {
            return _ecommerceWebContext.Produtos.ToList();
        }
    }

}