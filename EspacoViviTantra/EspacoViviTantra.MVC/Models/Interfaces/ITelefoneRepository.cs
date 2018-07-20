using System.Collections.Generic;
using EspacoViviTantra.MVC.Models;

namespace EspacoViviTantra.MVC.Domain.Interfaces
{
    public interface ITelefoneRepository
    {
        void Salvar(Telefone telefone);
        List<Telefone> ListarTelefones();
        Telefone ObterTelefonePorId(int id);
        Telefone ObterTelefonePorNumero(string numero);

    }
}