using System.Collections.Generic;
using System.Linq;
using EspacoViviTantra.App.Contexts;
using EspacoViviTantra.Domain.Interfaces;
using EspacoViviTantra.Domain.Models;

namespace EspacoViviTantraApp.Repositories
{
    public class UsuarioStatusRepository : IUsuarioStatusRepository
    {
        private readonly EspacoViviTantraAppContext _espacoViviTantraAppContext;
        public UsuarioStatusRepository(EspacoViviTantraAppContext espacoViviTantraAppContext)
        {
            _espacoViviTantraAppContext = espacoViviTantraAppContext;
        }
        public List<UsuarioStatus> ListarUsuariosStatus()
        {
            return _espacoViviTantraAppContext.UsuarioStatus.ToList();
        }

        public UsuarioStatus ObterUsuarioStatusPorDescricao(string descricao)
        {
            return _espacoViviTantraAppContext.UsuarioStatus.FirstOrDefault(u => u.Descricao == descricao);
        }

        public UsuarioStatus ObterUsuarioStatusPorId(int id)
        {
            return _espacoViviTantraAppContext.UsuarioStatus.FirstOrDefault(u => u.Id == id);
        }

        public void Salvar(UsuarioStatus usuarioStatus)
        {
            _espacoViviTantraAppContext.UsuarioStatus.Add(usuarioStatus);
            _espacoViviTantraAppContext.SaveChanges();
        }
    }
}