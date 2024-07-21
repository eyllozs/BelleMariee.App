using BelleMariee.App.Entity.Entities;
using BelleMariee.App.Entity.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BelleMariee.App.Service.Interfaces
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetAll();
        Task<Customer> GetById(int id);
        Task<CustomerViewModel> Get(int id);
        Task Add(CustomerViewModel model);
        Task Update(Customer customer);
        Task Delete(int id);
        Task Delete(CustomerViewModel model);
        Task Create(Customer customer);
        Task<Customer> GetByEmailAndPassword(string email, string password);
    }
}
