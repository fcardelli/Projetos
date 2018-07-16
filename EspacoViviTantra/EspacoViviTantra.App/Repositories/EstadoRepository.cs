using System.Collections.Generic;
using System.Linq;
using EspacoViviTantra.Domain.Interfaces;
using EspacoViviTantra.Domain.Models;
using EspacoViviTantra.App.Contexts;

namespace EspacoViviTantraApp.Repositories
{
    public class EstadoRepository : IEstadoRepository
    {
        private readonly EspacoViviTantraAppContext _espacoViviTantraAppContext;
        public EstadoRepository(EspacoViviTantraAppContext espacoViviTantraAppContext)
        {
            _espacoViviTantraAppContext = espacoViviTantraAppContext;
        }
        public List<Estado> ListarEstados()
        {
            return _espacoViviTantraAppContext.Estados.ToList();
        }

        public Estado ObterEstadoPorId(int id)
        {
            return _espacoViviTantraAppContext.Estados.FirstOrDefault(b => b.Id == id);
        }

        public Estado ObterEstadoPorNome(string nome)
        {
            return _espacoViviTantraAppContext.Estados.FirstOrDefault(b => b.Nome == nome);
        }

        public void Salvar(Estado Estado)
        {
            _espacoViviTantraAppContext.Estados.Add(Estado);
            _espacoViviTantraAppContext.SaveChanges();
        }
    }
}