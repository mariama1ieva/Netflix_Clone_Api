using Netflix.Repository.Repositories;
using Netflix.Repository.Repositories.Interface;
using System.Reflection;

namespace Netflix.Repository
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepositoryLayer(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly(); // or use typeof(SomeTypeInTargetAssembly).Assembly

            var types = assembly.GetTypes();

            var interfaces = types.Where(t => t.IsInterface && t.Name.EndsWith("Repository"));
            var implementations = types.Where(t => t.IsClass && !t.IsAbstract && t.Name.EndsWith("Repository"));

            foreach (var @interface in interfaces)
            {
                var implementation = implementations
                    .FirstOrDefault(c => @interface.IsAssignableFrom(c));

                if (implementation != null)
                {
                    services.AddScoped(@interface, implementation);
                }
            }

            // Also register generic base repository
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

            return services;
        }
    }
}
