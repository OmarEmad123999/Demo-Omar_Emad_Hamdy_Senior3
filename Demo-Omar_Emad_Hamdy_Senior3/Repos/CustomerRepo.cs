using Demo_Omar_Emad_Hamdy_Senior3.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo_Omar_Emad_Hamdy_Senior3.Repos
{
    public class CustomerRepo : GenericRepo<Customer>, ICustomerRepo
    {
        readonly AppDbContext _db;
        public CustomerRepo(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<IEnumerable<object>> GetAllWithRelated()
        {
            var customers = _db.Customers.Include(c => c.ArtPieces).Include(c=> c.LoyaltyCard).OrderBy(c=> c.LoyaltyCard.Balance).ToList();

            var reult = customers.Select(x => new
            {
                Id = x.Id,
                Name = x.Name,
                Email = x.Email,
                Phone = x.Phone,
                ArtsPieces = x.ArtPieces,
                Balance = x.LoyaltyCard.Balance,
                CardNumber = x.LoyaltyCard.CardNumber,
            }).ToList();

            return  reult;
        }
    }
}
























/*
 
  public async Task<IEnumerable<object>> GetAllStudentsAsync()
 {
     var students = await _db.students
         .Include(s => s.Class)
         .Include(s => s.Subjects)
         .Include(s => s.Profile)
         .OrderBy(s => s.Profile.DateOfBirth)
         .ToListAsync();

     var grouped = students
         .GroupBy(s => s.Class.Grade).Select(g => new
         {
             Grade = g.Key,
             Count = g.Count(),
             Students = g.Select(s => new
             {
                 s.Id,
                 s.Name,
                 s.Email,
                 s.Phone,
                 Class = new
                 {
                     s.Class.Id,
                     s.Class.Name,
                     s.Class.Grade
                 },
                 Subjects = s.Subjects.Select(sub => new
                 {
                     sub.Id,
                     sub.SubjectName
                 }).ToList(),
                 Profile = new
                 {
                     s.Profile.DateOfBirth,
                     s.Profile.Address
                 }
             }).ToList()
         }).ToList();

     return grouped;
 }
 */