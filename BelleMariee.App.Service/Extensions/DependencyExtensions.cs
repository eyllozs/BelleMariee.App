using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BelleMariee.App.DataAccess.Contexts;
using BelleMariee.App.DataAccess.Identity;
using BelleMariee.App.DataAccess.Repositories;
using BelleMariee.App.DataAccess.UnitOfWorks;
using BelleMariee.App.Entity.Repositories;
using BelleMariee.App.Entity.Services;
using BelleMariee.App.Entity.UnitOfWorks;
using BelleMariee.App.Service.Services;
using BelleMariee.App.Mapping;
using BelleMariee.App.Service.Interfaces;

namespace BelleMariee.App.Service.Extensions
{
	public static class DependencyExtensions
	{
		public static void AddExtensions(this IServiceCollection services)
		{
			services.AddIdentity<AppUser, AppRole>(
				opt =>
				{
					opt.Password.RequireNonAlphanumeric = false;
					opt.Password.RequiredLength = 3;
					opt.Password.RequireLowercase = false;
					opt.Password.RequireUppercase = false;
					opt.Password.RequireDigit = false;

					opt.User.RequireUniqueEmail = true;  //aynı email adresinin girilmesine izin vermez
														 //opt.User.AllowedUserNameCharacters = "abcdefghijklmonpqrstuvwxyz0123456789"; //kullanıcı adını girerken sadece bu karakterlere izin verilir

					opt.Lockout.MaxFailedAccessAttempts = 3; //default=5;
					opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1); //default=5
				}
			).AddEntityFrameworkStores<BelleDbContext>();

            services.ConfigureApplicationCookie(opt =>
            {
                opt.LoginPath = new PathString("/Account/Login");
                opt.LogoutPath = new PathString("/Account/Logout");
                //opt.AccessDeniedPath = new PathString("/Account/AccessDenied");
                opt.ExpireTimeSpan = TimeSpan.FromMinutes(10);
                opt.SlidingExpiration = true; //10 dk. dolmadan kullanıcı yeniden login olursa süre baştan başlar.

                opt.Cookie = new CookieBuilder()
                {
                    Name = "Identity.App.Cookie",
                    HttpOnly = true
                };
            });
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped(typeof(IAccountService), typeof(AccountService));
            services.AddScoped<IProductTypeService, ProductTypeService>();
            services.AddScoped<ISaleService, SaleService>();
            services.AddScoped<IProductSaleDetailsService, ProductSaleDetailsService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IAccountService, AccountService>();


            services.AddAutoMapper(typeof(MappingProfile));
        }
    }
}
