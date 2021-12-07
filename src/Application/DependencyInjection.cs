using Microsoft.Extensions.DependencyInjection;

namespace Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this ServiceCollection services)
    {
        return services;
    }
}
