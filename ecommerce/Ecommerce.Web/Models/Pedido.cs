using System;
using System.Collections.Generic;

namespace Ecommerce.Web.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataPedido { get; set; }    
        public ICollection<ItemPedido> ItensPedidos { get; set; }
    
    }

}