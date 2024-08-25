using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace MaiaIO.FactoryWatch.Infra.Context
{
    public static class AuthContextConfig
    {


        public static void AuthContextConfiguration(this IServiceCollection services,
                                                 IConfiguration configuration)
        {
            services.AddDbContextPool<AuthContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("AuthContext"));
            });


            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AuthContext>();
        }
    }
}
