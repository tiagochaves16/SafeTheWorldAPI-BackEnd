using System.ComponentModel.DataAnnotations;

namespace Business.Models
{
    public class Endereco 
    {

        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        [Required]
        public string Rua { get; set; }
        [Required]
        public string Numero { get; set; }
        [Required]
        public string Cep { get; set; }
        [Required]
        public string Bairro { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        public string Estado { get; set; }

        public Endereco(string nome, string rua, string numero, string cep, string bairro, string cidade, string estado)
        {
            Nome = nome;
            Rua = rua;
            Numero = numero;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }
    }
}
