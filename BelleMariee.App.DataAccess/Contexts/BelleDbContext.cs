using BelleMariee.App.DataAccess.Identity;
using BelleMariee.App.Entity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BelleMariee.App.DataAccess.Contexts
{
	public class BelleDbContext : IdentityDbContext<AppUser, AppRole, int>
	{
		public BelleDbContext(DbContextOptions<BelleDbContext> options) : base(options) { }

		public DbSet<Product> Products { get; set; }
		public DbSet<Sale> Sales { get; set; }
		public DbSet<ProductSaleDetails> ProductSaleDetails { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<ProductType> ProductTypes { get; set; }



		protected override void OnModelCreating(ModelBuilder builder)
		{
			//Fluent API validation
			builder.Entity<Product>()
				.Property(p => p.Name)
				.IsRequired()
				.HasMaxLength(200);

			builder.Entity<Product>()
				.Property(p => p.ImageUrl)
				.HasDefaultValue("/images/product/default1.jpg");

			// Customer entity configuration
			builder.Entity<Customer>()
				.Property(c => c.Name)
				.HasMaxLength(100);

			// Category entity configuration
			builder.Entity<Category>()
				.Property(c => c.Name)
				.HasMaxLength(100);

			// ProductType entity configuration
			builder.Entity<ProductType>()
				.Property(pt => pt.Name)
				.HasMaxLength(100);
            //**********************************


            ////Seed Data

            builder.Entity<ProductType>().HasData(
                new ProductType() { Id = 1, Name = "Gow" },
                new ProductType() { Id = 2, Name = "Accessory" },
                new ProductType() { Id = 3, Name = "Shoe" }
                );
            builder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "After" },
                new Category() { Id = 2, Name = "AKesim" },
                new Category() { Id = 3, Name = "Balık" },
                new Category() { Id = 4, Name = "Helen" },
                new Category() { Id = 5, Name = "Modern" },
                new Category() { Id = 6, Name = "Nikah" },
                new Category() { Id = 7, Name = "Prenses" },
                new Category() { Id = 8, Name = "UzunK" },
                new Category() { Id = 9, Name = "Buket" },
                new Category() { Id = 10, Name = "Duvak" },
                new Category() { Id = 11, Name = "Tac" },
                new Category() { Id = 12, Name = "Ayakkabı" }
            );

            builder.Entity<Product>().HasData(
                // After category products
                new Product() { Id = 1, Name = "Tek Omuzlu After Party Elbisesi", CategoryId = 1, Description = "CARNELIAN\r\nÜrün Kodu:\r\n4XLWBM1870W", ProductTypeId = 1, ImageUrl = "/images/product/after1.1.webp", ImageUrl2 = "/images/product/after1.2.webp", ImageUrl3 = "/images/product/after3.3.webp", Price = 5000, Size = "38", Stock = 3 },
                new Product() { Id = 2, Name = "Straplez After Party Elbisesi", CategoryId = 1, Description = "Ürün Kodu:\r\nWHT0002TR|WH", ProductTypeId = 1, ImageUrl = "/images/product/after2.1.webp", ImageUrl2 = "/images/product/after2.2.webp", ImageUrl3 = "/images/product/after2.3.webp", Price = 9000, Size = "40", Stock = 2 },
                new Product() { Id = 3, Name = "Askılı After Party Elbisesi", CategoryId = 1, Description = "Ürün Kodu:\r\nWHT00AAH", ProductTypeId = 1, ImageUrl = "/images/product/after3.1.webp", ImageUrl2 = "/images/product/after3.2.webp", ImageUrl3 = "/images/product/after3.3.webp", Price = 7000, Size = "36", Stock = 4  },
                new Product() { Id = 4, Name = "Beyaz Düşük Balon Kollu Tafta Mini Gelinlik", CategoryId = 1, Description = "Ürün Kodu:\r\nWHT0009TR|WHITE_34", ProductTypeId = 1, ImageUrl = "/images/product/after4.1.webp", ImageUrl2 = "/images/product/after4.2.webp", ImageUrl3 = "/images/product/after4.3.webp", Price = 42000, Size = "36", Stock = 4 },
 new Product() { Id = 5, Name = "Beyaz Uzun Tül Kollu Jarse Mini Nikah Elbisesi", CategoryId = 1, Description = "Ürün Kodu:\r\nWHT0015TR|WHITE_34", ProductTypeId = 1, ImageUrl = "/images/product/after5.1.webp", ImageUrl2 = "/images/product/after5.2.webp", ImageUrl3 = "/images/product/after5.3.webp", Price = 42000, Size = "36", Stock = 4 },
 new Product() { Id = 6, Name = "Yırtmaçlı Saten Uzun Abiye Gelinlik", CategoryId = 1, Description = "Ürün Kodu:\r\nMA-B5617-001-INF|A29_0", ProductTypeId = 1, ImageUrl = "/images/product/after6.1.webp", ImageUrl2 = "/images/product/after6.2.webp", ImageUrl3 = "/images/product/after6.3.webp", Price = 42000, Size = "36", Stock = 4 },

                // AKesim category products
                new Product() { Id = 7, Name = "A Kesim Kol Detaylı Gelinlik", CategoryId = 2, Description = "Ürün Kodu:\r\n4XLSWG989|SOLID/IV_38", ProductTypeId = 1, ImageUrl = "/images/product/AKesim1.1.webp", ImageUrl2 = "/images/product/AKesim1.2.webp", ImageUrl3 = "/images/product/AKesim1.3.webp", Price = 38000, Size = "38", Stock = 3  },
                new Product() { Id = 8, Name = "A Kesim Tül Detaylı Gelinlik", CategoryId = 2, Description = "Ürün Kodu:\r\n4XLSWG76557ID/I8", ProductTypeId = 1, ImageUrl = "/images/product/AKesim2.1.webp", ImageUrl2 = "/images/product/AKesim2.2.webp", ImageUrl3 = "/images/product/AKesim2.3.webp", Price = 39000, Size = "40", Stock = 2  },
                new Product() { Id = 9, Name = "A Kesim Straplez Gelinlik", CategoryId = 2, Description = "Ürün Kodu:\r\n4XRHDZTX8", ProductTypeId = 1, ImageUrl = "/images/product/AKesim3.1.webp", ImageUrl2 = "/images/product/AKesim3.2.webp", ImageUrl3 = "/images/product/AKesim3.3.webp", Price = 41000, Size = "36", Stock = 4  },
                new Product() { Id = 10, Name = "Fiyonk Askılı Kalp Yaka A Kesim Gelinlik", CategoryId = 2, Description = "HARPER\r\nÜrün Kodu:\r\n4XLLSMS251246|IVORY_40", ProductTypeId = 1, ImageUrl = "/images/product/AKesim4.1.webp", ImageUrl2 = "/images/product/AKesim4.2.webp", ImageUrl3 = "/images/product/AKesim4.3.webp", Price = 41000, Size = "36", Stock = 4 },
new Product() { Id = 11, Name = "İnce Askılı Payet İşlemeli A Kesim Gelinlik", CategoryId = 2, Description = "CERES\r\nÜrün Kodu:\r\n1019|KEMİK_36", ProductTypeId = 1, ImageUrl = "/images/product/AKesim5.1.webp", ImageUrl2 = "/images/product/AKesim5.2.webp", ImageUrl3 = "/images/product/AKesim5.3.webp", Price = 41000, Size = "36", Stock = 4 },
new Product() { Id = 12, Name = "Kuyruklu Saten A Kesim Gelinlik", CategoryId = 2, Description = "ELORA\r\nÜrün Kodu:\r\n4XLWPD30838|BRDL IV/IV_38", ProductTypeId = 1, ImageUrl = "/images/product/AKesim6.1.webp", ImageUrl2 = "/images/product/AKesim6.2.webp", ImageUrl3 = "/images/product/AKesim6.3.webp", Price = 41000, Size = "36", Stock = 4 },

                // Balık category products
                new Product() { Id = 13, Name = "V Yaka Balık Model Gelinlik", CategoryId = 3, Description = "Ürün Kodu:\r\nSWGHBFHD38", ProductTypeId = 1, ImageUrl = "/images/product/balık1.1.webp", ImageUrl2 = "/images/product/balık1.2.webp", ImageUrl3 = "/images/product/balık1.3.webp", Price = 42000, Size = "38", Stock = 3  },
                new Product() { Id = 14, Name = "Straplez Balık ModelGelinlik", CategoryId = 3, Description = "Ürün Kodu:\r\nSWG970|SOLID/IV_38", ProductTypeId = 1, ImageUrl = "/images/product/balık2.1.webp", ImageUrl2 = "/images/product/balık2.2.webp", ImageUrl3 = "/images/product/balık2.3.webp", Price = 43000, Size = "40", Stock = 2  },
                new Product() { Id = 15, Name = "Straplez Balık Model Gelinlik", CategoryId = 3, Description = "Ürün Kodu:\r\nSWFHFHHGS38", ProductTypeId = 1, ImageUrl = "/images/product/balık3.1.webp", ImageUrl2 = "/images/product/balık3.2.webp", ImageUrl3 = "/images/product/balık3.3.webp", Price = 44000, Size = "36", Stock = 4  },
                new Product() { Id = 16, Name = "Sırt Dekolteli Balık Model Gelinlik", CategoryId = 3, Description = "Ürün Kodu:\r\n997|KEMİK_38", ProductTypeId = 1, ImageUrl = "/images/product/balık4.1.webp", ImageUrl2 = "/images/product/balık4.2.webp", ImageUrl3 = "/images/product/balık4.3.webp", Price = 44000, Size = "36", Stock = 4 },
 new Product() { Id = 17, Name = "İnce Askılı Dantel Detaylı Balık Model Gelinlik", CategoryId = 3, Description = "Ürün Kodu:\r\n1006|KEMİK_38\r\n", ProductTypeId = 1, ImageUrl = "/images/product/balık5.1.webp", ImageUrl2 = "/images/product/balık5.2.webp", ImageUrl3 = "/images/product/balık5.3.webp", Price = 44000, Size = "36", Stock = 4 },
 new Product() { Id = 18, Name = "Askılı Kuyruklu Balık Model Gelinlik", CategoryId = 3, Description = "BEGONIA\r\nÜrün Kodu:\r\n4XLSWG897|IVORY/BISQ_40", ProductTypeId = 1, ImageUrl = "/images/product/balık6.1.webp", ImageUrl2 = "/images/product/balık6.2.webp", ImageUrl3 = "/images/product/balık6.3.webp", Price = 44000, Size = "36", Stock = 4 },

// Helen category products
new Product() { Id = 19, Name = "Derin Yırtmaçlı Sırt Detaylı Gelinlik", CategoryId = 4, Description = "AMELIE\r\nÜrün Kodu:\r\n1028|KEMİK_40", ProductTypeId = 1, ImageUrl = "/images/product/helen1.1.webp", ImageUrl2 = "/images/product/helen1.2.webp", ImageUrl3 = "/images/product/helen1.3.webp", Price = 35000, Size = "38", Stock = 3 },
new Product() { Id = 20, Name = "V Yaka Payet İşlemeli Gelinlik", CategoryId = 4, Description = "CAMILLA\r\nÜrün Kodu:\r\n1020|KEMİK_40", ProductTypeId = 1, ImageUrl = "/images/product/helen2.1.webp", ImageUrl2 = "/images/product/helen2.2.webp", ImageUrl3 = "/images/product/helen2.3.webp", Price = 36000, Size = "40", Stock = 2 },
new Product() { Id = 21, Name = "Düşük Omuzlu Büzgülü Kol Detaylı Gelinlik", CategoryId = 4, Description = "EDITH\r\nÜrün Kodu:\r\n1029|KEMİK_40", ProductTypeId = 1, ImageUrl = "/images/product/helen3.1.webp", ImageUrl2 = "/images/product/helen3.2.webp", ImageUrl3 = "/images/product/helen3.3.webp", Price = 37000, Size = "36", Stock = 4 },
new Product() { Id = 22, Name = "İnce Askılı Düşük Omuz Tül Detaylı Gelinlik", CategoryId = 4, Description = "LISA\r\nÜrün Kodu:\r\n1023|KEMİK_40", ProductTypeId = 1, ImageUrl = "/images/product/helen4.1.webp", ImageUrl2 = "/images/product/helen4.2.webp", ImageUrl3 = "/images/product/helen4.3.webp", Price = 37000, Size = "36", Stock = 4 },
new Product() { Id = 23, Name = "Straplez Tül Dantel İşlemeli Gelinlik", CategoryId = 4, Description = "BLUEBELL\r\nÜrün Kodu:\r\n4XLWPD31711|IVORY_40", ProductTypeId = 1, ImageUrl = "/images/product/helen5.1.webp", ImageUrl2 = "/images/product/helen5.2.webp", ImageUrl3 = "/images/product/helen5.3.webp", Price = 37000, Size = "36", Stock = 4 },
new Product() { Id = 24, Name = "Payet İşlemeli Sırtı İpli Pırıltılı Gelinlik", CategoryId = 4, Description = "Ürün Kodu:\r\n4XLWPD24633|IVORY_42", ProductTypeId = 1, ImageUrl = "/images/product/helen6.1.webp", ImageUrl2 = "/images/product/helen6.2.webp", ImageUrl3 = "/images/product/helen6.3.webp", Price = 37000, Size = "36", Stock = 4 },

// Modern category products
new Product() { Id = 25, Name = "Önü Kısa Arkası Uzun Krep Dar Kesim", CategoryId = 5, Description = "Gelinlik\r\nÜrün Kodu:\r\n4XLSDWG1052|SOFT WHITE_40", ProductTypeId = 1, ImageUrl = "/images/product/Modern1.1.webp", ImageUrl2 = "/images/product/Modern1.2.webp", ImageUrl3 = "/images/product/Modern1.3.webp", Price = 46000, Size = "38", Stock = 3 },
new Product() { Id = 26, Name = "Fiyonk Detaylı Saten Dar Kesim Gelinlik", CategoryId = 5, Description = "HARMONIA\r\nÜrün Kodu:\r\n4XLWPD26986|IVORY_38", ProductTypeId = 1, ImageUrl = "/images/product/Modern2.1.webp", ImageUrl2 = "/images/product/Modern2.2.webp", ImageUrl3 = "/images/product/Modern2.3.webp", Price = 47000, Size = "40", Stock = 2 },
new Product() { Id = 27, Name = "Boncuk İşlemeli Kuyruklu Gelinlik", CategoryId = 5, Description = "CARINO\r\nÜrün Kodu:\r\n1017|KEMİK_40", ProductTypeId = 1, ImageUrl = "/images/product/Modern3.1.webp", ImageUrl2 = "/images/product/Modern3.2.webp", ImageUrl3 = "/images/product/Modern3.3.webp", Price = 48000, Size = "36", Stock = 4 },
new Product() { Id = 28, Name = "Düşük Omuz Detaylı Yırtmaçlı Gelinlik", CategoryId = 5, Description = "LIZA\r\nÜrün Kodu:\r\n4XLSWG834|IVORY/C_40", ProductTypeId = 1, ImageUrl = "/images/product/Modern4.1.webp", ImageUrl2 = "/images/product/Modern4.2.webp", ImageUrl3 = "/images/product/Modern4.3.webp", Price = 48000, Size = "36", Stock = 4 },
new Product() { Id = 29, Name = "Kayık Yaka Mikado Gelinlik", CategoryId = 5, Description = "PAULA\r\nÜrün Kodu:\r\n4XLWPD23641|IVORY_44", ProductTypeId = 1, ImageUrl = "/images/product/Modern5.1.webp", ImageUrl2 = "/images/product/Modern5.2.webp", ImageUrl3 = "/images/product/Modern5.3.webp", Price = 48000, Size = "36", Stock = 4 },
new Product() { Id = 30, Name = "Sırtı Degaje Detaylı Dar Kesim Gelinlik", CategoryId = 5, Description = "PRIYANKA\r\nÜrün Kodu:\r\n4XLWGIN RI 0135|IVORY_34", ProductTypeId = 1, ImageUrl = "/images/product/Modern6.1.webp", ImageUrl2 = "/images/product/Modern6.2.webp", ImageUrl3 = "/images/product/Modern6.3.webp", Price = 48000, Size = "36", Stock = 4 },


// Nikah category products
new Product() { Id = 31, Name = "Yırtmaçlı Midi Boy Jarse Nikah Elbisesi", CategoryId = 6, Description = "Ürün Kodu:\r\nMA-B5625-001-INF|A29_0", ProductTypeId = 1, ImageUrl = "/images/product/nikah1.1.webp", ImageUrl2 = "/images/product/nikah1.2.webp", ImageUrl3 = "/images/product/nikah1.3.webp", Price = 31000, Size = "38", Stock = 3 },
new Product() { Id = 32, Name = "Arkası Yırtmaçlı Balon Kol Detaylı Gelinlik", CategoryId = 6, Description = "Ürün Kodu:\r\nVC5595WHT|IVORY_34", ProductTypeId = 1, ImageUrl = "/images/product/nikah2.1.webp", ImageUrl2 = "/images/product/nikah2.2.webp", ImageUrl3 = "/images/product/nikah2.3.webp", Price = 32000, Size = "40", Stock = 2 },
new Product() { Id = 33, Name = "Fiyonk Detaylı Yırtmaçlı Krep Gelinlik", CategoryId = 6, Description = "Ürün Kodu:\r\nVC5592WHT|IVORY_34", ProductTypeId = 1, ImageUrl = "/images/product/nikah3.1.webp", ImageUrl2 = "/images/product/nikah3.2.webp", ImageUrl3 = "/images/product/nikah3.3.webp", Price = 33000, Size = "36", Stock = 4 },
new Product() { Id = 34, Name = "Askılı V Yaka Yırtmaçlı Krep Kumaş Gelinlik", CategoryId = 6, Description = "KITO\r\nÜrün Kodu:\r\n4XLSDWG1175|SOFT WHITE_44", ProductTypeId = 1, ImageUrl = "/images/product/nikah4.1.webp", ImageUrl2 = "/images/product/nikah4.2.webp", ImageUrl3 = "/images/product/nikah4.3.webp", Price = 33000, Size = "36", Stock = 4 },
new Product() { Id = 35, Name = "Tek Omuz Yırtmaçlı Saten Uzun Gelinlik", CategoryId = 6, Description = "Ürün Kodu:\r\n4XLGS290018WHT|IVORY_42", ProductTypeId = 1, ImageUrl = "/images/product/nikah5.1.webp", ImageUrl2 = "/images/product/nikah5.2.webp", ImageUrl3 = "/images/product/nikah5.3.webp", Price = 33000, Size = "36", Stock = 4 },
new Product() { Id = 36, Name = "Kalın Askılı Mini Nikah Elbisesi", CategoryId = 6, Description = "BERYL\r\nÜrün Kodu:\r\n4XLF15554WHT|IVORY_38", ProductTypeId = 1, ImageUrl = "/images/product/nikah6.1.webp", ImageUrl2 = "/images/product/nikah6.2.webp", ImageUrl3 = "/images/product/nikah6.3.webp", Price = 33000, Size = "36", Stock = 4 },


                // prenses
                new Product() { Id = 37, Name = "Dantel İşlemeli Straplez Balo Tipi Kuyruklu Gelinlik", CategoryId = 7, Description = " ÜRÜN KODU: 34066 700GG", ProductTypeId = 1, ImageUrl = "/images/product/prenses1.1.webp", ImageUrl2 = "/images/product/prenses1.2.webp", ImageUrl3 = "/images/product/prenses1.3.webp", Price = 49000, Size = "38", Stock = 3 },
new Product() { Id = 38, Name = "İnci İşlemeli Askılı A Kesim Gelinlik", CategoryId = 7, Description = " ÜRÜN KODU: 34067 701GG", ProductTypeId = 1, ImageUrl = "/images/product/prenses2.1.webp", ImageUrl2 = "/images/product/prenses2.2.webp", ImageUrl3 = "/images/product/prenses2.3.webp", Price = 50000, Size = "40", Stock = 2 },
new Product() { Id = 39, Name = "Saten Dantel İşlemeli V Yaka Gelinlik", CategoryId = 7, Description = " ÜRÜN KODU: 34068 702GG", ProductTypeId = 1, ImageUrl = "/images/product/prenses3.1.webp", ImageUrl2 = "/images/product/prenses3.2.webp", ImageUrl3 = "/images/product/prenses3.3.webp", Price = 51000, Size = "36", Stock = 4 },
new Product() { Id = 40, Name = "Çiçek Desenli Prenses Gelinlik", CategoryId = 7, Description = " ÜRÜN KODU: 34069 703GG", ProductTypeId = 1, ImageUrl = "/images/product/prenses4.1.webp", ImageUrl2 = "/images/product/prenses4.2.webp", ImageUrl3 = "/images/product/prenses4.3.webp", Price = 52000, Size = "42", Stock = 5 },
new Product() { Id = 41, Name = "Dantel İşlemeli Kısa Kollu Gelinlik", CategoryId = 7, Description = "ÜRÜN KODU: 34070 704GG", ProductTypeId = 1, ImageUrl = "/images/product/prenses5.1.webp", ImageUrl2 = "/images/product/prenses5.2.webp", ImageUrl3 = "/images/product/prenses5.3.webp", Price = 53000, Size = "44", Stock = 1 },
new Product() { Id = 42, Name = "Fiyonklu Derin Dekolteli Gelinlik", CategoryId = 7, Description = ",ÜRÜN KODU: 34071 705GG", ProductTypeId = 1, ImageUrl = "/images/product/prenses6.1.webp", ImageUrl2 = "/images/product/prenses6.2.webp", ImageUrl3 = "/images/product/prenses6.3.webp", Price = 54000, Size = "46", Stock = 3 },

// UzunK category products
new Product() { Id = 43, Name = "Düşük Omuzlu Uzun Kollu Dar Kesim Gelinlik", CategoryId = 8, Description = "FRANCESCA\r\nÜrün Kodu:\r\n4XLWPD30119|IVORY/OLEG_42", ProductTypeId = 1, ImageUrl = "/images/product/uzunk1.1.webp", ImageUrl2 = "/images/product/uzunk1.2.webp", ImageUrl3 = "/images/product/uzunk1.3.webp", Price = 34000, Size = "38", Stock = 3 },
new Product() { Id = 44, Name = "Uzun Kollu Dar Kesim Gelinlik", CategoryId = 8, Description = "NORA\r\nÜrün Kodu:\r\n4XLMS251270|IVORY/STON_40", ProductTypeId = 1, ImageUrl = "/images/product/uzunk2.1.webp", ImageUrl2 = "/images/product/uzunk2.2.webp", ImageUrl3 = "/images/product/uzunk2.3.webp", Price = 35000, Size = "40", Stock = 2 },
new Product() { Id = 45, Name = "Uzun Kollu Işıltılı Tül Dar Kesim Gelinlik", CategoryId = 8, Description = "VALENTINA\r\nÜrün Kodu:\r\n4XLWPD30203|IVORY/N N_42", ProductTypeId = 1, ImageUrl = "/images/product/uzunk3.1.webp", ImageUrl2 = "/images/product/uzunk3.2.webp", ImageUrl3 = "/images/product/uzunk3.3.webp", Price = 36000, Size = "36", Stock = 4 },

new Product() { Id = 46, Name = "Uzun Tül Kollu V Yaka Krep Dar Kesim Gelinlik", CategoryId = 8, Description = "CARINA\r\nÜrün Kodu:\r\n4XLWPD29555|IVORY_40", ProductTypeId = 1, ImageUrl = "/images/product/uzunk4.1.webp", ImageUrl2 = "/images/product/uzunk4.2.webp", ImageUrl3 = "/images/product/uzunk4.3.webp", Price = 36000, Size = "36", Stock = 4 },
new Product() { Id = 47, Name = "Dantel İşlemeli Uzun Kollu A Kesim Gelinlik", CategoryId = 8, Description = "AMORETTE\r\nÜrün Kodu:\r\n4XLWPD30117|IVORY/OLEG_38", ProductTypeId = 1, ImageUrl = "/images/product/uzunk5.1.webp", ImageUrl2 = "/images/product/uzunk5.2.webp", ImageUrl3 = "/images/product/uzunk5.3.webp", Price = 36000, Size = "36", Stock = 4 },
new Product() { Id = 48, Name = "Uzun Tül Kollu Krep Dar Kesim Gelinlik", CategoryId = 8, Description = "PRIYA\r\nÜrün Kodu:\r\n4XLWPD30295|SOFT WHITE_38", ProductTypeId = 1, ImageUrl = "/images/product/uzunk6.1.webp", ImageUrl2 = "/images/product/uzunk6.2.webp", ImageUrl3 = "/images/product/uzunk6.3.webp", Price = 36000, Size = "36", Stock = 4 },

                // Buket category products
                new Product() { Id = 49, Name = "GRAND MAGNOLIA", CategoryId = 9, Description = "Buket 1 Aksesuar, ÜRÜN KODU: 45001 800AK", ProductTypeId = 2, ImageUrl = "/images/product/b1.1.webp", ImageUrl2 = "/images/product/b1.2.webp", ImageUrl3 = "/images/product/b1.3.webp", Price = 2000, Size = "Standart", Stock = 10 },
new Product() { Id = 50, Name = "GLORIA", CategoryId = 9, Description = "Buket 2 Aksesuar, ÜRÜN KODU: 45002 801AK", ProductTypeId = 2, ImageUrl = "/images/product/b2.1.webp", ImageUrl2 = "/images/product/b2.2.webp", ImageUrl3 = "/images/product/b2.3.webp", Price = 2500, Size = "Standart", Stock = 8 },
new Product() { Id = 51, Name = "ECROU", CategoryId = 9, Description = "Buket 3 Aksesuar, ÜRÜN KODU: 45003 802AK", ProductTypeId = 2, ImageUrl = "/images/product/b3.1.webp", ImageUrl2 = "/images/product/b3.2.webp", ImageUrl3 = "/images/product/b3.3.webp", Price = 3000, Size = "Standart", Stock = 6 },
new Product() { Id = 52, Name = "SPRING", CategoryId = 9, Description = "Buket 4 Aksesuar, ÜRÜN KODU: 45004 803AK", ProductTypeId = 2, ImageUrl = "/images/product/b4.1.webp", ImageUrl2 = "/images/product/b4.2.webp", ImageUrl3 = "/images/product/b4.3.webp", Price = 2200, Size = "Standart", Stock = 12 },
new Product() { Id = 53, Name = "MÜRDÜM", CategoryId = 9, Description = "Buket 5 Aksesuar, ÜRÜN KODU: 45005 804AK", ProductTypeId = 2, ImageUrl = "/images/product/b5.1.webp", ImageUrl2 = "/images/product/b5.2.webp", ImageUrl3 = "/images/product/b5.3.webp", Price = 2700, Size = "Standart", Stock = 9 },
new Product() { Id = 54, Name = "V E L V E T", CategoryId = 9, Description = "Buket 6 Aksesuar, ÜRÜN KODU: 45006 805AK", ProductTypeId = 2, ImageUrl = "/images/product/b6.1.webp", ImageUrl2 = "/images/product/b6.2.webp", ImageUrl3 = "/images/product/b6.3.webp", Price = 2900, Size = "Standart", Stock = 7 },

 // Duvak category products
 new Product() { Id = 55, Name = "Dantel ve Pul İşlemeli Katedral Boy Gelin Duvağı", CategoryId = 10, Description = "Ürün Kodu:\r\nWPD27227|IVORY_U", ProductTypeId = 2, ImageUrl = "/images/product/duvak1.1.webp", ImageUrl2 = "/images/product/duvak1.2.webp", ImageUrl3 = "/images/product/duvak1.3.webp", Price = 1500, Size = "Standart", Stock = 10 },
 new Product() { Id = 56, Name = "Uzun Tül Tamamı İnci Detaylı Duvak", CategoryId = 10, Description = "Ürün Kodu:\r\nINCILIDUVAKV2|IVORY_U", ProductTypeId = 2, ImageUrl = "/images/product/duvak2.1.webp", ImageUrl2 = "/images/product/duvak2.2.webp", ImageUrl3 = "/images/product/duvak2.3.webp", Price = 2000, Size = "Standart", Stock = 8 },
 new Product() { Id = 57, Name = "Taş İşlemeli Kısa Duvak", CategoryId = 10, Description = "Ürün Kodu:\r\nWPD28215V2|IVORY_U", ProductTypeId = 2, ImageUrl = "/images/product/duvak3.1.webp", ImageUrl2 = "/images/product/duvak3.2.webp", ImageUrl3 = "/images/product/duvak3.3.webp", Price = 2500, Size = "Standart", Stock = 6 },
 new Product() { Id = 58, Name = "Çiçek Motif Dantel İşlemeli Tül Gelin Duvağı", CategoryId = 10, Description = "Ürün Kodu:\r\nV1810B|IVORY_U", ProductTypeId = 2, ImageUrl = "/images/product/duvak4.1.webp", ImageUrl2 = "/images/product/duvak4.2.webp", ImageUrl3 = "/images/product/duvak4.3.webp", Price = 2500, Size = "Standart", Stock = 6 },

 // Taç category products
 new Product() { Id = 59, Name = "Kırık Beyaz İncili Gelin Tacı", CategoryId = 11, Description = "Ürün Kodu:\r\nVGR191101001|IVORY_U", ProductTypeId = 2, ImageUrl = "/images/product/tac1.1.webp", ImageUrl2 = "/images/product/tac1.2.webp", ImageUrl3 = "/images/product/tac1.3.webp", Price = 1700, Size = "Standart", Stock = 7 },
 new Product() { Id = 60, Name = "Yapay Elmas Gelin Tacı", CategoryId = 11, Description = "Ürün Kodu:\r\nH42235|SILVER_U", ProductTypeId = 2, ImageUrl = "/images/product/tac2.1.webp", ImageUrl2 = "/images/product/tac2.2.webp", ImageUrl3 = "/images/product/tac2.3.webp", Price = 2100, Size = "Standart", Stock = 8 },
 new Product() { Id = 61, Name = "İnci Detaylı Yapay Elmas Gelin Tacı", CategoryId = 11, Description = "Ürün Kodu:\r\nWPD20601|IVORY_U", ProductTypeId = 2, ImageUrl = "/images/product/tac3.1.webp", ImageUrl2 = "/images/product/tac3.2.webp", ImageUrl3 = "/images/product/tac3.3.webp", Price = 200, Size = "Standart", Stock = 6 },

       // Ayakkabı category products
       new Product() { Id = 62, Name = "SEDEF SATEN BLOOM GELİN AYAKKABISI", CategoryId = 12, Description = "ÜRÜN KODU : 35060 206G", ProductTypeId = 3, ImageUrl = "/images/product/1.1.jpg", ImageUrl2 = "/images/product/1.2.jpg", ImageUrl3 = "/images/product/1.3.jpg", Price = 2850, Size = "36", Stock = 6 },
       new Product() { Id = 63, Name = "SEDEF SATEN FLORENCE MİNİ TOPUK GELİN AYAKKABISI\r\n", CategoryId = 12, Description = "ÜRÜN KODU : 35060 0250G\r\n", ProductTypeId = 3, ImageUrl = "/images/product/2.1.jpg", ImageUrl2 = "/images/product/2.2.jpg", ImageUrl3 = "/images/product/2.3.jpg", Price = 4500, Size = "37", Stock = 9 },
      new Product() { Id = 64, Name = "SEDEF NİNA İNCE TOPUK GELİN AYAKKABISI\r\n", CategoryId = 12, Description = "ÜRÜN KODU : 34210 2233G", ProductTypeId = 3, ImageUrl = "/images/product/3.1.jpg", ImageUrl2 = "/images/product/3.2.jpg", ImageUrl3 = "/images/product/3.3.jpg", Price = 4500, Size = "38", Stock = 3 },
     new Product() { Id = 65, Name = "SEDEF SATEN LEROY TEK BANT GELİN AYAKKABISI\r\n", CategoryId = 12, Description = "ÜRÜN KODU : 35072 1159G\r\n", ProductTypeId = 3, ImageUrl = "/images/product/4.1.jpg", ImageUrl2 = "/images/product/4.2.jpg", ImageUrl3 = "/images/product/4.3.jpg", Price = 2250, Size = "39", Stock = 7 },
      new Product() { Id = 66, Name = "SEDEF SO VERA GELİN AYAKKABISI\r\n", CategoryId = 12, Description = "ÜRÜN KODU : 34066 700GG\r\n", ProductTypeId = 3, ImageUrl = "/images/product/5.1.jpg", ImageUrl2 = "/images/product/5.2.jpg", ImageUrl3 = "/images/product/5.3.jpg", Price = 4500, Size = "40", Stock = 6 },
     new Product() { Id = 67, Name = "SEDEF SATEN BLOOM GELİN AYAKKABISI\r\n", CategoryId = 12, Description = "ÜRÜN KODU : 35060 202G\r\n", ProductTypeId = 3, ImageUrl = "/images/product/6.1.jpg", ImageUrl2 = "/images/product/6.2.jpg", ImageUrl3 = "/images/product/6.3.jpg", Price = 2850, Size = "41", Stock = 7 }

);

            base.OnModelCreating(builder);
		}
	}
}
