using BelleMariee.App.Entity.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BelleMariee.App.Entity.Services
{
    public interface ISaleService
    {
        Task<IEnumerable<SaleViewModel>> GetAll();
        Task<SaleViewModel> Get(int id);
        Task Add(SaleViewModel model);
        Task<int> AddSale(SaleViewModel model);
        Task Update(SaleViewModel model);
        Task Delete(int id);
        Task Delete(SaleViewModel model);
    }
}
