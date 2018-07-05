using System.Collections.Generic;
using EspacoViviTantra.Domain.Models;

namespace EspacoViviTantra.Domain.Interfaces
{
    public interface IPessoaRepository
    {
        void Salvar(Pessoa pessoa);
        List<Pessoa> ListarPessoas();
        Pessoa ObterPessoaPorId(int id);
        Pessoa ObterPessoaPorNome(string nome);
        Pessoa ObterPessoaPorCpf(string cpf);
        Pessoa ObterPessoaPorRg(string rg);
        Pessoa ObterPessoaPorEmail(string email);
    }
}