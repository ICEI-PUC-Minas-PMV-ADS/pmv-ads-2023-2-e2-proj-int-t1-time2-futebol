using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FutScout_2023.Models
{
    [Table("Atacantes")]
    public class Atacante
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Inserir o dado")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Inserir o dado")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Inserir o dado")]
        public string Clube { get; set; }

        [Required(ErrorMessage = "Inserir o dado")]
        [Display(Name = "Partidas em 2023")]
        public int Partidas2023 { get; set; }

        [Required(ErrorMessage = "Inserir o dado")]
        [Display(Name = "Gols em 2023")]
        public int Gols2023 { get; set; }

        [Required(ErrorMessage = "Inserir o dado")]
        [Display(Name = "Assists em 2023")]
        public int Assists2023 { get; set; }

        [Required(ErrorMessage = "Inserir o dado")]
        [Display(Name = "Partidas em 2022")]
        public int Partidas2022 { get; set; }

        [Required(ErrorMessage = "Inserir o dado")]
        [Display(Name = "Gols em 2022")]
        public int Gols2022 { get; set; }

        [Required(ErrorMessage = "Inserir o dado")]
        [Display(Name = "Assists em 2022")]
        public int Assists2022 { get; set; }

        [Display(Name = "Partidas em 2021")]
        public int Partidas2021 { get; set; }

        [Display(Name = "Gols em 2021")]
        public int Gols2021 { get; set; }

        [Display(Name = "Assists em 2021")]
        public int Assists2021 { get; set; }

    }
}
