using AutoMapper;
using BelleMariee.App.DataAccess.Contexts;
using BelleMariee.App.Entity.Entities;
using BelleMariee.App.Entity.Services;
using BelleMariee.App.Entity.UnitOfWorks;
using BelleMariee.App.Entity.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelleMariee.App.Service.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        private readonly BelleDbContext _context;
        public ProductService(IUnitOfWork uow, IMapper mapper, BelleDbContext context)
        {
            _uow = uow;
            _mapper = mapper;
            _context = context;
        }
        public async Task<IEnumerable<ProductViewModel>> GetAll()
        {
            //_uow.GetRepository<Article>() -> Repository<Article> karşılık gelir.
            var list = await _uow.GetRepository<Product>().GetAllAsync();

            return _mapper.Map<List<ProductViewModel>>(list);
        }
        public async Task Add(ProductViewModel model)
        {
            await _uow.GetRepository<Product>().Add(_mapper.Map<Product>(model));
            await _uow.CommitAsync();  //SaveChangesAsync();
        }

        public async Task<ProductViewModel> Get(int id)
        {
            var article = await _uow.GetRepository<Product>().GetByIdAsync(id);
            return _mapper.Map<ProductViewModel>(article);
        }
        public async Task<Product> GetByIdAsync(int id)
        {
            // Burada olası null başvuru uyarısını önlemek için null kontrolü ekliyoruz
            return await _context.Products.FindAsync(id) ?? throw new Exception("Product not found");
        }

        public async Task<List<string>> GetAvailableSizes(int categoryId, int productTypeId)
        {
            var sizes = await _context.Products
                .Where(p => p.CategoryId == categoryId && p.ProductTypeId == productTypeId)
                .Select(p => p.Size)
                .Distinct()
                .ToListAsync();

            // Null kontrolü ekliyoruz ve null değerleri listeden çıkarıyoruz
            return sizes.Where(size => size != null).Select(size => size!).ToList();
        }

        public async Task Update(ProductViewModel productViewModel)
        {
            var product = _mapper.Map<Product>(productViewModel);
            _uow.GetRepository<Product>().Update(product);
            await _uow.CommitAsync();
        }

        public async Task Delete(int id)
        {
            var product = await _uow.GetRepository<Product>().GetByIdAsync(id);

            if (product != null)
            {
                _uow.GetRepository<Product>().Delete(product);
                await _uow.CommitAsync(); // or SaveChangesAsync()
            }
            else
            {
                throw new InvalidOperationException($"Product with ID {id} not found.");
            }
        }



    }
}
