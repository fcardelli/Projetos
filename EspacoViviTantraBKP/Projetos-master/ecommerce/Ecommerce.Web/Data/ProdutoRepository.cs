using System.Collections.Generic;
using System.Linq;
using Ecommerce.Web.Models;

namespace Ecommerce.Web.Data
{
    public class ProdutoRepository : IProdutoRepository
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

        public Produto ObterProdutoPorId(int id)
        {
            return _ecommerceWebContext.Produtos.FirstOrDefault(p => p.Id == id);
        }

        public void Salvar(Produto produto)
        {
            _ecommerceWebContext.Produtos.Add(produto);
            _ecommerceWebContext.SaveChanges();
        }
    }

}