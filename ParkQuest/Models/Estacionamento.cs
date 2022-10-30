using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{

    [Table("Estacionamento")]

    public class Estacionamento
    {
        [Key]
        public int id { get; set; }
        [Display (Name ="nome estabelecimento")]
        [Required(ErrorMessage = "Obrigatório Informar o nome estabelecimento!")]
        public string nome { get; set; }
        [Display(Name = "endereço")]
        [Required(ErrorMessage = "Obrigatório Informar o endereço!")]
        public string endereco { get; set; }
        [Display(Name = "quantidade de vagas")]
        [Required(ErrorMessage = "Obrigatório Informar a quantidade de vagas!")]
        public string vagas { get; set; }
        [Required(ErrorMessage = "Obrigatório Informar email!")]
        public string email { get; set; }
        [Required(ErrorMessage = "Obrigatório Informar o CNPJ!")]
        public string cnpj { get; set; }
        [Required(ErrorMessage = "Obrigatório Informar a cidade!")]
        public string cidade { get; set; }
        [Display(Name = "valor por hora")]
        [Required(ErrorMessage = "Obrigatório Informar o valor por hora!")]
        public string valor { get; set; }
        [Required(ErrorMessage = "Obrigatório Informar a senha!")]
        public string senha { get; set; }


        public Estacionamento () { }

        public Estacionamento(string nome, string endereco, string vagas, string email, string cnpj, string cidade, string valor, string senha)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.vagas = vagas;
            this.email = email;
            this.cnpj = cnpj;
            this.cidade = cidade;
            this.valor = valor;
            this.senha = senha;
        }
    }
}