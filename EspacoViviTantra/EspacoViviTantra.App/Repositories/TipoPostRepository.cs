using System.Collections.Generic;
using System.Linq;
using EspacoViviTantra.App.Contexts;
using EspacoViviTantra.Domain.Interfaces;
using EspacoViviTantra.Domain.Models;

namespace EspacoViviTantraApp.Repositories
{
    public class TipoPostRepository : ITipoPostRepository
    {
        private readonly EspacoViviTantraAppContext _espacoViviTantraAppContext;
        public TipoPostRepository(EspacoViviTantraAppContext espacoViviTantraAppContext)
        {
            _espacoViviTantraAppContext = espacoViviTantraAppContext;
        }

        public List<TipoPost> ListarTiposPosts()
        {
            return _espacoViviTantraAppContext.TiposPosts.ToList();
        }

        public TipoPost ObterTipoPostPorDescricao(string descricao)
        {
            return _espacoViviTantraAppContext.TiposPosts.FirstOrDefault(t => t.Descricao == descricao);
        }

        public TipoPost ObterTipoPostPorId(int id)
        {
            return _espacoViviTantraAppContext.TiposPosts.FirstOrDefault(t => t.Id == id);
        }

        public void Salvar(TipoPost tipoPost)
        {
            _espacoViviTantraAppContext.TiposPosts.Add(tipoPost);
            _espacoViviTantraAppContext.SaveChanges();
        }
    }
}