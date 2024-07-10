using DevFreela.Core.Repositories;
using DevFreela.Core.Service;
using DevFreela.Core.Services;
using DevFreela.Instructure.MessageBus;
using DevFreela.Instructure.PaymentService;
using DevFreela.Instructure.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DevFreela.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ISkillRepository, SkillRepository>();

            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<IMessageBusService, MessageBusService>();

            return services;
        }
    }
}
