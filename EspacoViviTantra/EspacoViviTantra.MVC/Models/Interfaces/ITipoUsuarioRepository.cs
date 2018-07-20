using System.Collections.Generic;
using EspacoViviTantra.MVC.Models;

namespace EspacoViviTantra.MVC.Domain.Interfaces
{
    public interface ITipoUsuarioRepository
    {
        void Salvar(TipoUsuario tipoUsuario);
        List<TipoUsuario> ListarTiposUsuarios();
        TipoUsuario ObterTipoUsuarioPorId(int id);
        TipoUsuario ObterTipoUsuarioPorDescricao(string descricao);
    }
}