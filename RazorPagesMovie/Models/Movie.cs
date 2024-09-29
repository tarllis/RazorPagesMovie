using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        [Display(Name ="Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }
        public string? Genero { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Preço { get; set; }
    }
}
