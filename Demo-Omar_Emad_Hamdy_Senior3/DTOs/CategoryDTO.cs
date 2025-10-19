using Demo_Omar_Emad_Hamdy_Senior3.Models;
using System.ComponentModel.DataAnnotations;

namespace Demo_Omar_Emad_Hamdy_Senior3.DTOs
{
    public class CategoryDTO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<ArtPiece> Pieces { get; set; }
    }
    public class CreateCategoryDTO
    {
        [Required]
        public string Name { get; set; }
        public List<ArtPiece> Pieces { get; set; }
    }

}
