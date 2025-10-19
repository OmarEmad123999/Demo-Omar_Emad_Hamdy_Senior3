using Demo_Omar_Emad_Hamdy_Senior3.Models;

namespace Demo_Omar_Emad_Hamdy_Senior3.Repos
{
    public interface IArtPiece:IGenericRepo<ArtPiece>
    {
        public Task<IEnumerable<object>> GetArtPieceAsync();
    }
}
