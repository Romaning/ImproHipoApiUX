using Application.Boundaries;
using Application.Gateways;
using Infrastructure.Gateways;
using Infrastructure.Interactors;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services/*, IConfiguration configuration*/)
        {
            //services.Configure<MailSettings>(configuration.GetSection("MailSettings")); //DOMAIN
            //services.AddTransient<IEmailService, EmailService>();
            //services.AddTransient<ICsvExporter, CsvExporter>();
            // Services
            services.AddScoped<IProdBoundary, ProdInteractor>();
            services.AddScoped<IClassProdBoundary, ClassProdInteractor>();
            services.AddScoped<ITypeProdBoundary, TypeProdInteractor>();
            services.AddScoped<IColorIBoundary, ColorInteractor>();
            services.AddScoped<ICotizacionItemBoundary, CotizacionItemInteractor>();
            services.AddScoped<IDescuentoComercialBoundary, DescuentoComercialnteractor>();

            // Repositories
            services.AddScoped<IProdGateway, ProdDsGatImpl>();
            services.AddScoped<IClassProdGateway, ClassProdDsGatImpl>();
            services.AddScoped<ITypeProdGateway, TypeProdDsGatImpl>();
            services.AddScoped<IColorGateway, ColorDsGatImpl>();
            services.AddScoped<ICotizacionItemGateway, CotizacionItemDsGatImpl>();
            services.AddScoped<IDescuentoComercialGateway, DescuentoComercialDsGatImpl>();

            return services;
        }
    }
}
