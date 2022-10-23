
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class Usuario
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Obrigatório Informar o nome do usuário!")]
        public string nome { get; set; }
        [Required(ErrorMessage = "Obrigatório Informar o login!")]
        public string login { get; set; }
        [Required(ErrorMessage = "Obrigatório Informar a senha!")]
        public string senha { get; set; }
        public string email { get; set; }

        public Usuario(string nome, string login, string senha, string email)
        {
            this.nome = nome;
            this.login = login;
            this.senha = senha;
            this.email = email;
        }
    }
}
