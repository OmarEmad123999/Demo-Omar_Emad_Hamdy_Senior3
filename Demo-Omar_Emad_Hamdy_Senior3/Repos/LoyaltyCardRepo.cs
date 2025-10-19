using Demo_Omar_Emad_Hamdy_Senior3.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo_Omar_Emad_Hamdy_Senior3.Repos
{
    public class LoyaltyCardRepo : GenericRepo<LoyaltyCard>, ILoyaltyCard
    {
        readonly AppDbContext _db;
        public LoyaltyCardRepo(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<IEnumerable<object>> GetAllCardsWithRelated()
        {
            var cards = _db.LoyaltyCards.Include(x=> x.Customer).OrderBy(x=> x.Customer.Name).ToList();

            var Cards = cards.Select(x => new
            {
                Id = x.Id,
                Cardnumber = x.CardNumber,
                Balance = x.Balance,
                customername = x.Customer.Name
            }).ToList();

            return Cards;
        }
    }
}
