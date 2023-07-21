using Microsoft.Extensions.DependencyInjection;
using TestTaskTIBURON.DB.Interfaces;
using TestTaskTIBURON.DB.Implementations;
using TestTaskTIBURON.DB.Implementations.Repositories;
using TestTaskTIBURON.DB.Interfaces.Repositories;
using TestTaskTIBURON.Core.Entities;

namespace TestTaskTIBURON.DB
{
    public static class ServiceRegistration
    {
        public static void AddDbInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            // This is the registration for custom repository class
            services.AddTransient<IGeneralRepository<Question>, QuestionRepository>();
        }
    }
}
