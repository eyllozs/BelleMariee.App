using BelleMariee.App.Entity.Services;
using BelleMariee.App.Entity.ViewModels;
using BelleMariee.App.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BelleMariee.App.DataAccess.Contexts;
using BelleMariee.App.Service.Interfaces;

namespace BelleMariee.App.Service.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly BelleDbContext _context;

        public CustomerService(BelleDbContext context)
        {
            _context = context;
        }

        public async Task Add(CustomerViewModel model)
        {
            var customer = new Customer
            {
                Id = model.Id,
                Name = model.Name,
                Address = model.Address,
                Email = model.Email,
                Password = model.Password,
                Phone = model.Phone,
                
            };

            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
        }

        public async Task Create(Customer customer)
        {
            if (string.IsNullOrEmpty(customer.Password))
            {
                throw new ArgumentException("Password cannot be null or empty", nameof(customer.Password));
            }

            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                await _context.SaveChangesAsync();
            }
        }

        public async Task Delete(CustomerViewModel model)
        {
            var customer = await _context.Customers.FindAsync(model.Id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<CustomerViewModel> Get(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
                return null;

            return new CustomerViewModel
            {
                Id = customer.Id,
                Name = customer.Name,
                Address = customer.Address,
                Email = customer.Email,
                Password = customer.Password,
                Phone = customer.Phone,
            };
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer> GetById(int id)
        {
            return await _context.Customers.FindAsync(id);
        }

        public async Task Update(Customer customer)
        {
            _context.Customers.Update(customer);
            await _context.SaveChangesAsync();
        }

        public async Task<Customer> GetByEmailAndPassword(string email, string password)
        {
            return await _context.Customers
                .FirstOrDefaultAsync(c => c.Email == email && c.Password == password);
        }

    }
}
