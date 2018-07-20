using System.Collections.Generic;
using EspacoViviTantra.Domain.Models;

namespace EspacoViviTantra.Domain.Interfaces
{
    public interface IEstadoRepository
    {
        void Salvar(Estado estado);
        List<Estado> ListarEstados();
        Estado ObterEstadoPorId(int id);
        Estado ObterEstadoPorNome(string nome);
    }
}