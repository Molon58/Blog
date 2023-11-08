using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wissen.Bright.BlogProject.App.Entity.ViewModels;

namespace Wissen.Bright.BlogProject.App.Entity.Services
{
    public interface IAccountService
    {
        Task<string> CreateUserAsync(RegisterViewModel model);
        Task<string> FindByNameAsync(LoginViewModel model);

        Task<string> CreateRoleAsync(RoleViewModel model);

        Task<List<RoleViewModel>> GetAllRoles();

        Task<RoleViewModel> FindByIdAsync(string id);

        Task<UsersInOrOutViewModel> GetAllUsersWithRole(string id);

        Task<string> EditRoleListAsync(EditRoleViewModel model);
        Task<UserViewModel> Find(string username);


		Task LogoutAsync();
    }
}
