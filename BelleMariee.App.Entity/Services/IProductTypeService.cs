using BelleMariee.App.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelleMariee.App.Entity.Services
{
    public interface IProductTypeService
    {
        Task<List<ProductTypeViewModel>> GetAll();
    }
}
