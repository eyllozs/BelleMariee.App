using BelleMariee.App.Entity.Entities;
using BelleMariee.App.Entity.ViewModels;
using BelleMariee.App.Service.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BelleMariee.App.Service.Interfaces
{
    public interface IProductSaleDetailsService
    {
        Task<IEnumerable<ProductSaleDetailsViewModel>> GetAll();
        Task<ProductSaleDetailsViewModel> Get(int id);
        Task Add(ProductSaleDetailsViewModel model);
        Task Update(ProductSaleDetailsViewModel model);
        Task Delete(int id);
        Task Delete(ProductSaleDetailsViewModel model);
        Task<bool> AddRange(List<SepetDetay>? sepet, int satisId);
    }
}
