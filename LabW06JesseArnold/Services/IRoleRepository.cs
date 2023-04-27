using Microsoft.AspNetCore.Identity;

namespace LabW06JesseArnold.Services
{
    public interface IRoleRepository
    {
        IQueryable<IdentityRole> ReadAll();
    }
}
