using System.Collections.Generic;
using System.Linq;
using EspacoViviTantra.MVC.DAL.Contexts;
using EspacoViviTantra.MVC.Models;
using EspacoViviTantra.MVC.Domain.Interfaces;

namespace EspacoViviTantra.MVC.DAL.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly EspacoViviTantraContext _espacoViviTantraContext;
        public UsuarioRepository(EspacoViviTantraContext espacoViviTantraContext)
        {
            _espacoViviTantraContext = espacoViviTantraContext;
        }
        public List<Usuario> ListarUsuarios()
        {
            return _espacoViviTantraContext.Usuarios.ToList();
        }

        public Usuario ObterUsuarioPorId(int id)
        {
            return _espacoViviTantraContext.Usuarios.FirstOrDefault(u => u.Id == id);
        }

        public Usuario ObterUsuarioPorLogin(string login)
        {
            return _espacoViviTantraContext.Usuarios.FirstOrDefault(u => u.Login == login);
        }

        public void Salvar(Usuario usuario)
        {
            _espacoViviTantraContext.Usuarios.Add(usuario);
            _espacoViviTantraContext.SaveChanges();
        }
    }
}