using LabW06JesseArnold.Models.Entities;

namespace LabW06JesseArnold.Services
{
    public interface IUserRepository
    {
        Task<ApplicationUser?> ReadAsyncByUserName(string username);

        Task<IQueryable<ApplicationUser>> ReadAllAsync();

        Task<bool>AssignRoleAsync(string userName, string role);



    }
}
