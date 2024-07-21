using BelleMariee.App.DataAccess.Contexts;
using BelleMariee.App.Entity.Entities;
using BelleMariee.App.Entity.ViewModels;
using BelleMariee.App.Service.Interfaces;
using BelleMariee.App.Service.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BelleMariee.App.Service.Services
{
    public class ProductSaleDetailsService : IProductSaleDetailsService
    {
        private readonly BelleDbContext _context;

        public ProductSaleDetailsService(BelleDbContext context)
        {
            _context = context;
        }

        public async Task Add(ProductSaleDetailsViewModel model)
        {
            var productSaleDetails = new ProductSaleDetails
            {
                SaleId = model.SaleId,
                ProductId = model.ProductId,
                Quantity = model.Quantity,
                UnitPrice = model.UnitPrice
                
            };

            _context.ProductSaleDetails.Add(productSaleDetails);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> AddRange(List<SepetDetay>? sepet, int satisId)
        {
            foreach (var item in sepet)
            {
                ProductSaleDetails newDetail = new ProductSaleDetails()
                {
                    SaleId = satisId,
                    ProductId = item.ProductId,
                    Quantity = item.ProductQuantity,
                    UnitPrice = item.ProductPrice,
                    
                };
                _context.ProductSaleDetails.Add(newDetail); // Ara katmana ekler
            }
            try
            {
                await _context.SaveChangesAsync(); // Veritabanına hepsini birden gönderiyoruz. SaveChanges() metodunun transaction özelliğinden yararlanıyoruz.
                return true;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return false;
            }
        }

        public async Task Delete(int id)
        {
            var productSaleDetails = await _context.ProductSaleDetails.FindAsync(id);
            if (productSaleDetails != null)
            {
                _context.ProductSaleDetails.Remove(productSaleDetails);
                await _context.SaveChangesAsync();
            }
        }

        public async Task Delete(ProductSaleDetailsViewModel model)
        {
            var productSaleDetails = await _context.ProductSaleDetails.FindAsync(model.Id);
            if (productSaleDetails != null)
            {
                _context.ProductSaleDetails.Remove(productSaleDetails);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<ProductSaleDetailsViewModel> Get(int id)
        {
            var productSaleDetails = await _context.ProductSaleDetails.FindAsync(id);
            if (productSaleDetails == null)
                return null;

            var viewModel = new ProductSaleDetailsViewModel
            {
                Id = productSaleDetails.Id,
                SaleId = productSaleDetails.SaleId,
                ProductId = productSaleDetails.ProductId,
                Quantity = productSaleDetails.Quantity,
                UnitPrice = productSaleDetails.UnitPrice
                
            };

            return viewModel;
        }

        public async Task<IEnumerable<ProductSaleDetailsViewModel>> GetAll()
        {
            var productSaleDetails = await _context.ProductSaleDetails.ToListAsync();
            var viewModels = productSaleDetails.Select(psd => new ProductSaleDetailsViewModel
            {
                Id = psd.Id,
                SaleId = psd.SaleId,
                ProductId = psd.ProductId,
                Quantity = psd.Quantity,
                UnitPrice = psd.UnitPrice,
                
            });

            return viewModels;
        }

        public async Task Update(ProductSaleDetailsViewModel model)
        {
            var productSaleDetails = await _context.ProductSaleDetails.FindAsync(model.Id);
            if (productSaleDetails != null)
            {
                productSaleDetails.SaleId = model.SaleId;
                productSaleDetails.ProductId = model.ProductId;
                productSaleDetails.Quantity = model.Quantity;
                productSaleDetails.UnitPrice = model.UnitPrice;
                
                _context.ProductSaleDetails.Update(productSaleDetails);
                await _context.SaveChangesAsync();
            }
        }
    }
}
