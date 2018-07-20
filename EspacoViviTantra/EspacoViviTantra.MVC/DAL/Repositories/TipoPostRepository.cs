using System.Collections.Generic;
using System.Linq;
using EspacoViviTantra.MVC.DAL.Contexts;
using EspacoViviTantra.MVC.Models;
using EspacoViviTantra.MVC.Domain.Interfaces;

namespace EspacoViviTantra.MVC.DAL.Repositories
{
    public class TipoPostRepository : ITipoPostRepository
    {
        private readonly EspacoViviTantraContext _espacoViviTantraContext;
        public TipoPostRepository(EspacoViviTantraContext espacoViviTantraContext)
        {
            _espacoViviTantraContext = espacoViviTantraContext;
        }

        public List<TipoPost> ListarTiposPosts()
        {
            return _espacoViviTantraContext.TiposPosts.ToList();
        }

        public TipoPost ObterTipoPostPorDescricao(string descricao)
        {
            return _espacoViviTantraContext.TiposPosts.FirstOrDefault(t => t.Descricao == descricao);
        }

        public TipoPost ObterTipoPostPorId(int id)
        {
            return _espacoViviTantraContext.TiposPosts.FirstOrDefault(t => t.Id == id);
        }

        public void Salvar(TipoPost tipoPost)
        {
            _espacoViviTantraContext.TiposPosts.Add(tipoPost);
            _espacoViviTantraContext.SaveChanges();
        }
    }
}