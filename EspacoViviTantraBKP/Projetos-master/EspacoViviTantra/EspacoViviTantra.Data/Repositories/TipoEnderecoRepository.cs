using System.Collections.Generic;
using System.Linq;
using EspacoViviTantra.Data.Contexts;
using EspacoViviTantra.Domain.Interfaces;
using EspacoViviTantra.Domain.Models;

namespace EspacoViviTantra.Data.Repositories
{
    public class TipoEnderecoRepository : ITipoEnderecoRepository
    {
        private readonly EspacoViviTantraContext _espacoViviTantraContext;
        public TipoEnderecoRepository(EspacoViviTantraContext espacoViviTantraContext)
        {
            _espacoViviTantraContext = espacoViviTantraContext;
        }
        public List<TipoEndereco> ListarTiposEnderecos()
        {
            return _espacoViviTantraContext.TiposEnderecos.ToList();
        }

        public TipoEndereco ObterTipoEnderecoPorDescricao(string descricao)
        {
            return _espacoViviTantraContext.TiposEnderecos.FirstOrDefault(e => e.Descricao == descricao);
        }

        public TipoEndereco ObterTipoEnderecoPorId(int id)
        {
            return _espacoViviTantraContext.TiposEnderecos.FirstOrDefault(e => e.Id == id);
        }

        public void Salvar(TipoEndereco tipoEndereco)
        {
            _espacoViviTantraContext.TiposEnderecos.Add(tipoEndereco);
            _espacoViviTantraContext.SaveChanges();
        }
    }
}