using System.Collections.Generic;
using EspacoViviTantra.Domain.Models;

namespace EspacoViviTantra.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        void Salvar(Usuario usuario);
        List<Usuario> ListarUsuarios();
        Usuario ObterUsuarioPorId(int id);
    }    
}
