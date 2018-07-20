using System.Collections.Generic;
using EspacoViviTantra.App.Contexts;
using EspacoViviTantra.Domain.Interfaces;
using EspacoViviTantra.Domain.Models;
using System.Linq;

namespace EspacoViviTantraApp.Repositories
{
    public class EnderecoRepository : IEnderecoRepository
    {
        protected readonly EspacoViviTantraAppContext _espacoViviTantraAppContext;

        public EnderecoRepository(EspacoViviTantraAppContext espacoViviTantraAppContext)
        {
            _espacoViviTantraAppContext = espacoViviTantraAppContext;
        }
        public List<Endereco> ListarEnderecos()
        {
            return _espacoViviTantraAppContext.Enderecos.ToList();
        }

        public Endereco ObterEnderecoPorCep(string cep)
        {
            return _espacoViviTantraAppContext.Enderecos.FirstOrDefault(e => e.Cep == cep);
        }

        public Endereco ObterEnderecoPorId(int id)
        {
            return _espacoViviTantraAppContext.Enderecos.FirstOrDefault(e => e.Id == id);
        }

        public Endereco ObterEnderecoPorLogradouro(string logradouro)
        {
            return _espacoViviTantraAppContext.Enderecos.FirstOrDefault(e => e.Logradouro == logradouro);
        }

        public void Salvar(Endereco endereco)
        {
            _espacoViviTantraAppContext.Enderecos.Add(endereco);
            _espacoViviTantraAppContext.SaveChanges();
        }
    }
}