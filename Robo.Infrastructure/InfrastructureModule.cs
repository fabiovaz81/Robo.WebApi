using Microsoft.Extensions.DependencyInjection;
using Robo.Application.Interfaces;
using Robo.Application.Services;

namespace Robo.Infrastructure
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services
                .AddServices();

            return services;
        }

        private static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IControleRoboService, ControleRoboService>();
            services.AddScoped<IMovimentoRoboService, MovimentoRoboService>();

            return services;
        }
    }
}