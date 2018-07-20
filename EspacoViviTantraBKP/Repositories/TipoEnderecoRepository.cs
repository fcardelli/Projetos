using System.Collections.Generic;
using System.Linq;
using EspacoViviTantra.App.Contexts;
using EspacoViviTantra.Domain.Interfaces;
using EspacoViviTantra.Domain.Models;

namespace EspacoViviTantraApp.Repositories
{
    public class TipoEnderecoRepository : ITipoEnderecoRepository
    {
        private readonly EspacoViviTantraAppContext _espacoViviTantraAppContext;
        public TipoEnderecoRepository(EspacoViviTantraAppContext espacoViviTantraAppContext)
        {
            _espacoViviTantraAppContext = espacoViviTantraAppContext;
        }
        public List<TipoEndereco> ListarTiposEnderecos()
        {
            return _espacoViviTantraAppContext.TiposEnderecos.ToList();
        }

        public TipoEndereco ObterTipoEnderecoPorDescricao(string descricao)
        {
            return _espacoViviTantraAppContext.TiposEnderecos.FirstOrDefault(e => e.Descricao == descricao);
        }

        public TipoEndereco ObterTipoEnderecoPorId(int id)
        {
            return _espacoViviTantraAppContext.TiposEnderecos.FirstOrDefault(e => e.Id == id);
        }

        public void Salvar(TipoEndereco tipoEndereco)
        {
            _espacoViviTantraAppContext.TiposEnderecos.Add(tipoEndereco);
            _espacoViviTantraAppContext.SaveChanges();
        }
    }
}