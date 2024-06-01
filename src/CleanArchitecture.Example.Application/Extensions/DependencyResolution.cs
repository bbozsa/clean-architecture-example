using CleanArchitecture.Example.Application.Common.Boundaries;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Example.Application.Extensions
{
    public static class DependencyResolution
    {
        public static void RegisterApplication(this IServiceCollection services)
        {
            services.RegisterUseCases();
        }

        private static void RegisterUseCases(this IServiceCollection services)
        {
            services.Scan(s => s.FromCallingAssembly()
                .AddClasses(filter =>
                {
                    filter.AssignableTo(typeof(IUseCase<>));
                })
                .AsSelfWithInterfaces()
                .WithTransientLifetime());
        }
    }
}
