using System;

namespace EspacoViviTantra.Domain.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public Telefone Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
    }
}