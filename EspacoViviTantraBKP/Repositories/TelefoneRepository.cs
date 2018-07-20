using System.Collections.Generic;
using System.Linq;
using EspacoViviTantra.App.Contexts;
using EspacoViviTantra.Domain.Interfaces;
using EspacoViviTantra.Domain.Models;

namespace EspacoViviTantraApp.Repositories
{
    public class TelefoneRepository : ITelefoneRepository
    {
        private readonly EspacoViviTantraAppContext _espacoViviTantraAppContext;
        public TelefoneRepository(EspacoViviTantraAppContext espacoViviTantraAppContext)
        {
            _espacoViviTantraAppContext = espacoViviTantraAppContext;
        }
        public List<Telefone> ListarTelefones()
        {
            return _espacoViviTantraAppContext.Telefones.ToList();
        }

        public Telefone ObterTelefonePorId(int id)
        {
            return _espacoViviTantraAppContext.Telefones.FirstOrDefault(t => t.Id == id);
        }

        public Telefone ObterTelefonePorNumero(string numero)
        {
            return _espacoViviTantraAppContext.Telefones.FirstOrDefault(t => t.Numero == numero);
        }

        public void Salvar(Telefone telefone)
        {
            _espacoViviTantraAppContext.Telefones.Add(telefone);
            _espacoViviTantraAppContext.SaveChanges();
        }
    }
}