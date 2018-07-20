using System.Collections.Generic;
using EspacoViviTantra.Domain.Models;

namespace EspacoViviTantra.Domain.Interfaces
{
    public interface IBairroRepository
    {
        void Salvar(Bairro bairro);
        List<Bairro> ListarBairros();
        Bairro ObterBairroPorId(int id);
        Bairro ObterBairroPorNome(string nome);
    }
}