using Demo_Omar_Emad_Hamdy_Senior3.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo_Omar_Emad_Hamdy_Senior3.Repos
{
    public class ArtPieceRepo : GenericRepo<ArtPiece>, IArtPiece
    {
        readonly AppDbContext _db;
        public ArtPieceRepo(AppDbContext db) : base(db)
        {
            _db = db;
        }

        //public Task<IEnumerable<object>> GetArtPieceAsync()
        //{
        //   var Pieces= _db.Pieces.Include(x=> x.Customer).Include(x=> x.Categories).ToList();

        //}
    }
}
