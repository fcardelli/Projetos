using System.Collections.Generic;
using System.Linq;
using EspacoViviTantra.MVC.DAL.Contexts;
using EspacoViviTantra.MVC.Models;
using EspacoViviTantra.MVC.Domain.Interfaces;

namespace EspacoViviTantra.MVC.DAL.Repositories
{
    public class TipoTelefoneRepository : ITipoTelefoneRepository
    {
        private readonly EspacoViviTantraContext _espacoViviTantraContext;

        public TipoTelefoneRepository(EspacoViviTantraContext espacoViviTantraContext)
        {
            _espacoViviTantraContext = espacoViviTantraContext;
        }
        public List<TipoTelefone> ListarTiposTelefones()
        {
            return _espacoViviTantraContext.TiposTelefones.ToList();
        }

        public TipoTelefone ObterTipoTelefonePorDescricao(string descricao)
        {
            return _espacoViviTantraContext.TiposTelefones.FirstOrDefault(t => t.Descricao == descricao);
        }

        public TipoTelefone ObterTipoTelefonePorId(int id)
        {
            return _espacoViviTantraContext.TiposTelefones.FirstOrDefault(t => t.Id == id);
        }

        public void Salvar(TipoTelefone tipoTelefone)
        {
            _espacoViviTantraContext.TiposTelefones.Add(tipoTelefone);
            _espacoViviTantraContext.SaveChanges();
        }
    }
}