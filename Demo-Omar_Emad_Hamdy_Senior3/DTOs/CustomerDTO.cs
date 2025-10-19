using Demo_Omar_Emad_Hamdy_Senior3.Models;
using System.ComponentModel.DataAnnotations;

namespace Demo_Omar_Emad_Hamdy_Senior3.DTOs
{
    public class CustomerDTO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        public LoyaltyCard LoyaltyCard { get; set; }
        public List<ArtPiece> ArtPieces { get; set; }
    }
}
