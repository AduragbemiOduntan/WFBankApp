using Microsoft.Extensions.DependencyInjection;
using WFBankApp.Core.Abstraction;
using WFBankApp.Core.Implementation;
using WFBankApp.Repository.UnitOfWork.Abstractions;
using WFBankApp.Repository.UnitOfWork.Implementations;

namespace WFBankAppPresentation.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureUnitOfWork(this IServiceCollection services) =>
            services.AddScoped<IUnitOfWork, UnitOfWork>();

        public static void ConfigureServiceManager(this IServiceCollection services) =>
            services.AddScoped<IServiceManager, ServiceManager>();
    }
}
