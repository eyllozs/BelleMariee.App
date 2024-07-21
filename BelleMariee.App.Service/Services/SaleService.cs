using BelleMariee.App.Entity.Services;
using BelleMariee.App.Entity.ViewModels;
using BelleMariee.App.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BelleMariee.App.DataAccess.Contexts;
using AutoMapper;

namespace BelleMariee.App.Service.Services
{
    public class SaleService : ISaleService
    {
        private readonly BelleDbContext _context;
        private readonly IMapper _mapper;

        public SaleService(BelleDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task Add(SaleViewModel model)
        {



            //await _context.Sales.AddAsync(sale);
            //await _context.SaveChangesAsync();
        }

        public async Task<int> AddSale(SaleViewModel model)
        {
            var sale = _mapper.Map<Sale>(model);

            await _context.Sales.AddAsync(sale);
            await _context.SaveChangesAsync();

            return sale.Id;
        }

        public async Task Delete(int id)
        {
            var sale = await _context.Sales.FindAsync(id);
            if (sale != null)
            {
                _context.Sales.Remove(sale);
                await _context.SaveChangesAsync();
            }
        }

        public async Task Delete(SaleViewModel model)
        {
            var sale = await _context.Sales.FindAsync(model.Id);
            if (sale != null)
            {
                _context.Sales.Remove(sale);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<SaleViewModel> Get(int id)
        {
            var sale = await _context.Sales.FindAsync(id);
            if (sale == null)
                return null;

            return new SaleViewModel
            {
                
                Id = sale.Id,
                CustomerId = sale.CustomerId,
                Date = DateTime.Now,
                TotalPrice = sale.TotalPrice,
                TotalQuantity = sale.TotalQuantity
                
            };
        }

        public async Task<IEnumerable<SaleViewModel>> GetAll()
        {
            var sales = await _context.Sales.ToListAsync();
            return sales.Select(s => new SaleViewModel
            {
                
                Id = s.Id,
                CustomerId= s.CustomerId,
                Date = DateTime.Now,
                TotalPrice = s.TotalPrice,
                TotalQuantity = s.TotalQuantity

            }).ToList();
        }

        public async Task Update(SaleViewModel model)
        {
            var sale = await _context.Sales.FindAsync(model.Id);
            if (sale != null)
            {
                
                sale.Id = model.Id;
                sale.CustomerId = model.CustomerId;
                sale.Date = DateTime.Now;
                sale.TotalPrice = model.TotalPrice;
                sale.TotalQuantity = model.TotalQuantity;
                

                _context.Sales.Update(sale);
                await _context.SaveChangesAsync();
            }
        }
    }
}