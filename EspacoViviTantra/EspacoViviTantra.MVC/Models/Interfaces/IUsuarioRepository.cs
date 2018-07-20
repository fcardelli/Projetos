using System.Collections.Generic;
using EspacoViviTantra.MVC.Models;

namespace EspacoViviTantra.MVC.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        void Salvar(Usuario usuario);
        List<Usuario> ListarUsuarios();
        Usuario ObterUsuarioPorId(int id);
        Usuario ObterUsuarioPorLogin(string login);
    }    
}
