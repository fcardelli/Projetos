using System.Collections.Generic;
using EspacoViviTantra.MVC.Models;

namespace EspacoViviTantra.MVC.Domain.Interfaces
{
    public interface ITipoTelefoneRepository
    {
        void Salvar(TipoTelefone tipoTelefone);
        List<TipoTelefone> ListarTiposTelefones();
        TipoTelefone ObterTipoTelefonePorId(int id);
        TipoTelefone ObterTipoTelefonePorDescricao(string descricao);
    }
}