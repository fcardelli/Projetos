using System;

namespace EspacoViviTantra.MVC.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public TipoUsuario Tipo { get; set; }
        public UsuarioStatus Status { get; set; }
        public Pessoa Pessoa {get; set;}
        public DateTime DataCadastro { get; set; }
    }
}