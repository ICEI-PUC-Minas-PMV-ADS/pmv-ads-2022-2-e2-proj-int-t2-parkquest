using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{

    [Table("Acesso")]
    public class Acesso
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Obrigatório Informar a email!")]
        public string email { get; set; }
        [Required(ErrorMessage = "Obrigatório Informar a senha!")]
        public string senha { get; set; }

        public Acesso() { }

        public Acesso(string email, string senha)
        {
            this.email = email;
            this.senha = senha;
        }
    }
}

