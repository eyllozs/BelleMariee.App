using BelleMariee.App.Entity.Entities;
using BelleMariee.App.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelleMariee.App.Entity.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductViewModel>> GetAll();
        Task<ProductViewModel> Get(int id);
        Task Add(ProductViewModel model);
        Task<Product> GetByIdAsync(int id);
        Task<List<string>> GetAvailableSizes(int categoryId, int productTypeId);
        Task Update(ProductViewModel product);
        Task Delete(int id);
    }
}
