using System.Collections.Generic;
using System.Linq;
using EspacoViviTantra.MVC.DAL.Contexts;
using EspacoViviTantra.MVC.Models;
using EspacoViviTantra.MVC.Domain.Interfaces;

namespace EspacoViviTantra.MVC.DAL.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly EspacoViviTantraContext _espacoViviTantraContext;
        public PessoaRepository(EspacoViviTantraContext espacoViviTantraContext)
        {
            _espacoViviTantraContext = espacoViviTantraContext;
        }
        public List<Pessoa> ListarPessoas()
        {
            return _espacoViviTantraContext.Pessoas.ToList();
        }

        public Pessoa ObterPessoaPorCpf(string cpf)
        {
            return _espacoViviTantraContext.Pessoas.FirstOrDefault(p => p.Cpf == cpf);
        }

        public Pessoa ObterPessoaPorEmail(string email)
        {
            return _espacoViviTantraContext.Pessoas.FirstOrDefault(p => p.Email == email);
        }

        public Pessoa ObterPessoaPorId(int id)
        {
            return _espacoViviTantraContext.Pessoas.FirstOrDefault(p => p.Id == id);
        }

        public Pessoa ObterPessoaPorNome(string nome)
        {
            return _espacoViviTantraContext.Pessoas.FirstOrDefault(p => p.Nome == nome);
        }

        public Pessoa ObterPessoaPorRg(string rg)
        {
            return _espacoViviTantraContext.Pessoas.FirstOrDefault(p => p.Rg == rg);
        }

        public void Salvar(Pessoa pessoa)
        {
            _espacoViviTantraContext.Pessoas.Add(pessoa);
            _espacoViviTantraContext.SaveChanges();
        }
    }
}