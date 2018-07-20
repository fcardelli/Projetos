using System.Collections.Generic;
using EspacoViviTantra.Domain.Models;

namespace EspacoViviTantra.Domain.Interfaces
{
    public interface IImagemRepository
    {
        void Salvar(Imagem imagem);
        List<Imagem> ListarImagens();
        Imagem ObterImagemPorId(int id);
        Imagem ObterImagemPorNome(string nome);
        Imagem ObterImagemPorCaminho(string caminho);
    }
}