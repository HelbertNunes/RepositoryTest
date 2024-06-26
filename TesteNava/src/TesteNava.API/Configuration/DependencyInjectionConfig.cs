﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteNava.Data.Context;
using TesteNava.Data.Repository;
using TesteNava.Domain.Interfaces;
using TesteNava.Domain.Interfaces.Service;
using TesteNava.Domain.Services;

namespace TesteNava.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection DependencySolver(this IServiceCollection services)
        {
            services.AddScoped<TesteNavaDbContext>();
            services.AddScoped<ISaleItemRepository, SaleItemRepository>();
            services.AddScoped<ISaleRepository, SaleRepository>();
            services.AddScoped<ISellerRepository, SellerRepository>();
            services.AddScoped<ISaleService, SaleService>();
            return services;
        }
    }
}
