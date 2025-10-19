namespace Demo_Omar_Emad_Hamdy_Senior3.Repos
{
    public interface ILoyaltyCard
    {
        public Task<IEnumerable<object>> GetAllCardsWithRelated();
    }
}
