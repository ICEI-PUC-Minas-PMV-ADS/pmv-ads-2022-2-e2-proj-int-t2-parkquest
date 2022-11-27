
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    public class Reserve
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Data de Entrada:")]
        [Required(ErrorMessage = "Obrigatório Informar a data de entrada!")]
        public DateTime dataEntrada { get; set; }

        [Display(Name = "Horário de Entrada:")]
        [Required(ErrorMessage = "Obrigatório Informar a horário de entrada!")]
        public string horarioEntrada { get; set; }

        [Display(Name = "Data de Saída:")]
        [Required(ErrorMessage = "Obrigatório Informar a data de saída!")]
        public DateTime dataSaida { get; set; }

        [Display(Name = "Horário de Entrada:")]
        [Required(ErrorMessage = "Obrigatório Informar a horário de entrada!")]
        public string horarioSaida { get; set; }

        [Display(Name = "Valor por hora:")]
        [Required(ErrorMessage = "Obrigatório Informar o valor por hora!")]
        [Column(TypeName = "decimal(18,2)")]

        public decimal custoDia { get; set; }

        [Display(Name = "Custo total:")]
        [Required(ErrorMessage = "Obrigatório Informar o valor total!")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal custoTotal { get; set; }


        public int EstacionamentoID { get; set; }
        [ForeignKey("EstacionamentoID")]

        public Estacionamento Estacionamento { get; set; }

        public Reserve() { }

        public Reserve(DateTime dataEntrada, string horarioEntrada, DateTime dataSaida, string horarioSaida, decimal custoDia, decimal custoTotal)
        {
            this.dataEntrada = dataEntrada;
            this.horarioEntrada = horarioEntrada;
            this.dataSaida = dataSaida;
            this.horarioSaida = horarioSaida;
            this.custoDia = custoDia;
            this.custoTotal = custoTotal;
        }
    }
}

