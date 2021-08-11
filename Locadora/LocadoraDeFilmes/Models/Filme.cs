using System;
using System.ComponentModel.DataAnnotations;


namespace LocadoraDeFilmes.Models
{
    public class Filme
    {
        [Display(Name = "#")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do filme")]
        [Display(Name = "Nome do filme")]        
        public string Nome { get; set; }

        public string Sinopse { get; set; }

        [Required(ErrorMessage = "Informe o preço do filme")]
        [Display(Name = "Preço")]        
        public double Preco { get; set; }

        [Display(Name = "Data de Lançamento")]        
        [DataType(DataType.Date)]
        public DateTime Lancamento { get; set; }

        [Required(ErrorMessage = "Informe o tempo de duração do filme")]
        [Display(Name = "Duração em Minutos")]        
        public int Duracao { get; set; }

    }
}
