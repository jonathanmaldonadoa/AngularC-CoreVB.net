using Microsoft.Extensions.DependencyInjection;
using Solution.Api.Application.Contracts.Services;
using Solution.Api.Application.Services;
using Solution.Api.DataAccess.Contracts.Repositories;
using Solution.Api.DataAccess.Repositories;

namespace Solution.Api.CrossCutting.Register
{
    public static class IoCRegister
    {
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {
            AddRegisterServices(services);
            AddRegisterRepositories(services);
            return services;
        }

        //register services
        private static IServiceCollection AddRegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IEmpresaService, EmpresaService>();
            services.AddTransient<IUBICACIONService, UBICACIONService>();
            services.AddTransient<IPersonaService, PersonaService>();

            return services;
        }

        /// register repositorories
        private static IServiceCollection AddRegisterRepositories(this IServiceCollection services)
        {
            services.AddTransient<IEMPRESARepository, EMPRESARepository>();
            services.AddTransient<IPERSONARepository, PERSONARepository>();
            services.AddTransient<ITIPODOCUMENTORepository, TIPODOCUMENTORepository>();
            services.AddTransient<IUBICACIONRepository, UBICACIONRepository>();
            return services;
        }

    }
}
