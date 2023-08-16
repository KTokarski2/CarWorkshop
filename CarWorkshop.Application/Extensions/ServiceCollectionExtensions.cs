using CarWorkshop.Application.Mappings;
using CarWorkshop.Application.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CarWorkshop.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ICarWorkshopService, CarWorkshopService>();
        services.AddAutoMapper(typeof(CarWorkshopMappingProfile));
    }
}