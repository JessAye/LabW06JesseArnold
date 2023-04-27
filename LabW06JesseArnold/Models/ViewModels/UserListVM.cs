using System.ComponentModel;

namespace LabW06JesseArnold.Models.ViewModels
{
    public class UserListVM
    {
        public string Email { get; set; }

        public string UserName { get; set; }

        [DisplayName("Number of roles")]
        public int NumberOfRoles { get; set; }
        [DisplayName("Role Name")]
       public string RoleNames { get; set; }
    }
}

