using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FutScout_2023.Models
{
    
    [Table("Clubes")]
    public class Clube
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Obrigatório informar o nome do clube!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Estado do clube!")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Obrigatório informar informar a Série do clube!")]
        public string Série { get; set; }

        [Display(Name = "Gols em 2021")]
        public int gols2021 { get; set; }

        [Display(Name = "Gols em 2022")]
        public int gols2022 { get; set; }

        [Display(Name = "Gols em 2023")]
        public int gols2023 { get; set; }
    }
}