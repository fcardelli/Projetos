using System.Collections.Generic;
using EspacoViviTantra.Domain.Models;

namespace EspacoViviTantra.Domain.Interfaces
{
    public interface ITelefoneRepository
    {
        void Salvar(Telefone telefone);
        List<Telefone> ListarTelefones();
        Usuario ObterTelefonePorId(int id);
    }
}