using System.Collections.Generic;
using EspacoViviTantra.MVC.Models;

namespace EspacoViviTantra.MVC.Domain.Interfaces
{
    public interface IBairroRepository
    {
        void Salvar(Bairro bairro);
        List<Bairro> ListarBairros();
        Bairro ObterBairroPorId(int id);
        Bairro ObterBairroPorNome(string nome);
    }
}