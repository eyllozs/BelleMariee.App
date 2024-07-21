﻿using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BelleMariee.App.DataAccess.Identity;
using BelleMariee.App.Entity.Services;
using BelleMariee.App.Entity.ViewModels;
using BelleMariee.App.DataAccess.Contexts;

namespace BelleMariee.App.Service.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IMapper _mapper;
        private readonly BelleDbContext _context;

        public AccountService(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, SignInManager<AppUser> signInManager, IMapper mapper, BelleDbContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _mapper = mapper;
            _context = context;
        }
        public async Task<List<RoleViewModel>> GetAllRoles()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return _mapper.Map<List<RoleViewModel>>(roles);
        }
        public async Task<string> CreateRoleAsync(RoleViewModel model)
        {
            string message = string.Empty;
            AppRole role = new AppRole()
            {
                Name = model.Name,
                Description = model.Description
            };
            var identityResult = await _roleManager.CreateAsync(role);

            if (identityResult.Succeeded)
            {
                message = "OK";
            }
            else
            {
                foreach (var error in identityResult.Errors)
                {
                    message = error.Description;
                }
            }
            return message;
        }

        public async Task<string> CreateUserAsync(RegisterViewModel model)
        {
            string message = string.Empty;
            AppUser user = new AppUser()
            {
                Name = model.FirstName,
                Surname = model.LastName,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                UserName = model.UserName
            };
            var identityResult = await _userManager.CreateAsync(user, model.ConfirmPassword);

            if (identityResult.Succeeded)
            {
                message = "OK";
            }
            else
            {
                foreach (var error in identityResult.Errors)
                {
                    message = error.Description;
                }
            }
            return message;
        }

        public async Task<UserViewModel> Find(string username)
        {
            var user = await _userManager.FindByNameAsync(username);
            return _mapper.Map<UserViewModel>(user);
        }

        public async Task<string> FindByNameAsync(LoginViewModel model)
        {
            string message = string.Empty;
            var user = await _userManager.FindByNameAsync(model.UserName);
            if (user == null)
            {
                message = "kullanıcı bulunamadı!";
                return message;
            }
            var signInResult = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
            if (signInResult.Succeeded)
            {
                message = "OK";
            }
            return message;
        }

        public async Task SignOutAsync()
        {
            await _signInManager.SignOutAsync();
        }

		public async Task<List<UserViewModel>> GetAllUsers()
		{
			var users = await _userManager.Users.ToListAsync();
            return  _mapper.Map<List<UserViewModel>>(users);
		}

		public async Task<UsersInOrOutViewModel> GetAllUsersWithRole(string id)
		{
			var role = await FindRoleByIdAsync(id);

            var usersInRole = new List<AppUser>();
			var usersOutRole = new List<AppUser>();

            var users = await _userManager.Users.ToListAsync();

            foreach (var user in users)
            {
                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    usersInRole.Add(user);  //Bu rolde bulunan kullanıcıların listesi
                }
                else
                {
                    usersOutRole.Add(user);  //Bu rolde olmayan kullanıcıların listesi
                }
            }
            UsersInOrOutViewModel model = new UsersInOrOutViewModel()
            {
                Role = role,
                UsersInRole = _mapper.Map <List<UserViewModel>>(usersInRole),
				UsersOutRole = _mapper.Map<List<UserViewModel>>(usersOutRole),
			};
            return model;
        }

        public async Task<RoleViewModel> FindRoleByIdAsync(string id)
		{
            var role = await _roleManager.FindByIdAsync(id);
            return _mapper.Map<RoleViewModel>(role);
		}

        public async Task<string> EditRoleListAsync(EditRoleViewModel model)
        {
            string msg = "OK";
            foreach (var userId in model.UserIdsToAdd ?? new string[] {})
            {
                var user = await _userManager.FindByIdAsync(userId);
                if (user != null)
                {
                    var result = await _userManager.AddToRoleAsync(user, model.RoleName);
                    if (!result.Succeeded)
                    {
                         msg = $"{user.UserName} role eklenemedi.";
                    }
                }
            }
            foreach (var userId in model.UserIdsToDelete ?? new string[] { })
            {
                var user = await _userManager.FindByIdAsync(userId);
                if (user != null)
                {
                    var result = await _userManager.RemoveFromRoleAsync(user, model.RoleName);
                    if (!result.Succeeded)
                    {
                        msg = $"{user.UserName} rolden çıkarılamadı.";
                    }
                }
            }


            return msg;
        }

        public async Task<RoleViewModel> GetRoleByIdAsync(int roleId)
        {
            // roleId'ye göre rolü veritabanından çekin ve RoleViewModel'e dönüştürün.
            // Örneğin:
            var role = await _context.Roles.FindAsync(roleId); // _context, veritabanı bağlamınız (DbContext).
            if (role == null) return null;

            var roleViewModel = new RoleViewModel
            {
                Id = role.Id,
                Name = role.Name,
                Description = role.Description
                
            };
            return roleViewModel;
        }

        public async Task<string> DeleteRoleAsync(int roleId)
        {
            var role = await _context.Roles.FindAsync(roleId); // _context, veritabanı bağlamınız (DbContext).
            if (role == null) return "Role not found";

            _context.Roles.Remove(role);
            await _context.SaveChangesAsync();
            return "OK";
        }
    }
}
