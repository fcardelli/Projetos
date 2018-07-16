using System.Collections.Generic;
using System.Linq;
using EspacoViviTantra.App.Contexts;
using EspacoViviTantra.Domain.Interfaces;
using EspacoViviTantra.Domain.Models;

namespace EspacoViviTantraApp.Repositories
{
    public class BairroRepository : IBairroRepository
    {
        private readonly EspacoViviTantraAppContext _espacoViviTantraAppContext;
        public BairroRepository(EspacoViviTantraAppContext espacoViviTantraAppContext)
        {
            _espacoViviTantraAppContext = espacoViviTantraAppContext;
        }
        public List<Bairro> ListarBairros()
        {
            return _espacoViviTantraAppContext.Bairros.ToList();
        }

        public Bairro ObterBairroPorId(int id)
        {
            return _espacoViviTantraAppContext.Bairros.FirstOrDefault(b => b.Id == id);
        }

        public Bairro ObterBairroPorNome(string nome)
        {
            return _espacoViviTantraAppContext.Bairros.FirstOrDefault(b => b.Nome == nome);
        }

        public void Salvar(Bairro bairro)
        {
            _espacoViviTantraAppContext.Bairros.Add(bairro);
            _espacoViviTantraAppContext.SaveChanges();
        }
    }
}