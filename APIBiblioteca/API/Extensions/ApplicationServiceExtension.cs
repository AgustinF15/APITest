using Core.Interface;
using Infrastructure.UnitOfWork;
using Microsoft.AspNetCore.Identity;

namespace API.Extensions;

public static class ApplicationServiceExtension
{
    public static void AddAplicacionServices(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}
