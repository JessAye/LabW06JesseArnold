using LabW06JesseArnold.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace LabW06JesseArnold.Services
{
    public class DbUserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _db;

        public DbUserRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<ApplicationUser?> ReadAsyncByUserName(string username)
        {
            return await _db.Users.FirstOrDefaultAsync(u => u.UserName == username);
        }
    }
}
