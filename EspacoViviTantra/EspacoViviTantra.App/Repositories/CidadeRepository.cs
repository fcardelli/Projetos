using System.Collections.Generic;
using System.Linq;
using EspacoViviTantra.App.Contexts;
using EspacoViviTantra.Domain.Interfaces;
using EspacoViviTantra.Domain.Models;

namespace EspacoViviTantraApp.Repositories
{
    public class CidadeRepository : ICidadeRepository
    {
        private readonly EspacoViviTantraAppContext _espacoViviTantraAppContext;
        public CidadeRepository(EspacoViviTantraAppContext espacoViviTantraAppContext)
        {
            _espacoViviTantraAppContext = espacoViviTantraAppContext;
        }
        public List<Cidade> ListarCidades()
        {
            return _espacoViviTantraAppContext.Cidades.ToList();
        }

        public Cidade ObterCidadePorId(int id)
        {
            return _espacoViviTantraAppContext.Cidades.FirstOrDefault(b => b.Id == id);
        }

        public Cidade ObterCidadePorNome(string nome)
        {
            return _espacoViviTantraAppContext.Cidades.FirstOrDefault(b => b.Nome == nome);
        }

        public void Salvar(Cidade Cidade)
        {
            _espacoViviTantraAppContext.Cidades.Add(Cidade);
            _espacoViviTantraAppContext.SaveChanges();
        }
    }
}