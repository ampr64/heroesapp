using HeroesBackend.BusinessLayer;
using HeroesBackend.Common;
using HeroesBackend.Common.Interfaces;
using HeroesBackend.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace HeroesBackend.Ioc
{
    public static class IoCExtension
    {
        public static IServiceCollection ConfigureIoCNetCore(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnection");

            services.AddSingleton<IStorageConfiguration>(new StorageConfiguration(connectionString))
                    .AddTransient<IHeroBusinessLayer, HeroBusinessLayer>()
                    .AddTransient<IHeroHomeBusinessLayer, HeroHomeBusinessLayer>()
                    .AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            return services;
        }
    }
}
