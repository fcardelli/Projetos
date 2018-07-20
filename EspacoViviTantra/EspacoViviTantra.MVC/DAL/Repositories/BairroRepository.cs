using System.Collections.Generic;
using System.Linq;
using EspacoViviTantra.MVC.DAL.Contexts;
using EspacoViviTantra.MVC.Domain.Interfaces;
using EspacoViviTantra.MVC.Models;

namespace EspacoViviTantra.MVC.DAL.Repositories
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