using System.Collections.Generic;
using EspacoViviTantra.MVC.Models;

namespace EspacoViviTantra.MVC.Domain.Interfaces
{
    public interface IEstadoRepository
    {
        void Salvar(Estado estado);
        List<Estado> ListarEstados();
        Estado ObterEstadoPorId(int id);
        Estado ObterEstadoPorNome(string nome);
    }
}