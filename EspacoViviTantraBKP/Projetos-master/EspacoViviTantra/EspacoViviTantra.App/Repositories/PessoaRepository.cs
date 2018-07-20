using System.Collections.Generic;
using System.Linq;
using EspacoViviTantra.App.Contexts;
using EspacoViviTantra.Domain.Interfaces;
using EspacoViviTantra.Domain.Models;

namespace EspacoViviTantraApp.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly EspacoViviTantraAppContext _espacoViviTantraAppContext;
        public PessoaRepository(EspacoViviTantraAppContext espacoViviTantraAppContext)
        {
            _espacoViviTantraAppContext = espacoViviTantraAppContext;
        }
        public List<Pessoa> ListarPessoas()
        {
            return _espacoViviTantraAppContext.Pessoas.ToList();
        }

        public Pessoa ObterPessoaPorCpf(string cpf)
        {
            return _espacoViviTantraAppContext.Pessoas.FirstOrDefault(p => p.Cpf == cpf);
        }

        public Pessoa ObterPessoaPorEmail(string email)
        {
            return _espacoViviTantraAppContext.Pessoas.FirstOrDefault(p => p.Email == email);
        }

        public Pessoa ObterPessoaPorId(int id)
        {
            return _espacoViviTantraAppContext.Pessoas.FirstOrDefault(p => p.Id == id);
        }

        public Pessoa ObterPessoaPorNome(string nome)
        {
            return _espacoViviTantraAppContext.Pessoas.FirstOrDefault(p => p.Nome == nome);
        }

        public Pessoa ObterPessoaPorRg(string rg)
        {
            return _espacoViviTantraAppContext.Pessoas.FirstOrDefault(p => p.Rg == rg);
        }

        public void Salvar(Pessoa pessoa)
        {
            _espacoViviTantraAppContext.Pessoas.Add(pessoa);
            _espacoViviTantraAppContext.SaveChanges();
        }
    }
}