using System.Collections.Generic;
using EspacoViviTantra.Domain.Models;

namespace EspacoViviTantra.Domain.Interfaces
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