using System.Collections.Generic;
using EspacoViviTantra.Domain.Models;

namespace EspacoViviTantra.Domain.Interfaces
{
    public interface ICidadeRepository
    {
        void Salvar(Cidade cidade);
        List<Cidade> ListarCidades();
        Cidade ObterCidadePorId(int id);
        Cidade ObterCidadePorNome(string nome);
    }
}