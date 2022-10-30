
namespace Dominio.Entidades
{
    public class Cliente
    {
        public int id { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
