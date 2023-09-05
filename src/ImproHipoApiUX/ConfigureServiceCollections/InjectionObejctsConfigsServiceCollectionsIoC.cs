using Application;
using Application.Boundaries;
using Application.Gateways;
using Infrastructure;
using Infrastructure.Gateways;
using Infrastructure.Interactors;

namespace ImproHipoApiUX.ConfigureServiceCollections
{
    public static class InjectionObejctsConfigsServiceCollectionsIoC
    {
        public static IServiceCollection AddInjectionDependecy(this IServiceCollection services)
        {
            //Capa de Infraestructure aqui Inyeccion de Dependencias Services and Repositories
            InfrastructureServiceRegistration.AddInfrastructureServices(services);
            //Capa de Aplicacion aqui Inyeccion de Dependencias
            ApplicationServiceRegistration.AddApplicationServices(services);
            return services;
        }
    }
}
