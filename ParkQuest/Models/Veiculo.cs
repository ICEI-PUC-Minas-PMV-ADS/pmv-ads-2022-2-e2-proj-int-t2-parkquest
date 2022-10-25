using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ParkQuest.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {        
        [Key]
        public int id { get; set; }
        //public Usuario usuario { get; set; }
        [Required(ErrorMessage = "Obrigatório Informar a placa!")]
        public string placa { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string cor { get; set; }

        public Veiculo() { }


        public Veiculo(Usuario usuario, string placa, string marca, string modelo, string cor)
        {
            this.placa = placa;
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
        }


    }
}
