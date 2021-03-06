using System.Collections.Generic;
using EspacoViviTantra.Domain.Models;

namespace EspacoViviTantra.Domain.Interfaces
{
    public interface IUsuarioStatusRepository
    {
        void Salvar(UsuarioStatus usuarioStatus);
        List<UsuarioStatus> ListarUsuariosStatus();
        UsuarioStatus ObterUsuarioStatusPorId(int id);
        UsuarioStatus ObterUsuarioStatusPorDescricao(string descricao);
    }
}