using System.Collections.Generic;
using EspacoViviTantra.Domain.Interfaces;
using EspacoViviTantra.Domain.Models;
using EspacoViviTantra.Data.Contexts;
using System.Linq;

namespace EspacoViviTantra.Data.Repositories
{
    public class EnderecoRepository : IEnderecoRepository
    {
        protected readonly EspacoViviTantraContext _espacoViviTantraContext;

        public EnderecoRepository(EspacoViviTantraContext espacoViviTantraContext)
        {
            _espacoViviTantraContext = espacoViviTantraContext;
        }
        public List<Endereco> ListarEnderecos()
        {
            return _espacoViviTantraContext.Enderecos.ToList();
        }

        public Endereco ObterEnderecoPorCep(string cep)
        {
            return _espacoViviTantraContext.Enderecos.FirstOrDefault(e => e.Cep == cep);
        }

        public Endereco ObterEnderecoPorId(int id)
        {
            return _espacoViviTantraContext.Enderecos.FirstOrDefault(e => e.Id == id);
        }

        public Endereco ObterEnderecoPorLogradouro(string logradouro)
        {
            return _espacoViviTantraContext.Enderecos.FirstOrDefault(e => e.Logradouro == logradouro);
        }

        public void Salvar(Endereco endereco)
        {
            _espacoViviTantraContext.Enderecos.Add(endereco);
            _espacoViviTantraContext.SaveChanges();
        }
    }
}