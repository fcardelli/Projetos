using System.Collections.Generic;
using EspacoViviTantra.MVC.Models;

namespace EspacoViviTantra.MVC.Domain.Interfaces
{
    public interface IEnderecoRepository
    {
        void Salvar(Endereco endereco);
        List<Endereco> ListarEnderecos();
        Endereco ObterEnderecoPorId(int id);
        Endereco ObterEnderecoPorLogradouro(string logradouro);
        Endereco ObterEnderecoPorCep(string cep);
    }
}