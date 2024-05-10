using E_commerceAPI.DAL.Data.Context;
using E_commerceAPI.DAL.Repositorries.Carts;
using E_commerceAPI.DAL.Repositorries.Categories;
using E_commerceAPI.DAL.Repositorries.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace E_commerceAPI.DAL
{
    public static class ServicesExtensions
    {
        public static void AddDALServices(this IServiceCollection services)
        {
            
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICartRepository, CartRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

        }
    }
}

 