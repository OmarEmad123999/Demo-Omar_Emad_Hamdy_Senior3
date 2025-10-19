using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Demo_Omar_Emad_Hamdy_Senior3.Models
{
    [Index(nameof(Name),IsUnique = true)]
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<ArtPiece> Pieces { get; set; }
    }
}
