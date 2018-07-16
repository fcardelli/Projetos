using System.Collections.Generic;
using System.Linq;
using EspacoViviTantra.App.Contexts;
using EspacoViviTantra.Domain.Interfaces;
using EspacoViviTantra.Domain.Models;

namespace EspacoViviTantraApp.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        private readonly EspacoViviTantraAppContext _espacoViviTantraAppContext;
        public TipoUsuarioRepository(EspacoViviTantraAppContext espacoViviTantraAppContext)
        {
            _espacoViviTantraAppContext = espacoViviTantraAppContext;
        }
        public List<TipoUsuario> ListarTiposUsuarios()
        {
            return _espacoViviTantraAppContext.TiposUsuarios.ToList();
        }

        public TipoUsuario ObterTipoUsuarioPorDescricao(string descricao)
        {
            return _espacoViviTantraAppContext.TiposUsuarios.FirstOrDefault(u => u.Descricao == descricao);
        }

        public TipoUsuario ObterTipoUsuarioPorId(int id)
        {
            return _espacoViviTantraAppContext.TiposUsuarios.FirstOrDefault(u => u.Id == id);
        }

        public void Salvar(TipoUsuario tipoUsuario)
        {
            _espacoViviTantraAppContext.TiposUsuarios.Add(tipoUsuario);
            _espacoViviTantraAppContext.SaveChanges();
        }
    }
}