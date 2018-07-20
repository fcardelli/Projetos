using System.Collections.Generic;
using System.Linq;
using EspacoViviTantra.Data.Contexts;
using EspacoViviTantra.Domain.Interfaces;
using EspacoViviTantra.Domain.Models;

namespace EspacoViviTantra.Data.Repositories
{
    public class EstadoRepository : IEstadoRepository
    {
        private readonly EspacoViviTantraContext _espacoViviTantraContext;
        public EstadoRepository(EspacoViviTantraContext espacoViviTantraContext)
        {
            _espacoViviTantraContext = espacoViviTantraContext;
        }
        public List<Estado> ListarEstados()
        {
            return _espacoViviTantraContext.Estados.ToList();
        }

        public Estado ObterEstadoPorId(int id)
        {
            return _espacoViviTantraContext.Estados.FirstOrDefault(b => b.Id == id);
        }

        public Estado ObterEstadoPorNome(string nome)
        {
            return _espacoViviTantraContext.Estados.FirstOrDefault(b => b.Nome == nome);
        }

        public void Salvar(Estado Estado)
        {
            _espacoViviTantraContext.Estados.Add(Estado);
            _espacoViviTantraContext.SaveChanges();
        }
    }
}