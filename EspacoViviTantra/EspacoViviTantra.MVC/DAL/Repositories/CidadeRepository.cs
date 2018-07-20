using System.Collections.Generic;
using System.Linq;
using EspacoViviTantra.MVC.Domain.Interfaces;
using EspacoViviTantra.MVC.DAL.Contexts;
using EspacoViviTantra.MVC.Models;

namespace EspacoViviTantra.MVC.DAL.Repositories
{
    public class CidadeRepository : ICidadeRepository
    {
        private readonly EspacoViviTantraContext _espacoViviTantraContext;
        public CidadeRepository(EspacoViviTantraContext espacoViviTantraContext)
        {
            _espacoViviTantraContext = espacoViviTantraContext;
        }
        public List<Cidade> ListarCidades()
        {
            return _espacoViviTantraContext.Cidades.ToList();
        }

        public Cidade ObterCidadePorId(int id)
        {
            return _espacoViviTantraContext.Cidades.FirstOrDefault(b => b.Id == id);
        }

        public Cidade ObterCidadePorNome(string nome)
        {
            return _espacoViviTantraContext.Cidades.FirstOrDefault(b => b.Nome == nome);
        }

        public void Salvar(Cidade Cidade)
        {
            _espacoViviTantraContext.Cidades.Add(Cidade);
            _espacoViviTantraContext.SaveChanges();
        }
    }
}