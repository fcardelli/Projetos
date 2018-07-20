using System.Collections.Generic;
using System.Linq;
using EspacoViviTantra.MVC.DAL.Contexts;
using EspacoViviTantra.MVC.Models;
using EspacoViviTantra.MVC.Domain.Interfaces;

namespace EspacoViviTantra.MVC.DAL.Repositories
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