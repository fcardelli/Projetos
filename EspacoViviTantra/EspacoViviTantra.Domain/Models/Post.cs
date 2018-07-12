using System;

namespace EspacoViviTantra.Domain.Models
{
    public class Post
    {
        public int Id { get; set; }
        public TipoPost Tipo { get; set; }
        public DateTime Data { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public Pessoa Pessoa { get; set; }
        public Imagem Imagem { get; set; }
    }
}