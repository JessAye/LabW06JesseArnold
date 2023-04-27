using LabW06JesseArnold.Models.ViewModels;
using LabW06JesseArnold.Services;
using Microsoft.AspNetCore.Mvc;

namespace LabW06JesseArnold.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepo;
        public async Task<IActionResult> Index()
        {
            var users = await _userRepo.ReadAllAsync();
            var userList = users
               .Select(u => new UserListVM
               {
                   Email = u.Email,
                   UserName = u.UserName,
                   NumberOfRoles = u.Roles.Count,
                   RoleNames = string.Join(",", u.Roles.ToArray())
               });
            return View(userList);
        }

    }
}
