using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CasgemMicroservice.Services.Order.Core.Application
{
    public static class ServisRegistiration
    {
        public static void AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ServisRegistiration).Assembly));
        }
    }
}
