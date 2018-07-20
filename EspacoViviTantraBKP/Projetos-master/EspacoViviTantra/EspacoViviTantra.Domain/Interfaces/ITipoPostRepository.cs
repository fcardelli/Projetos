using System.Collections.Generic;
using EspacoViviTantra.Domain.Models;

namespace EspacoViviTantra.Domain.Interfaces
{
    public interface ITipoPostRepository
    {
        void Salvar(TipoPost tipoPost);
        List<TipoPost> ListarTiposPosts();
        TipoPost ObterTipoPostPorId(int id);
        TipoPost ObterTipoPostPorDescricao(string descricao);
    }
}