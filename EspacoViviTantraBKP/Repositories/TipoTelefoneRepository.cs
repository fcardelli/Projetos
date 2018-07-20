using System.Collections.Generic;
using System.Linq;
using EspacoViviTantra.App.Contexts;
using EspacoViviTantra.Domain.Interfaces;
using EspacoViviTantra.Domain.Models;

namespace EspacoViviTantraApp.Repositories
{
    public class TipoTelefoneRepository : ITipoTelefoneRepository
    {
        private readonly EspacoViviTantraAppContext _espacoViviTantraAppContext;

        public TipoTelefoneRepository(EspacoViviTantraAppContext espacoViviTantraAppContext)
        {
            _espacoViviTantraAppContext = espacoViviTantraAppContext;
        }
        public List<TipoTelefone> ListarTiposTelefones()
        {
            return _espacoViviTantraAppContext.TiposTelefones.ToList();
        }

        public TipoTelefone ObterTipoTelefonePorDescricao(string descricao)
        {
            return _espacoViviTantraAppContext.TiposTelefones.FirstOrDefault(t => t.Descricao == descricao);
        }

        public TipoTelefone ObterTipoTelefonePorId(int id)
        {
            return _espacoViviTantraAppContext.TiposTelefones.FirstOrDefault(t => t.Id == id);
        }

        public void Salvar(TipoTelefone tipoTelefone)
        {
            _espacoViviTantraAppContext.TiposTelefones.Add(tipoTelefone);
            _espacoViviTantraAppContext.SaveChanges();
        }
    }
}