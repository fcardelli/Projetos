using System.Collections.Generic;
using EspacoViviTantra.MVC.Models;

namespace EspacoViviTantra.MVC.Domain.Interfaces
{
    public interface ITipoEnderecoRepository
    {
        void Salvar(TipoEndereco tipoEndereco);
        List<TipoEndereco> ListarTiposEnderecos();
        TipoEndereco ObterTipoEnderecoPorId(int id);
        TipoEndereco ObterTipoEnderecoPorDescricao(string descricao);
    }
}