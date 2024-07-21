using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BelleMariee.App.DataAccess.Identity;
using BelleMariee.App.Entity.Entities;
using BelleMariee.App.Entity.ViewModels;




namespace BelleMariee.App.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductViewModel>().ReverseMap();
            CreateMap<Category, CategoryViewModel>().ReverseMap();
            CreateMap<ProductType, ProductTypeViewModel>().ReverseMap();
            CreateMap<Customer, CustomerViewModel>().ReverseMap();
            CreateMap<Sale, SaleViewModel>().ReverseMap();
            CreateMap<ProductSaleDetails, ProductSaleDetailsViewModel>().ReverseMap();
            CreateMap<AppUser, LoginViewModel>().ReverseMap();
            CreateMap<AppRole, RoleViewModel>().ReverseMap();
            CreateMap<AppUser, UserViewModel>();
        }
    }
}
