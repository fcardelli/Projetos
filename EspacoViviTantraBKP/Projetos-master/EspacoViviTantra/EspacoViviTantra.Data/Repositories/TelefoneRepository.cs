using System.Collections.Generic;
using System.Linq;
using EspacoViviTantra.Data.Contexts;
using EspacoViviTantra.Domain.Interfaces;
using EspacoViviTantra.Domain.Models;

namespace EspacoViviTantra.Data.Repositories
{
    public class TelefoneRepository : ITelefoneRepository
    {
        private readonly EspacoViviTantraContext _espacoViviTantraContext;
        public TelefoneRepository(EspacoViviTantraContext espacoViviTantraContext)
        {
            _espacoViviTantraContext = espacoViviTantraContext;
        }
        public List<Telefone> ListarTelefones()
        {
            return _espacoViviTantraContext.Telefones.ToList();
        }

        public Telefone ObterTelefonePorId(int id)
        {
            return _espacoViviTantraContext.Telefones.FirstOrDefault(t => t.Id == id);
        }

        public Telefone ObterTelefonePorNumero(string numero)
        {
            return _espacoViviTantraContext.Telefones.FirstOrDefault(t => t.Numero == numero);
        }

        public void Salvar(Telefone telefone)
        {
            _espacoViviTantraContext.Telefones.Add(telefone);
            _espacoViviTantraContext.SaveChanges();
        }
    }
}