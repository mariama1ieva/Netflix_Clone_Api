using Netflix.Service.Helpers;
using System.Reflection;



namespace Netflix.Service
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServiceLayer(this IServiceCollection services)
        {
            // Register AutoMapper profile
            services.AddAutoMapper(typeof(MappingProfile));

            // Automatically register all services matching I*Service -> *Service
            var assembly = Assembly.GetExecutingAssembly();

            var types = assembly.GetTypes();

            var interfaces = types.Where(t => t.IsInterface && t.Name.EndsWith("Service"));
            var implementations = types.Where(t => t.IsClass && !t.IsAbstract && t.Name.EndsWith("Service"));

            foreach (var @interface in interfaces)
            {
                var implementation = implementations
                    .FirstOrDefault(c => @interface.IsAssignableFrom(c));

                if (implementation != null)
                {
                    services.AddScoped(@interface, implementation);
                }
            }

            return services;
        }
    }
}
