using LabW06JesseArnold.Models.Entities;
using Microsoft.AspNetCore.Identity;

namespace LabW06JesseArnold.Services
{
    public interface IRoleRepository
    {
        IQueryable<IdentityRole> ReadAll();
        
    }
}
