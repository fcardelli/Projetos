using System.Collections.Generic;
using System.Linq;
using EspacoViviTantra.App.Contexts;
using EspacoViviTantra.Domain.Interfaces;
using EspacoViviTantra.Domain.Models;

namespace EspacoViviTantraApp.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly EspacoViviTantraAppContext _espacoViviTantraAppContext;
        public UsuarioRepository(EspacoViviTantraAppContext espacoViviTantraAppContext)
        {
            _espacoViviTantraAppContext = espacoViviTantraAppContext;
        }
        public List<Usuario> ListarUsuarios()
        {
            return _espacoViviTantraAppContext.Usuarios.ToList();
        }

        public Usuario ObterUsuarioPorId(int id)
        {
            return _espacoViviTantraAppContext.Usuarios.FirstOrDefault(u => u.Id == id);
        }

        public Usuario ObterUsuarioPorLogin(string login)
        {
            return _espacoViviTantraAppContext.Usuarios.FirstOrDefault(u => u.Login == login);
        }

        public void Salvar(Usuario usuario)
        {
            _espacoViviTantraAppContext.Usuarios.Add(usuario);
            _espacoViviTantraAppContext.SaveChanges();
        }
    }
}