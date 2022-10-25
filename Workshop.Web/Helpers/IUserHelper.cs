﻿using Microsoft.AspNetCore.Identity;
using Workshop.Web.Data.Entities;
using System.Threading.Tasks;
using Workshop.Web.Models.ViewModels;

namespace Workshop.Web.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task<SignInResult> LoginAsync (LoginViewModel model);

        Task LogoutAsync ();

        Task<IdentityResult> UpdateUserAsync (User user);

        Task<IdentityResult> ChangePasswordAsync (User user, string oldPassword, string newPassword);
        Task CheckRoleAsync (string roleName);
        Task AddUserToRoleAsync (User user, string roleName);
    }
}
