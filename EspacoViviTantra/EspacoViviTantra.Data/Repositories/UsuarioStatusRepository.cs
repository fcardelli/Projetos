using System.Collections.Generic;
using System.Linq;
using EspacoViviTantra.Data.Contexts;
using EspacoViviTantra.Domain.Interfaces;
using EspacoViviTantra.Domain.Models;

namespace EspacoViviTantra.Data.Repositories
{
    public class UsuarioStatusRepository : IUsuarioStatusRepository
    {
        private readonly EspacoViviTantraContext _espacoViviTantraContext;
        public UsuarioStatusRepository(EspacoViviTantraContext espacoViviTantraContext)
        {
            _espacoViviTantraContext = espacoViviTantraContext;
        }
        public List<UsuarioStatus> ListarUsuariosStatus()
        {
            return _espacoViviTantraContext.UsuarioStatus.ToList();
        }

        public UsuarioStatus ObterUsuarioStatusPorDescricao(string descricao)
        {
            return _espacoViviTantraContext.UsuarioStatus.FirstOrDefault(u => u.Descricao == descricao);
        }

        public UsuarioStatus ObterUsuarioStatusPorId(int id)
        {
            return _espacoViviTantraContext.UsuarioStatus.FirstOrDefault(u => u.Id == id);
        }

        public void Salvar(UsuarioStatus usuarioStatus)
        {
            _espacoViviTantraContext.UsuarioStatus.Add(usuarioStatus);
            _espacoViviTantraContext.SaveChanges();
        }
    }
}