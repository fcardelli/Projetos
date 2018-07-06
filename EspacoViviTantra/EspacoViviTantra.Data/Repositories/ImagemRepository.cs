using System.Collections.Generic;
using System.Linq;
using EspacoViviTantra.Data.Contexts;
using EspacoViviTantra.Domain.Interfaces;
using EspacoViviTantra.Domain.Models;

namespace EspacoViviTantra.Data.Repositories
{
    public class ImagemRepository : IImagemRepository
    {
        private readonly EspacoViviTantraContext _espacoViviTantraContext;

        public ImagemRepository(EspacoViviTantraContext espacoViviTantraContext)
        {
            _espacoViviTantraContext = espacoViviTantraContext;
        }
        public List<Imagem> ListarImagens()
        {
            return _espacoViviTantraContext.Imagens.ToList();
        }

        public Imagem ObterImagemPorCaminho(string caminho)
        {
            return _espacoViviTantraContext.Imagens.FirstOrDefault(i => i.Caminho == caminho);
        }

        public Imagem ObterImagemPorId(int id)
        {
            return _espacoViviTantraContext.Imagens.FirstOrDefault(i => i.Id == id);
        }

        public Imagem ObterImagemPorNome(string nome)
        {
            return _espacoViviTantraContext.Imagens.FirstOrDefault(i => i.Nome == nome);
        }

        public void Salvar(Imagem imagem)
        {
            _espacoViviTantraContext.Imagens.Add(imagem);
            _espacoViviTantraContext.SaveChanges();
        }
    }
}