
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{

    [Table("Usuario")]

    public class Usuario
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Obrigatório Informar o nome!")]
        public string nome { get; set; }
        [Required(ErrorMessage = "Obrigatório Informar a senha!")]
        public string senha { get; set; }
        [Required(ErrorMessage = "Obrigatório Informar a email!")]
        public string email { get; set; }
        [Required(ErrorMessage = "Obrigatório Informar a CPF!")]
        public string cpf { get; set; }

        public Usuario () { }

        public Usuario(string nome, string senha, string email, string cpf)
        {
            this.nome = nome;
            this.senha = senha;
            this.email = email;
            this.cpf = cpf;
        }
    }
}
