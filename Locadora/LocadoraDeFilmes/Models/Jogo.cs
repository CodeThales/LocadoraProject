using System;
using System.ComponentModel.DataAnnotations;


namespace LocadoraDeFilmes.Models
{
    public class Jogo
    {

        [Display(Name ="#")]
        public int Id { get; set; }

        [Required(ErrorMessage ="Informe o nome do jogo")]
        public string Nome { get; set; }

        [Display(Name ="Preço")]
        [Required(ErrorMessage = "Informe o preço do jogo")]
        public double Preco { get; set; }

        [Display(Name ="Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime Lancamento { get; set; }

    }
}
