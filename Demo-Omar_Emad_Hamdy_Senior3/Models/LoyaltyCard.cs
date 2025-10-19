using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Demo_Omar_Emad_Hamdy_Senior3.Models
{
    [Index(nameof(CardNumber),IsUnique =true)]
    public class LoyaltyCard
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CardNumber { get; set; }
        public decimal? Balance { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
    }
}
