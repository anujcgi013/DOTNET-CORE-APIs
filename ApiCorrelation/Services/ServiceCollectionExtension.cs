
using ApiCorrelation.Configuation.Interface;

namespace ApiCorrelation.Services;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddCorrelationIdManager(this IServiceCollection sercices)
    {
        return sercices.AddScoped<ICorrelationIdGenerator, CorrelationIdGenerator>();
    }
}