using System.Collections.Generic;
using System.Linq;
using EspacoViviTantra.Data.Contexts;
using EspacoViviTantra.Domain.Interfaces;
using EspacoViviTantra.Domain.Models;

namespace EspacoViviTantra.Data.Repositories
{
    public class BairroRepository : IBairroRepository
    {
        private readonly EspacoViviTantraContext _espacoViviTantraContext;
        public BairroRepository(EspacoViviTantraContext espacoViviTantraContext)
        {
            _espacoViviTantraContext = espacoViviTantraContext;
        }
        public List<Bairro> ListarBairros()
        {
            return _espacoViviTantraContext.Bairros.ToList();
        }

        public Bairro ObterBairroPorId(int id)
        {
            return _espacoViviTantraContext.Bairros.FirstOrDefault(b => b.Id == id);
        }

        public Bairro ObterBairroPorNome(string nome)
        {
            return _espacoViviTantraContext.Bairros.FirstOrDefault(b => b.Nome == nome);
        }

        public void Salvar(Bairro bairro)
        {
            _espacoViviTantraContext.Bairros.Add(bairro);
            _espacoViviTantraContext.SaveChanges();
        }
    }
}