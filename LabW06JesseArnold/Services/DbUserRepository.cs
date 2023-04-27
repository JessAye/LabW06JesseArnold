using LabW06JesseArnold.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LabW06JesseArnold.Services
{
    public class DbUserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public DbUserRepository(ApplicationDbContext db, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public async Task<ApplicationUser?> ReadAsyncByUserName(string username)
        {
            var user = await _db.Users.FirstOrDefaultAsync(u => u.UserName == username);
            if (user != null)
            {
                user.Roles = await _userManager.GetRolesAsync(user);
            }
            return user;
        }

        public async Task<IQueryable<ApplicationUser>> ReadAllAsync()
        {
            var users = _db.Users;
            // Read the roles for each user in the database
            foreach (var user in users)
            {
                user.Roles = await _userManager.GetRolesAsync(user);
            }
            return users;
        }

    }
}
