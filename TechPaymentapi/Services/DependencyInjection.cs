using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;
using Services.Services;

namespace Services
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            //Repository
            services.AddScoped<IProdutosRepository, ProdutosRepository>();
            services.AddScoped<IVendedoresRepository, VendedoresRepository>();

            //Service          
            services.AddScoped<IProdutosService, ProdutosService>();
            services.AddScoped<IVendedoresService, VendedoresService>();
        }
    }
}