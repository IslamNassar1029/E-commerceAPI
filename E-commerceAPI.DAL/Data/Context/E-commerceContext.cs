using E_commerceAPI.DAL;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace E_commerceAPI.DAL.Data.Context
{
    public class E_commerceContext:IdentityDbContext<User>
    {
        public E_commerceContext(DbContextOptions options):base(options) { }

        public DbSet<Cart> Carts=>Set<Cart>();
        //public DbSet<Order> Orders=>Set<Order>();
        public DbSet<Product> Products=>Set<Product>();
        public DbSet<Category> Categories=>Set<Category>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region Category Seeding
            List<Category> categoryList = new List<Category>
                {
                    new Category{Id=1,Name="Apple"},
                    new Category{Id=2,Name="Dell"},
                    new Category{Id=3,Name="HP"},
                    new Category{Id=4,Name="Lenovo"},
                    new Category{Id=5,Name="ASUS"},
                    new Category{Id=6,Name="Acer"},
                    new Category{Id=7,Name="Microsoft"},
                    new Category{Id=8,Name="MSI"},
                    new Category{Id=9,Name="Razer"},
                    new Category{Id=10,Name="Samsung"},
                };
            builder.Entity<Category>().HasData(categoryList);
            #endregion

            #region Product Seeding  


            List<Product> ProductList = new List<Product>
                {
                    new Product
                    {
                        Id = 5,
                        Name = "Apple MacBook Air",
                        Price = 40000,
                        Discount = 50,
                        Description = "The Apple MacBook Air is a lightweight and portable laptop with excellent battery life.",
                        Model = "MacBook Air",
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 6,
                        Name = "Apple MacBook Pro",
                        Price = 80000,
                        Discount =20,
                        Description = "The Apple MacBook Pro is a high-performance laptop loved by professionals.",

                        Model = "MacBook Pro",
                        CategoryId = 1
                    },

                    new Product
                    {
                        Id = 7,
                        Name = "Dell XPS 13",
                        Price = 40000,
                        Discount = 0,
                        Description = "The Dell XPS 13 is a sleek and powerful laptop with a stunning display.",
                        Model = "XPS 13",
                        CategoryId = 2
                    },
                    new Product
                    {
                        Id = 8,
                        Name = "Dell Inspiron 15",
                        Price = 35000,
                        Discount = 13,
                        Description = "The Dell Inspiron 15 is a versatile laptop suitable for everyday use.",
                        Model = "Inspiron 15",
                        CategoryId = 2
                    },
                    new Product
                    {
                        Id = 9,
                        Name = "HP Spectre x360",
                        Price = 25000,
                        Discount = 15,
                        Description = "The HP Spectre x360 is a stylish 2-in-1 laptop with powerful performance.",
                        Model = "Spectre x360",
                        CategoryId = 3
                    },
                    new Product
                    {
                        Id = 10,
                        Name = "HP Pavilion 14",
                        Price = 15000,
                        Discount = 60,
                        Description = "The HP Pavilion 14 is a budget-friendly laptop with decent specifications.",
                        Model = "Pavilion 14",
                        CategoryId = 3
                    },
                        new Product

                    {
                        Id = 11,
                        Name = "Apple MacBook Air",
                        Price = 28000,
                        Discount = 10,
                        Description = "The Apple MacBook Air is a lightweight and portable laptop with excellent battery life.",
                        Model = "MacBook Air",
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 12,
                        Name = "Apple MacBook Pro",
                        Price = 30000,
                        Discount = 12,
                        Description = "The Apple MacBook Pro is a high-performance laptop loved by professionals.",
                        Model = "MacBook Pro",
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 13,
                        Name = "Apple iMac",
                        Price = 16000,
                        Discount = 0,
                        Description = "The Apple iMac is a sleek and powerful all-in-one desktop computer.",
                        Model = "iMac",
                        CategoryId = 1
                    },

                    new Product
                    {
                        Id = 14,
                        Name = "Dell XPS 13",
                        Price = 14000,
                        Discount = 90,
                        Description = "The Dell XPS 13 is a sleek and powerful laptop with a stunning display.",
                        Model = "XPS 13",
                        CategoryId = 2
                    },
                    new Product
                    {
                        Id = 15,
                        Name = "Dell Inspiron 15",
                        Price = 30000,
                        Discount = 18,
                        Description = "The Dell Inspiron 15 is a versatile laptop suitable for everyday use.",
                        Model = "Inspiron 15",
                        CategoryId = 2
                    },
                    new Product
                    {
                        Id = 16,
                        Name = "Dell G5 Gaming Desktop",
                        Price = 38000,
                        Discount = 20,
                        Description = "The Dell G5 Gaming Desktop is a powerful gaming machine with immersive graphics.",
                        Model = "G5 Gaming Desktop",
                        CategoryId = 2
                    },

                    new Product
                    {
                        Id = 17,
                        Name = "HP Spectre x360",
                        Price = 26000,
                        Discount = 19,
                        Description = "The HP Spectre x360 is a stylish 2-in-1 laptop with powerful performance.",
                        Model = "Spectre x360",
                        CategoryId = 3
                    },
                    new Product
                    {
                        Id = 18,
                        Name = "HP Pavilion 14",
                        Price = 6000,
                        Discount = 0,
                        Description = "The HP Pavilion 14 is a budget-friendly laptop with decent specifications.",
                        Model = "Pavilion 14",
                        CategoryId = 3
                    },
                    new Product
                    {
                        Id = 19,
                        Name = "HP EliteBook 840",
                        Price = 50000,
                        Discount = 80,
                        Description = "The HP EliteBook 840 is a business laptop with top-notch security features.",
                        Model = "EliteBook 840",
                        CategoryId = 3
                    },

                    new Product
                    {
                        Id = 20,
                        Name = "Apple MacBook Air",
                        Price = 18000,
                        Discount = 15,
                        Description = "The Apple MacBook Air is a lightweight and portable laptop with excellent battery life.",
                        Model = "MacBook Air",
                        CategoryId = 1
                    },

                    new Product
                    {
                        Id = 21,
                        Name = "Dell XPS 13",
                        Price = 13000,
                        Discount = 5,
                        Description = "The Dell XPS 13 is a sleek and powerful laptop with a stunning display.",
                        Model = "XPS 13",
                        CategoryId = 2
                    },

                    new Product
                    {
                        Id = 22,
                        Name = "HP Spectre x360",
                        Price = 12000,
                        Discount = 10,
                        Description = "The HP Spectre x360 is a stylish 2-in-1 laptop with powerful performance.",
                        Model = "Spectre x360",
                        CategoryId = 3
                    },

                    new Product
                    {
                        Id = 23,
                        Name = "Lenovo ThinkCentre M720",
                        Price = 15000,
                        Discount = 6,
                        Description = "The Lenovo ThinkCentre M720 is a compact and reliable desktop computer for business use.",
                        Model = "ThinkCentre M720",
                        CategoryId = 4
                    },

                    new Product
                    {
                        Id = 24,
                        Name = "ASUS ROG Strix G15",
                        Price = 80000,
                        Discount = 60,
                        Description = "The ASUS ROG Strix G15 is a powerful gaming desktop with RGB lighting and high-performance components.",
                        Model = "ROG Strix G15",
                        CategoryId = 5
                    },
                    new Product
                    {
                        Id = 25,
                        Name = "Acer Aspire TC",
                        Price = 18000,
                        Discount = 15,
                        Description = "The Acer Aspire TC is a budget-friendly desktop computer with decent performance.",
                        Model = "Aspire TC",
                        CategoryId = 6
                    },

                    new Product
                    {
                        Id = 26,
                        Name = "Dell Inspiron 27",
                        Price = 22000,
                        Discount = 10,
                        Description = "The Dell Inspiron 27 is an all-in-one desktop computer with a large display and powerful performance.",
                        Model = "Inspiron 27",
                        CategoryId = 2
                    },
                    new Product
                    {
                        Id = 27,
                        Name = "ASUS ZenBook Pro",
                        Price = 28000,
                        Discount = 15,
                        Description = "The ASUS ZenBook Pro is a premium laptop with a stunning 4K display and high-performance components.",
                        Model = "ZenBook Pro",
                        CategoryId = 5
                    },
                    new Product
                    {
                        Id = 28,
                        Name = "HP Pavilion Gaming Desktop",
                        Price = 15000,
                        Discount = 80,
                        Description = "The HP Pavilion Gaming Desktop is a gaming powerhouse with advanced graphics and smooth gameplay.",
                        Model = "Pavilion Gaming Desktop",
                        CategoryId = 3
                    },
                    new Product
                    {
                        Id = 29,
                        Name = "Lenovo Legion Y540",
                        Price = 20000,
                        Discount = 12,
                        Description = "The Lenovo Legion Y540 is a gaming laptop with powerful hardware and immersive gaming experience.",
                        Model = "Legion Y540",
                        CategoryId = 4
                    },

                    new Product
                    {
                        Id = 30,
                        Name = "Apple iMac",
                        Price = 24000,
                        Discount = 20,
                        Description = "The Apple iMac is a sleek all-in-one desktop computer with a stunning Retina display and powerful performance.",
                        Model = "iMac",
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 31,
                        Name = "Dell G5 Gaming Laptop",
                        Price = 18000,
                        Discount = 10,
                        Description = "The Dell G5 is a gaming laptop with high-performance hardware and immersive gaming features.",
                        Model = "G5 Gaming Laptop",
                        CategoryId = 2
                    },
                    new Product
                    {
                        Id = 32,
                        Name = "HP Envy 15",
                        Price = 16000,
                        Discount = 15,
                        Description = "The HP Envy 15 is a premium laptop with a sleek design and powerful performance for multimedia and productivity tasks.",
                        Model = "Envy 15",
                        CategoryId = 3
                    },
                    new Product
                    {
                        Id = 33,
                        Name = "Lenovo IdeaCentre 5",
                        Price = 8990,
                        Discount = 50,
                        Description = "The Lenovo IdeaCentre 5 is a compact and versatile desktop computer suitable for home and office use.",
                        Model = "IdeaCentre 5",
                        CategoryId = 4
                    },

                    new Product
                    {
                        Id = 34,
                        Name = "ASUS VivoBook S15",
                        Price = 9990,
                        Discount = 0,
                        Description = "The ASUS VivoBook S15 is a stylish and lightweight laptop with a vibrant display and long battery life.",
                        Model = "VivoBook S15",
                        CategoryId = 5
                    },
                    new Product
                    {
                        Id = 35,
                        Name = "Samsung Galaxy Book Pro",
                        Price = 14990,
                        Discount = 10,
                        Description = "The Samsung Galaxy Book Pro is a thin and lightweight laptop with a stunning AMOLED display and powerful performance.",
                        Model = "Galaxy Book Pro",
                        CategoryId = 10
                    },
                    new Product
                    {
                        Id = 36,
                        Name = "Dell Alienware Aurora R10",
                        Price = 28000,
                        Discount = 20,
                        Description = "The Dell Alienware Aurora R10 is a high-performance gaming desktop with powerful hardware and customizable lighting.",
                        Model = "Alienware Aurora R10",
                        CategoryId = 2
                    },
                    new Product
                    {
                        Id = 37,
                        Name = "HP Omen 15",
                        Price = 17999,
                        Discount = 15,
                        Description = "The HP Omen 15 is a gaming laptop with a sleek design, high-refresh-rate display, and powerful performance for gaming enthusiasts.",
                        Model = "Omen 15",
                        CategoryId = 3
                    },

                    new Product
                    {
                        Id = 38,
                        Name = "Apple MacBook Air",
                        Price = 12990,
                        Discount = 10,
                        Description = "The Apple MacBook Air is a lightweight and portable laptop with a stunning Retina display and all-day battery life.",
                        Model = "MacBook Air",
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 39,
                        Name = "Razer Blade 15",
                        Price = 23990,
                        Discount = 15,
                        Description = "The Razer Blade 15 is a premium gaming laptop with a sleek design, high-refresh-rate display, and powerful performance.",
                        Model = "Blade 15",
                        CategoryId = 9
                    },
                    new Product
                    {
                        Id = 40,
                        Name = "Lenovo ThinkPad X1 Carbon",
                        Price = 18990,
                        Discount = 60,
                        Description = "The Lenovo ThinkPad X1 Carbon is a premium business laptop with a durable build, long battery life, and top-notch performance.",
                        Model = "ThinkPad X1 Carbon",
                        CategoryId = 4
                    },
                    new Product
                    {
                        Id = 41,
                        Name = "ASUS ROG Zephyrus G14",
                        Price = 17000,
                        Discount = 0,
                        Description = "The ASUS ROG Zephyrus G14 is a powerful gaming laptop with an ultra-portable design and impressive performance.",
                        Model = "ROG Zephyrus G14",
                        CategoryId = 5
                    },
                    new Product
                    {
                        Id = 42,
                        Name = "MSI GS66 Stealth",
                        Price = 23999,
                        Discount = 19,
                        Description = "The MSI GS66 Stealth is a high-performance gaming laptop with a sleek design and powerful components.",
                        Model = "GS66 Stealth",
                        CategoryId = 8
                    },
                    new Product
                    {
                        Id = 43,
                        Name = "MSI Prestige 14",
                        Price = 15990,
                        Discount = 17,
                        Description = "The MSI Prestige 14 is a stylish and powerful laptop designed for creative professionals.",
                        Model = "Prestige 14",
                        CategoryId = 8
                    },

                    new Product
                    {
                        Id = 44,
                        Name = "Microsoft Surface Laptop 4",
                        Price = 23000,
                        Discount = 14,
                        Description = "The Microsoft Surface Laptop 4 is a sleek and versatile laptop with a premium design and excellent performance.",
                        Model = "Surface Laptop 4",
                        CategoryId = 7
                    },
                    new Product
                    {
                        Id = 45,
                        Name = "Microsoft Surface Pro 7",
                        Price = 20000,
                        Discount = 0,
                        Description = "The Microsoft Surface Pro 7 is a powerful 2-in-1 tablet-laptop hybrid with a detachable keyboard and versatile functionality.",
                        Model = "Surface Pro 7",
                        CategoryId = 7
                    },



                    };


            builder.Entity<Product>().HasData(ProductList);
            #endregion



        }
    }
}
