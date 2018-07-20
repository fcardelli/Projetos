using System.Collections.Generic;
using EspacoViviTantra.Domain.Models;

namespace EspacoViviTantra.Domain.Interfaces
{
    public interface ITipoTelefoneRepository
    {
        void Salvar(TipoTelefone tipoTelefone);
        List<TipoTelefone> ListarTiposTelefones();
        TipoTelefone ObterTipoTelefonePorId(int id);
        TipoTelefone ObterTipoTelefonePorDescricao(string descricao);
    }
}