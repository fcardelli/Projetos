using System.Collections.Generic;
using System.Linq;
using EspacoViviTantra.MVC.DAL.Contexts;
using EspacoViviTantra.MVC.Models;
using EspacoViviTantra.MVC.Domain.Interfaces;

namespace EspacoViviTantra.MVC.DAL.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        private readonly EspacoViviTantraContext _espacoViviTantraContext;
        public TipoUsuarioRepository(EspacoViviTantraContext espacoViviTantraContext)
        {
            _espacoViviTantraContext = espacoViviTantraContext;
        }
        public List<TipoUsuario> ListarTiposUsuarios()
        {
            return _espacoViviTantraContext.TiposUsuarios.ToList();
        }

        public TipoUsuario ObterTipoUsuarioPorDescricao(string descricao)
        {
            return _espacoViviTantraContext.TiposUsuarios.FirstOrDefault(u => u.Descricao == descricao);
        }

        public TipoUsuario ObterTipoUsuarioPorId(int id)
        {
            return _espacoViviTantraContext.TiposUsuarios.FirstOrDefault(u => u.Id == id);
        }

        public void Salvar(TipoUsuario tipoUsuario)
        {
            _espacoViviTantraContext.TiposUsuarios.Add(tipoUsuario);
            _espacoViviTantraContext.SaveChanges();
        }
    }
}