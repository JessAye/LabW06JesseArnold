using LabW06JesseArnold.Models.Entities;

namespace LabW06JesseArnold.Services
{
    public interface IUserRepository
    {
        Task<ApplicationUser?> ReadAsync(string username);

        Task<ApplicationUser> CreateAsync(ApplicationUser user, string password);

     
    }
}
