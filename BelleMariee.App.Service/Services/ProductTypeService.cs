using AutoMapper;
using BelleMariee.App.Entity.Entities;
using BelleMariee.App.Entity.Services;
using BelleMariee.App.Entity.UnitOfWorks;
using BelleMariee.App.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelleMariee.App.Service.Services
{
    public class ProductTypeService : IProductTypeService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public ProductTypeService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<List<ProductTypeViewModel>> GetAll()
        {
            var list = await _uow.GetRepository<ProductType>().GetAllAsync();

            return _mapper.Map<List<ProductTypeViewModel>>(list);
        }
    }
}
