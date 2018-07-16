using System.Collections.Generic;
using System.Linq;
using EspacoViviTantra.App.Contexts;
using EspacoViviTantra.Domain.Interfaces;
using EspacoViviTantra.Domain.Models;

namespace EspacoViviTantraApp.Repositories
{
    public class ImagemRepository : IImagemRepository
    {
        private readonly EspacoViviTantraAppContext _espacoViviTantraAppContext;

        public ImagemRepository(EspacoViviTantraAppContext espacoViviTantraAppContext)
        {
            _espacoViviTantraAppContext = espacoViviTantraAppContext;
        }
        public List<Imagem> ListarImagens()
        {
            return _espacoViviTantraAppContext.Imagens.ToList();
        }

        public Imagem ObterImagemPorCaminho(string caminho)
        {
            return _espacoViviTantraAppContext.Imagens.FirstOrDefault(i => i.Caminho == caminho);
        }

        public Imagem ObterImagemPorId(int id)
        {
            return _espacoViviTantraAppContext.Imagens.FirstOrDefault(i => i.Id == id);
        }

        public Imagem ObterImagemPorNome(string nome)
        {
            return _espacoViviTantraAppContext.Imagens.FirstOrDefault(i => i.Nome == nome);
        }

        public void Salvar(Imagem imagem)
        {
            _espacoViviTantraAppContext.Imagens.Add(imagem);
            _espacoViviTantraAppContext.SaveChanges();
        }
    }
}