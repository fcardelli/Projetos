using System.Collections.Generic;
using EspacoViviTantra.MVC.Models;

namespace EspacoViviTantra.MVC.Domain.Interfaces
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