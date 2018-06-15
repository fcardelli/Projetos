using ecommerce.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Web.Data
{
    public class EcommerceWebContext : DbContext
    {
        public DbSet<Produto> Produtos {get; set;}
        public DbSet<Pedido> Pedidos {get; set;}

        public  DbSet<ItemPedido> Itens {get; set;}
    }

}