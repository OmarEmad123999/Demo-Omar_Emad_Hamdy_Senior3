using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Demo_Omar_Emad_Hamdy_Senior3.Models
{
    public class ArtPiece
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Title { get; set; }
        [MaxLength(500)]
        public string? Description { get; set; }
        [Required]
        [Range(1,int.MaxValue)]
        public decimal? Price { get; set; }

        public List<Category> Categories { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

    }
}




















/*
 * builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("conn")));
builder.Services.AddScoped(typeof(IGenericRepo<>), typeof(GenericRepo<>));
builder.Services.AddScoped<IBookRepo, BookRepo>();
 * 
 */