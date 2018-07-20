namespace EspacoViviTantra.MVC.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public TipoEndereco Tipo { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public Estado Estado { get; set; }
        public Cidade Cidade { get; set; }
        public Bairro Bairro { get; set; }
    }
}