using System.Collections.Generic;
using EspacoViviTantra.Domain.Models;

namespace EspacoViviTantra.Domain.Interfaces
{
    public interface ITipoUsuarioRepository
    {
        void Salvar(TipoUsuario tipoUsuario);
        List<TipoUsuario> ListarTiposUsuarios();
        TipoUsuario ObterTipoUsuarioPorId(int id);
        TipoUsuario ObterTipoUsuarioPorDescricao(string nome);
    }
}