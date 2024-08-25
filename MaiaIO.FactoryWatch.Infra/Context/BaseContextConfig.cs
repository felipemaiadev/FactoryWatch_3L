using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace MaiaIO.FactoryWatch.Infra.Context
{
    public static class BaseContextConfig
    {

        public static void BaseContextConfiguration(this IServiceCollection services,
                                                    IConfiguration configuration)
        {
            services.AddDbContextPool<BaseContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("BaseContext"));
            });
        }

    }
}
